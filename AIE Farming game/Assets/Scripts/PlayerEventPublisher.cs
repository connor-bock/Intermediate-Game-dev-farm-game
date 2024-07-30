using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEventPublisher : MonoBehaviour
{
    public event EventHandler OnPlayerInteract;
    public event EventHandler OnPLayerShopOpen;
    public event EventHandler OnPLayerShopClose;    
    void Start()
    {
        OnPlayerInteract += Testing_OnPlayerInteract;
        OnPLayerShopOpen += Testing_OnPlayerShopOpen;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            OnPlayerInteract?.Invoke(this, EventArgs.Empty);
        }

        else if (Input.GetKeyDown(KeyCode.Tab))
        {
            OnPLayerShopOpen?.Invoke(this, EventArgs.Empty);
        }
        else if (Input.GetKeyUp(KeyCode.Tab))
        {
            OnPLayerShopClose?.Invoke(this, EventArgs.Empty);
        }

    }

    void Testing_OnPlayerInteract(object sender, EventArgs e)
    {
        Debug.Log("E Pressed!");
    }

    void Testing_OnPlayerShopOpen(object sender, EventArgs e)
    {
        Debug.Log("TAB pressed!");
    }
}
