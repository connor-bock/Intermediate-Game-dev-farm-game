using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CornBehavior : MonoBehaviour
{
    public GameObject CornDrop;
    public PlayerEventPublisher EP;
    public GameObject Corn;
    public QTElogic  QTE;

    // Start is called before the first frame update
    void Start()
    {
        //EP.OnPlayerInteract += OnPlayerInteract;
        //Corn.SetActive(false);  
        CornDrop.GetComponent<SpriteRenderer>().enabled = false;
        CornDrop.GetComponent<BoxCollider2D>().enabled = false;
        //QTE = FindAnyObjectByType<QTElogic>();
       
    }

    void OnPlayerInteract(object sender, EventArgs e)
    {
       // CornDrop.GetComponent<BoxCollider2D>().enabled = true;
        //CornDrop.GetComponent<SpriteRenderer>().enabled = true;
        //Corn.GetComponent<SpriteRenderer>().enabled = false;
        //Corn.GetComponent<BoxCollider2D>().enabled = false;
        
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //QTE = FindAnyObjectByType<QTElogic>();
            EP = other.gameObject.GetComponent<PlayerEventPublisher>();
            EP.OnPlayerInteract += OnPlayerInteract;
            QTE.OnQTEwin += Corndrop;

            //CornDrop.SetActive(false);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            EP = other.gameObject.GetComponent<PlayerEventPublisher>();
            EP.OnPlayerInteract -= OnPlayerInteract;
            QTE.OnQTEwin -= Corndrop;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //CornDrop.SetActive(false);
        //foreach (Collider2D c in GetComponents<Collider2D>())
        //{
            //c.enabled = false;
    }

        //gameObject.GetComponent<SpriteRenderer>().enabled = false;
    //}

    public void Corndrop(object sender, EventArgs e)
    {
        CornDrop.GetComponent<BoxCollider2D>().enabled = true;
        CornDrop.GetComponent<SpriteRenderer>().enabled = true;
        Corn.GetComponent<SpriteRenderer>().enabled = false;
    }
}
