using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameOverScene : MonoBehaviour {

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
        if (GUI.Button(new Rect((screenW / 2) - (ButtonW / 2), (screenH / 2) - (ButtonH / 2), ButtonW, ButtonH), "Try Again"))
        {
            SceneManager.LoadScene(1);
        }

        if (GUI.Button(new Rect((screenW / 2) - (ButtonW / 2), ((screenH / 2) - (ButtonH / 2)) + 50, ButtonW, ButtonH), "High Score"))
        {
            SceneManager.LoadScene(3);
        }

        if (GUI.Button(new Rect((screenW / 2) - (ButtonW / 2), ((screenH / 2) - (ButtonH / 2)) + 100, ButtonW, ButtonH), "Exit"))
        {
            print("QUIT!");
            //Application.Quit();
        }
    }
}
