using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbDestroy : MonoBehaviour {
    
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Orb(Clone)")
        {
            ScoreBoard.scoreValue += 1;
            Destroy(col.gameObject);
        }
    }
}
