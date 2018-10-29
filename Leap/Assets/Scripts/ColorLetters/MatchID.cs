using UnityEngine;
using UnityEngine.Events;

public class MatchID : MonoBehaviour
{
    public NameID ID;
    public UnityEvent OnMatch;
    
    public void OnTriggerEnter(Collider other)
    {
        var id = other.GetComponent<ObjectID>().ID;
        Call(id);              
    }

    public void Call(NameID id)
    {
        if (id == ID)
            OnMatch.Invoke();
        print("Match motha flippa");
    }
}




/*
  public class MatchID : MonoBehaviour
{
    public NameID ID;
    public UnityEvent OnMatch;
    
    public void Invoke (NameID id)
    {
        if (id == ID)
        {
            OnMatch.Invoke();
            print("Match mother flippa");
        }
    }
}

 */
