using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	public static int PlayerCount;


	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) {
	//		LoadNextLevel ();
			SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex - 1);
		}
	}
		
	public void LevelLoad (string lvl) {
		SceneManager.LoadScene (lvl);
	}
		
	public void ExitGame (){
		print ("Quit game.");
		Application.Quit ();
	}

	public void LoadNextLevel (){
		SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex + 1);
	}

	public void CheckPlayerCount () {
		if (PlayerCount <= 0) {
			LoadNextLevel ();
		}
	}

}
	
