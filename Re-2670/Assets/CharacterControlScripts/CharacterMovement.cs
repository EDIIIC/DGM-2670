using UnityEngine;


public class CharacterMovement : MonoBehaviour
{

	private CharacterController controller;
	public MovePattern Pattern;
	

	void Start ()
	{
		controller = GetComponent<CharacterController>();
	}
	
	
	void Update ()
	{
		Pattern().Invoke(controller, transform);
	}
	
}
