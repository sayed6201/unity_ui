using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PlayMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void quit(){
        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-1);
        SceneManager.LoadScene("MainMenuScene");

    }
}
