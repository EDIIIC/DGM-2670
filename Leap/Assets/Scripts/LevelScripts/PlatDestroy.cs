using UnityEngine;

public class PlatDestroy : MonoBehaviour {
    
    void OnCollisionEnter(Collision col)
    {
       if (col.gameObject.name == "platform(Clone)")
       {
           ScoreBoard.scoreValue += 10;
           Destroy(col.gameObject);
        }
    }

}
