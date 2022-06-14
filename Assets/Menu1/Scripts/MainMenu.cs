using System;
using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    
    [SerializeField] public GameObject settingMenu;

    void Start()
    {
         settingMenu.SetActive(false); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Play(){
        SceneManager.LoadScene("PlayScene");
        // SceneManager.LoadScene(ceneManager.GetActiveScene().buildIndex+1);
    }

    public void Option(){

    }

    public void Profile(){

        Application.Quit();

    }

}
