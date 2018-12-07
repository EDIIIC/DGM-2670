using UnityEngine;
using UnityEngine.Events;

public class NewEvent : MonoBehaviour
{
	public UnityEvent Event;
	//public delegate void HitAction ();
	//public static event HitAction OnLand;
	
	private void OnTriggerEnter()
	{
		print("hit trigger");
		Event.Invoke();
	}
}