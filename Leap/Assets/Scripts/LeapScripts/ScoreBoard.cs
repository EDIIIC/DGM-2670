﻿using UnityEngine;
using UnityEngine.UI;

public class ScoreBoard : MonoBehaviour
{
    public static int scoreValue = 0;
    Text score;

    private void Start()
    {
        score = GetComponent<Text>();
    }

    private void Update()
    {
        score.text = "SCORE: " + scoreValue;
    }
}







/*    
    public int score;
    public Text currentDisplay;
    public Text highscoreDisplay;

    void Start () {
        score = 0;
        if (currentDisplay != null) {
            currentDisplay.text = score.ToString ();
        }
        if (highscoreDisplay != null)
            highscoreDisplay.text = GetScore ().ToString ();
    }

    public void IncrementScoreBoard(int valUe){
        score += valUe;
        currentDisplay.text = score.ToString ();
    }

    public void SaveScore(){
//Check previous score
        int oldScore = GetScore();

//if new score is higher than previous score
        if(score > oldScore)

            PlayerPrefs.SetInt ("HighScore", score);
    }

    public int GetScore(){
        return PlayerPrefs.GetInt ("HighScore");
    }

    public void OnDisable(){
        SaveScore ();
    }

}
*/
