using System.Collections;
using UnityEngine;

public class Snap : MonoBehaviour
{

	private Transform parent;
	private bool canRun = true;
	public FloatData Speed;
	public FloatData HoldTime;

	private void OnTriggerEnter(Collider other)
	{
		parent = other.transform;
	}

	public void Call()
	{
		StartCoroutine(MoveTo());
		StartCoroutine(Stop());
	}

	private IEnumerator Stop()
	{
		yield return new WaitForSeconds(HoldTime.Value);
		canRun = false;
	}
	
	private IEnumerator MoveTo()
	{
		while (canRun)
		{
			yield return new WaitForFixedUpdate();
			transform.position = Vector3.Lerp(transform.position, parent.position, Speed.Value);
		}

		transform.parent = parent;
	}
}

