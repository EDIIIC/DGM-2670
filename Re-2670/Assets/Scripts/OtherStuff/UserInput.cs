using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInput : MonoBehaviour
{

	public Actions Action;

	private void OnMouseDown()
	{
		Action.Raise();
	}
}
