using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Player;
    public Vector3 SpawnPoint;
    public static GameManager Instance;
    public bool InGameScene = true;
    //private bool First = false;
    // Start is called before the first frame update
    void OnLevelWasLoaded()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        Debug.Log("ENTER");
       if (SpawnPoint != null && InGameScene == true)
        {
            Player.transform.position = SpawnPoint;
            SpawnPoint = new Vector3(0, 0, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Awake()
    {

        Debug.Log("AWAKE");
        if (Instance != null && Instance != this.gameObject)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
} // come back to this 
