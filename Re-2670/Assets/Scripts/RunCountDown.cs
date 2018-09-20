using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RunCountDown : MonoBehaviour
{

	private Text label;

	IEnumerator Start()
	{
		label = GetComponent<Text>();

		int number = 3;

		while (number > 0)
		{
			//	yield return new WaitForSeconds(0.01f);    <-runs faster
			yield return new WaitForSeconds(1);
			label.text = number.ToString();
			number--;
		}
		label.text = "1";
		yield return new WaitForSeconds(1);
		label.text = "Get on top of the citadel";
		yield return new WaitForSeconds(2);
		label.text = "GO!";
		yield return new WaitForSeconds(3);
		label.text = "";
	}
}