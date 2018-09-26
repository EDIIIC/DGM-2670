using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "Word")]
public class Word : ScriptableObject
{
	public UnityEvent Solved;

	public string TheWord;

	public void Solving()
	{
		foreach (var letter in TheWord)
		{
			//mark as added
		}
	}
}
