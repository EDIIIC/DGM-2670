//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using System.Collections;

[RequireComponent(typeof(CharacterController))]
public class CharacterMovement : MonoBehaviour
{
	public int health;
	public GameObject levelManager;
	private CharacterController controller; //moves object
	public MovePattern Pattern;
	
	void Start ()
	{
		controller = GetComponent<CharacterController>();
	}
		
	void Update () 
	{
		Pattern.Invoke(controller, transform);
	}
}
