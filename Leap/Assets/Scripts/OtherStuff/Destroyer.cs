﻿using UnityEngine;

public class Destroyer : MonoBehaviour
{

    public float HoldTime = 2;
    public bool UseTrigger = true;
/*
    IEnumerator Start()
    {
        yield return new WaitForSeconds(HoldTime);
        Destroy(gameObject);
    }
*/
    public void DestroyObj()
    {
        Destroy(gameObject);
    }

    public void DestroyAvy(Object obj)
    {
        Destroy(obj);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (UseTrigger)
        {
            Destroy(other.gameObject);
        }
    }
}
