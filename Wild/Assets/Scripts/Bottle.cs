using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bottle : MonoBehaviour {

	public float startingSpin;
	public float speed;

	private GameObject player;
	private Rigidbody2D rigid;

	void Start () {
		
//		player = FindObjectOfType<PlayerController> ().gameObject;

		//Where to go      
		transform.right = player.transform.position - transform.position;

		//speed
		rigid.AddRelativeForce(new Vector3(Random.Range(0,speed),0f));

		//Random Rotation
		rigid.AddTorque (Random.Range(-startingSpin,startingSpin));

	}

	// private void OnCollisionEnter2D(Collision2D coll){
	//     coll.gameObject.GetComponent<Health> ().IncrementHealth (-1);
}
