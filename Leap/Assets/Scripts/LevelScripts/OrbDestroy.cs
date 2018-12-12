using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbDestroy : MonoBehaviour {
    
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Orb(Clone)")
        {
            ScoreBoard.scoreValue += 5;
            Destroy(col.gameObject);
        }
    }
}
