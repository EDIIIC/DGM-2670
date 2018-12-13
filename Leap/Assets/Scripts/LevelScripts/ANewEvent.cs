using UnityEngine;
using UnityEngine.Events;

public class ANewEvent : MonoBehaviour
{
	public UnityEvent Event;
	
	private void OnTriggerEnter()
	{
		print("hit trigger");
		Event.Invoke();
	}
}