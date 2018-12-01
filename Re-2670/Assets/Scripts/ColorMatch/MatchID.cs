using UnityEngine.Events;
using UnityEngine;


public class MatchID : MonoBehaviour
{
    public NameID Id;
    private NameID id;
    public UnityEvent OnMatch;
    public UnityEvent NoMatch;
//    public UnityEvent OnRestart;
//    public FloatData HoldTime;
//    public BoolData Matched;

    public void OnTriggerEnter(Collider other)
    {
        var id = other.GetComponent<ObjectID>().ID;
        CompareMatch(id);
    }

    public void CompareMatch(NameID match)
    {
        if (match == Id)
        {
//            Matched.Value = true;
            OnMatch.Invoke();
            print("Match motha flippa");
//            StartCoroutine(Restart());
        }
        else
        {
            NoMatch.Invoke();
        }
    }
/*
    public void CallRestart()
    {
        StartCoroutine(Restart());
    }

    public IEnumerator Restart()
    {
        if (Matched)
        {
            yield return new WaitForSeconds(HoldTime.Value);
        }

        Matched.Value = false;
        OnRestart.Invoke();
    }
*/ 
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
