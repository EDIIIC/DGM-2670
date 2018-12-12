using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatDestroy : MonoBehaviour {
    
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "platform(Clone)")
        {
            ScoreBoard.scoreValue += 1;
            Destroy(col.gameObject);
        }
    }
}
