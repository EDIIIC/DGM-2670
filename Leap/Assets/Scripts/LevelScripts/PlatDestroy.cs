using UnityEngine;

public class PlatDestroy : MonoBehaviour {
    
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name != "platform(Clone)") return;
        ScoreBoard.scoreValue += 10;
        Destroy(col.gameObject);
    }

}