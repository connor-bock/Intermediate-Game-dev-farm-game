using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class ShopLogic : MonoBehaviour 
{
    public PlayerEventPublisher EP;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponentInChildren<TextMeshProUGUI>().enabled = false;
        EP.OnPLayerShopOpen += OnPlayerShopOpen;
        EP.OnPLayerShopClose += OnPLayerShopClose;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnPlayerShopOpen(object sender, EventArgs e)
    {
        gameObject.GetComponentInChildren<TextMeshProUGUI>().enabled = true;
        //gameObject.SetActive(true);
        Debug.Log("shop opened!");
    }

    void OnPLayerShopClose(object sender, EventArgs e)
    {
        gameObject.GetComponentInChildren<TextMeshProUGUI>().enabled = false;
    }
}
