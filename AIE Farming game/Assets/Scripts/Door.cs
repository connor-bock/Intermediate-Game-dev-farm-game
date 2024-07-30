using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{

    public string SceneToLoad;
    public GameObject spawnPoint;

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
        SceneChange(SceneToLoad);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
