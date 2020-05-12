using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour {

    public int difficulty;
    public int level;

	void Update () {
	    if(ScoreManager.instance.getNow() >= difficulty)
        {
            SceneManager.LoadScene(level);
        }
	}
}