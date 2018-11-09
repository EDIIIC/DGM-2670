using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
[CreateAssetMenu(fileName = "Single Variables/IntData")]
public class IntData : ScriptableObject
{
    public int Value;

    public void UpdateValue(int i)
    {
        Value += i;
    }
    
}