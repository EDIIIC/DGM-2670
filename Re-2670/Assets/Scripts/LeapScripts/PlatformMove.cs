using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMove : MonoBehaviour
{
	public float speed;
	public int life;
	private GameObject player;
	private Rigidbody rigid;

	void Start()
	{
//	    player = FindObjectOfType<PlayerController>().gameObject;
		rigid = GetComponent<Rigidbody>();

//speed
		rigid.AddRelativeForce(new Vector3(Random.Range(0, speed), 0f), ForceMode.Force);
	}

//COLLISION DAMAGE
	private void OnCollisionEnter(Collision coll)
	{
		coll.gameObject.GetComponent<Health>().IncrementHealth(-1);
	}

	public void IncrementHealth(int value)
	{
		life += value;
		if (life <= 0)
		{
			LevelManager.PlatformCount--;
			Destroy(this.gameObject);
		}
	}
}