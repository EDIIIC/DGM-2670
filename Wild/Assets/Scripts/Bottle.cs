using UnityEngine;

public class Meteor : MonoBehaviour
{

	//public int health;
	public float startingSpin;
	public float speed;

	private GameObject Player;
	private Rigidbody2D rigid;

	void Start()
	{

		Player = FindObjectOfType<PlayerController>().gameObject;
		//rigid = GetComponent<Rigidbody>();

		//Where to go      
		transform.right = Player.transform.position - transform.position;

		//speed
		rigid.AddRelativeForce(new Vector2(Random.Range(0, speed), 0f));

		//Random Rotation
		rigid.AddTorque(Random.Range(-startingSpin, startingSpin));

	}
//	private void OnCollisionEnter2D(Collision2D coll)
//	{
//		coll.gameObject.GetComponent<Health>().IncrementHealth(-1);
//	}
}