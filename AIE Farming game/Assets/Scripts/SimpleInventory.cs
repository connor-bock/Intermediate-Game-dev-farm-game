using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SimpleInventory : MonoBehaviour
{
    public List<GameObject> Items;

    //Inventory slots in the UI
    public List<GameObject> InventorySlots;

    public GameObject InventoryUI;
    public Image defaultButtonImage;

    public void Start()
    {
        InventoryUI.SetActive(false);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Item") && Items.Count < InventorySlots.Count)
        {
            AddItem(other.gameObject);
            other.gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (InventoryUI.activeSelf == false && Input.GetKeyDown(KeyCode.F))
        {
            InventoryUI.SetActive(true);
        }
        else if (InventoryUI.activeSelf == true && Input.GetKeyDown(KeyCode.F))
        {
            InventoryUI.SetActive(false);
        }
    }

    void AddItem(GameObject item)
    {
        Items.Add(item);

        UpdateInventoryUI();
    }

    void UpdateInventoryUI()
    {
        //Go through each Item in the list. Set the Item's Image to be the equilivant "Inventory UI" Image.
        for (int i = 0; i < InventorySlots.Count; i++)
        {
            if (Items.Count > i && Items[i] != null)
            {
                //If the Item is using SPRITERENDERER
                if (Items[i].GetComponent<SpriteRenderer>() != null)
                {
                    InventorySlots[i].GetComponent<Image>().sprite = Items[i].GetComponent<SpriteRenderer>().sprite;
                }
                //IF the Item is using IMAGE
                else if (Items[i].GetComponent<Image>() != null)
                {
                    InventorySlots[i].GetComponent<Image>().sprite = Items[i].GetComponent<Image>().sprite;
                }


                //  InventorySlots[i].SetActive(true);
            }
            else
            {
                InventorySlots[i].GetComponent<Image>().sprite = defaultButtonImage.sprite;
            }
        }
    }

    public void RemoveItem(GameObject ThisInventorySlot)
    {
        //Check if there is an item to remove
        if (Items.Count > 0)
        {
            //Match this inventorySlot with the list
            int slotToRemove = 0;

            foreach (GameObject inventorySlot in InventorySlots)
            {
                if (inventorySlot == ThisInventorySlot)
                {
                    //Exits check once it finds the same item in the inventory
                    break;
                }
                slotToRemove++;
            }
            Items.RemoveAt(slotToRemove);
            UpdateInventoryUI();
        }
    }
}

