﻿
using UnityEngine;
public class Life : MonoBehaviour {
    public int life;
//    public GameObject explosionEffect;
    public GameObject[] hearts;
    public GameObject scoreboard;
    private void Start()
    {
        scoreboard = FindObjectOfType<ScoreBoard> ().gameObject;
        if (MePlayer()) 
        {
            ShowHearts ();
        }  
    }
    private bool MePlayer()
    {
        if (GetComponent<PlayerController> ()) 
        {
            return true;
        }
        else 
        {
            return false;
        }
        
    }
    public void IncrementHealth(int value) 
    {
        life += value;
        //damage instead of value?^^
        if (life <= 0) 
        {
            Destroy (gameObject);
//            Instantiate (explosionEffect, transform.position, Quaternion.identity);
            if (!MePlayer ()) 
            {
//               IncrementScore ();
            }
//           if (MePlayer()) 
//           {
//               gameObject.GetComponent<PlayerController>().levelManager.GetComponent<LevelManager>().LoadNextLevel();
//           }
        }
        if (MePlayer()) 
        {
            ShowHearts ();
        }  
    }
    private void ShowHearts()
    {
        //Turn all hearts off
        for (int i = 0; i < hearts.Length; i++) 
        {
            hearts[i].SetActive (false);  }
        //Turn hearts on by health
        for (int i = 0; i < life; i++) 
        {
            hearts [i].SetActive (true);     
        }  
    }  
    public int GetHealth()
    {
        return life;  
    }
//    private void IncrementScore()
//    {
//        scoreboard.GetComponent<ScoreBoard> ().IncrementScoreBoard (10);
//    }  
}

