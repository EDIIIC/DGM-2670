using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelManager : MonoBehaviour 
{
/*    
    public static int PlayerCount;
    public static int PlatformCount;
*/
    public HighScores_SO highScoresSo;
    public GameObject scoreboard;

    
    void Update () {
        if (Input.GetKeyDown (KeyCode.Return)) 
        {
            SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex - 1);
        }
    }
    
    public void LevelLoad (string lvl) 
    {
        SceneManager.LoadScene (lvl);
    }    
     
    public void ExitGame ()
    {
        print ("GET OUT'A HERE");
        highScoresSo.highScores.Add(ScoreBoard.scoreValue);
        highScoresSo.OrderScores();
        Application.Quit ();
    }
     
    public void LoadNextLevel ()
    {
        SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex + 1);
//        playerscore = 0;
    }
    
}

