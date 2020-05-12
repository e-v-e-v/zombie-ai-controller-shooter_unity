using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour {

    float screenW;
    float screenH;
    float ButtonW = 160;
    float ButtonH = 40;

    void Start()
    {
        screenW = Screen.width;
        screenH = Screen.height;
    }

    void OnGUI()
    {
        if(GUI.Button(new Rect((screenW / 2) - (ButtonW / 2), (screenH / 2) - (ButtonH / 2), ButtonW, ButtonH), "Start"))
        {
            SceneManager.LoadScene(1);
        }

        if (GUI.Button(new Rect((screenW / 2) - (ButtonW / 2), ((screenH / 2) - (ButtonH / 2)) + 50, ButtonW, ButtonH), "Levels"))
        {
            SceneManager.LoadScene(4);
        }

        if (GUI.Button(new Rect((screenW / 2) - (ButtonW / 2), ((screenH / 2) - (ButtonH / 2)) + 100, ButtonW, ButtonH), "High Score"))
        {
            SceneManager.LoadScene(3);
        }

        if (GUI.Button(new Rect((screenW / 2) - (ButtonW / 2), ((screenH / 2) - (ButtonH / 2)) + 150, ButtonW, ButtonH), "Exit"))
        {
            print("QUIT!");
            //Application.Quit();
        }
    }

	void Update () {
        transform.Translate(Vector3.down * 3 * Time.deltaTime);
	}
}
