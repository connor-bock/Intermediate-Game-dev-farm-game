using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventSubscriber : MonoBehaviour
{
    public PlayerEventPublisher EP;
    public QTElogic QTElogic;



    void OnPlayerInteract(object sender, EventArgs e)
    {
        //gameObject.SetActive(false);
        QTElogic.QuickTimeEvent();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            EP = other.gameObject.GetComponent<PlayerEventPublisher>();
           //QTElogic.QuickTimeEvent();
            EP.OnPlayerInteract += OnPlayerInteract; 
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            EP = other.gameObject.GetComponent<PlayerEventPublisher>();
            EP.OnPlayerInteract -= OnPlayerInteract;
        }
    }

    //void 
}
