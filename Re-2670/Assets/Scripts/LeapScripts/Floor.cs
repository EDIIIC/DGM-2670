using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor : MonoBehaviour {

	public LevelManager myLevelManager;

	void OnTriggerEnter (Collider trigger) {
		myLevelManager.LevelLoad ("GameOver");
	}
}

/*
public class PlayerDestroy : MonoBehaviour {
    
    void OnCollisionEnter(Collision col)
    {
       if (col.gameObject.name == "Player")
        {
            Destroy(col.gameObject);
        }
    }
}
*/
