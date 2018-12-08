using UnityEngine;
using UnityEngine.Events;

public class NewEvent : MonoBehaviour
{
	public UnityEvent Event;
	
	private void OnTriggerEnter()
	{
		print("hit trigger");
		Event.Invoke();
	}
}