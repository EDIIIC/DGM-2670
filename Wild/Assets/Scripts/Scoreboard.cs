using UnityEngine;
using UnityEngine.UI;

public class ScoreBoard : MonoBehaviour
{
    public static int scoreValue = 0;
    Text score;

    private void Start()
    {
        scoreValue = 0;
        score = GetComponent<Text>();
    }
    
    private void Update()
    {
        score.text = "SCORE: " + scoreValue;
    }
}