using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Loading : MonoBehaviour {

	void Start () {
        Invoke("nextScene", 3);
	}

    void nextScene()
    {
        SceneManager.LoadScene(5);
    }
}
