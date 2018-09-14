using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]

public class CharacterMovement : MonoBehaviour
{

	private CharacterController controller;
	public MovePattern Pattern;
	
	void Start ()
	{
		controller = GetComponent<CharacterController>();
	}
		
	void Update () {
		Pattern.Invoke(controller, transform);
	}
}
