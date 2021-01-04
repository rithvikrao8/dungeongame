﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScreen : MonoBehaviour
{
    public string NewGameScene;
    // Use this for Initialization
    void Start()
    {
        
    }

    //Update is called once per frame
    void Update()
    {
        
    }

    public void NewGame()
    {
        SceneManager.LoadScene(NewGameScene);
    }


    public void QuitGame()
    {
        Application.Quit();
    }
}


