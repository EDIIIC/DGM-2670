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