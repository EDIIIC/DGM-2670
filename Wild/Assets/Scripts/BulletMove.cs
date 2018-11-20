using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    public float speed;

//	public int life;
    private GameObject player;
    private Rigidbody rigid;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();

//speed
        rigid.AddRelativeForce(new Vector3(Random.Range(0, speed), 0f), ForceMode.Force);
    }
}