using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;

[CreateAssetMenu (fileName = "HighScore")]

public class HighScores_SO : ScriptableObject
{
    public List<int> highScores;
    public int score;
//    public Text currentDisplay;
//    public Text highscoreDisplay;
    
    
    public void OrderScores()
    {
        //does stuff?
    }
    
//    
    public void SaveScore()
    {
        //Check previous score
        int oldScore = GetScore();

        //if new score is higher than previous score
        if(score > oldScore)
            PlayerPrefs.SetInt ("HighScore", score);
    }

    
    public int GetScore()
    {
        return PlayerPrefs.GetInt ("HighScore");
    }

    
    public void OnDisable()
    {
        SaveScore ();
    }
//
   
}

/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName = "HighScore")]

public class HighScores_SO : ScriptableObject
{
    public List<int> highScores;

    public void OrderScores()
    {
        //does stuff
    }
    
}
*/