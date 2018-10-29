﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruction : MonoBehaviour {

    public int damage;

    void OnTriggerEnter(Collider other){
        other.GetComponent<Health> ().IncrementHealth (damage);
        Destroy (gameObject);
    }
}
