using System.Collections;
using System.Collections.Generic;
using System.Reflection.Emit;
using UnityEngine;
using UnityEngine.UI;

public class UpdateText : MonoBehaviour
{

	public ActionObject Action;
	private Text Label;
	private IntData number;
	
	void Start ()
	{
		Label = GetComponent<Text>();
		Action.Raise += RaiseHandler;
	}

	private void RaiseHandler()
	{
		number.Value++;
	}

}
