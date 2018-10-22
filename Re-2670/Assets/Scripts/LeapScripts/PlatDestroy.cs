using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatDestroy : MonoBehaviour {
    
    void OnCollisionEnter(Collision col)
    {
       if (col.gameObject.name == "platform(Clone)")
        {
            Destroy(col.gameObject);
        }
    }
}
