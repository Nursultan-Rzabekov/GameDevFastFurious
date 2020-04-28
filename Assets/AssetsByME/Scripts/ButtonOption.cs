﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonOption : MonoBehaviour {
    public void playGame()
    {
        SceneManager.LoadScene(2);
    }
    public void TrackSelect()
    {
        SceneManager.LoadScene(1);
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void quitGame()
    {
        // if (Input.GetKey("escape"))
        Application.Quit();
        
    }


    public void track01()
    {
        SceneManager.LoadScene(3);
    }
    public void track02()
    {
        SceneManager.LoadScene(4);
    }
    public void track03()
    {
        SceneManager.LoadScene(5);
    }
    public void track04()
    {
        SceneManager.LoadScene(6);
    }
    public void track05()
    {
        SceneManager.LoadScene(7);
    }
}
