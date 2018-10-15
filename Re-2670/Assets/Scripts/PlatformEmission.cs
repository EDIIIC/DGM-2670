using System.Collections;
using UnityEngine;

public class PlatformEmission : MonoBehaviour {

	bool isSpawning = false;
	public float MinSpawnTime = 5f;
	public float MaxSpawnTime = 5f;
	public GameObject[] enemies;

	IEnumerator SpawnObject (int index, float seconds) {
		yield return new WaitForSeconds (seconds);
		Instantiate (enemies [index], transform.position, transform.rotation);
		isSpawning = false;
	}


	void Update () {
		if (!isSpawning) {
			isSpawning = true;
			int enemyIndex = Random.Range (0, enemies.Length);
			StartCoroutine (SpawnObject (enemyIndex, Random.Range (MinSpawnTime, MaxSpawnTime)));
		}
	}
}