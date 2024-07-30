using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HouseLogic : MonoBehaviour
{
    public string sceneToLoad;
    //public GameObject HouseIntPlayer;
    public Transform returnSpawn;
    public bool MainRoom = true;

    public void SceneChange(string sceneName)
    {
        if (sceneName != null)
        {
            SceneManager.LoadScene(sceneName);
            //HouseIntPlayer.SetActive(true);
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            //HouseIntPlayer.SetActive(true);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameManager GM = FindAnyObjectByType<GameManager>();
        if (MainRoom == true)
        {
            GM.InGameScene = false;
            //GameManager GM = FindAnyObjectByType<GameManager>();
            GM.SpawnPoint = new Vector3(returnSpawn.position.x, returnSpawn.position.y, returnSpawn.position.z);
        }
        else
        {
            GM.InGameScene= true;
        }
        SceneChange(sceneToLoad);
    }

    private void Start()
    {
        //gameObject.CompareTag("HouseIntPlayer");
        //HouseIntPlayer.SetActive(false);
       
    }

}
