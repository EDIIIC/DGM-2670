using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class CharacterMovement : MonoBehaviour
{
	//public int health;
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
