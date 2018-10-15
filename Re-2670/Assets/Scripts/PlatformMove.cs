using UnityEngine;

public class PlatformMove : MonoBehaviour {

	public float speed;

	private GameObject player;
	private Rigidbody rigid;

	void Start () {
		
		player = FindObjectOfType<PlayerController> ().gameObject;
		rigid = GetComponent<Rigidbody> ();

		//speed
		rigid.AddRelativeForce(new Vector2(Random.Range(0,speed),0f),ForceMode.Force);

	}
	
/*COLLISION DAMAGE
	private void OnCollisionEnter2D(Collision2D coll){
		coll.gameObject.GetComponent<Health> ().IncrementHealth (-1);
	}
	*/


	/*
	private void OnCollisionEnter2D(Collision2D coll){
		coll.gameObject.GetComponent<Health> ().IncrementHealth (-1);

				health--;
				count++;
				if (count > picture.Length - 1) {
					count--;
				}

				GetComponent<SpriteRenderer>().sprite = picture[count];

				if (health <= 0) {
					LevelManager.PlatformCount--;
					Destroy (this.gameObject);
		}

	}
	*/

}
