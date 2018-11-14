using UnityEngine;

public class Health : MonoBehaviour {

    public int health;
   
/*
    private bool MePlayer(){
        if (GetComponent<CharacterController> ()) {
            return true;
        } else {
            return false;
        }
    }
*/
    
    public void IncrementHealth(int value) {
        health += value;
        if (health <= 0) {
            Destroy (gameObject);
                         }
    }
	
    
    public int GetHealth(){
        return health;
    }

    
    private void OnCollisionEnter(Collision coll){
        coll.gameObject.GetComponent<Health> ().IncrementHealth (-1);
    }
}