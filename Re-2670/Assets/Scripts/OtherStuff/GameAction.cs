using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "Actions/Game Action")]
public class GameAction : MonoBehaviour
{
    public UnityAction<object> Raise;
    public UnityAction<Coroutine> RaiseCoroutine;
    public UnityAction RaiseNoArgs;
    
    //Overloading
    public void RaiseAction()
    {
        RaiseNoArgs();
    }

    public void RaiseAction(object obj)
    {
        Raise(obj);
    }
    
    public void RaiseAction(float obj)
    {
        Raise(obj);
    }
    
    public void RaiseAction(Transform obj)
    {
        Raise(obj);
    }
    
    public void RaiseAction(Coroutine obj)
    {
        RaiseCoroutine(obj);
    }
}
