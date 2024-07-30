using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class QTElogic : MonoBehaviour
{
    public Button QTE;
    private bool qteON;
    private float TimerAmount = 1;
    private float CurrentTimer;
    private bool PassQTE;
    public event EventHandler OnQTEwin; 

    
    // Start is called before the first frame update
    void Start()
    {
       QTE.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
       if (qteON == true)
        {
            //press E here to complete QTE (Bool?) 
            if (Input.GetKeyDown(KeyCode.Q) && CurrentTimer > 0)
            {
                PassQTE = true;
                OnQTEwin?.Invoke(this, EventArgs.Empty);
                QTE.gameObject.SetActive(false);
            }

            CurrentTimer -= Time.deltaTime;
            if (CurrentTimer < 0)
            {
                PassQTE = false;
                QTE.gameObject.SetActive(false);
            }
        }
    }

    public void QuickTimeEvent()
    {
        QTE.gameObject.SetActive(true);
        CurrentTimer = TimerAmount;
        qteON = true;
    }
}
