using UnityEngine;

public class SideScroll : MonoBehaviour {

	public float Height;

	private Transform gunTrans;


	void Start () {
		gunTrans = gameObject.GetComponent<Transform> ();
	}

	// Update is called once per frame
	void Update () {
		//get mouse position, translating to world coordinates
		Vector3 mousePos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		//override vertical y position
		mousePos.y = Height;
		//override z depth position
		mousePos.z = 0;

		//apply mouse poition coordinates to the paddle
		gunTrans.position = mousePos;
	}
}
