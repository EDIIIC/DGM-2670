using UnityEngine;
using UnityEngine.Events;


public class AnyEvent : MonoBehaviour
{
    public ActionObject Action;
    public UnityEvent Event;

    
    void Start()
    {
        Action.Raise += RaiseHandler;
    }

    private void RaiseHandler()
    {
        Event.Invoke();
    }
}
