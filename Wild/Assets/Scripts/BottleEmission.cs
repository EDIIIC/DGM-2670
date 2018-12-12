using System.Collections;
using UnityEngine;

public class BottleEmission : MonoBehaviour
{    
    public float MinSpawnTime = 5f;
    public float MaxSpawnTime = 5f;
    
    public GameObject[] enemies;
    bool isSpawning = false;
    public GameObject spawned;
    
    public Transform shotPos;
    public float shotForce;
    private Rigidbody rigid;
    
    
    IEnumerator SpawnObject (int index, float seconds) {
        yield return new WaitForSeconds (seconds);
        Instantiate (enemies [index], transform.position, transform.rotation);
        
        isSpawning = false;
    }
    
    
    void Update()
    {
        if (!isSpawning)
        {
            isSpawning = true;
            int enemyIndex = Random.Range (0, enemies.Length);
            StartCoroutine (SpawnObject (enemyIndex, Random.Range (MinSpawnTime, MaxSpawnTime)));
        }  

        {
            GameObject shot = Instantiate(spawned, shotPos.position, shotPos.rotation);
            shot.GetComponent<Rigidbody>().AddForce(shotPos.up * shotForce);
        }
    }
} 



/*
using System.Collections;
using UnityEngine;

public class BottleEmission : MonoBehaviour
{    
    public float MinSpawnTime = 5f;
    public float MaxSpawnTime = 5f;
    
    public GameObject[] enemies;
    bool isSpawning = false;
    public GameObject spawned;
    
    public Transform shotPos;
    public float shotForce;
    private Rigidbody rigid;
    
    
    IEnumerator SpawnObject (int index, float seconds) {
        yield return new WaitForSeconds (seconds);
        Instantiate (enemies [index], transform.position, transform.rotation);
        isSpawning = false;
    }
    
    
    void Update()
    {
        if (!isSpawning)
        {
            isSpawning = true;
            int enemyIndex = Random.Range (0, enemies.Length);
            StartCoroutine (SpawnObject (enemyIndex, Random.Range (MinSpawnTime, MaxSpawnTime)));
        }  

        {
            GameObject shot = Instantiate(spawned, shotPos.position, shotPos.rotation);
            shot.GetComponent<Rigidbody>().AddForce(shotPos.up * shotForce);
        }
    }
} 
*/