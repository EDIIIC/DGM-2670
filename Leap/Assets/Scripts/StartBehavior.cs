using UnityEngine;
using UnityEngine.Events;

public class StartBehavior : MonoBehaviour
{
	public UnityEvent Event;
	
	void Start () {
		Event.Invoke();
	}

}
