﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour 
{
    public static int PlayerCount;
    public static int PlatformCount;
//    private int playerscore;
    
    void Update () {
        if (Input.GetKeyDown (KeyCode.Escape)) 
        {
            SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex - 1);
        }
    }
    public void LevelLoad (string lvl) 
    {
        SceneManager.LoadScene (lvl);
    }    
    public void ExitGame ()
    {
        print ("GET OUT'A HERE");
        Application.Quit ();
    }
    public void LoadNextLevel ()
    {
        SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex + 1);
//        playerscore = 0;
    }
    public void CheckPlayerCount () 
    {
        if (PlayerCount <= 0) {
            LoadNextLevel ();
        }
    }
}

