using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class HighScore : MonoBehaviour {

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
        GUI.color = Color.red;
        GUI.Label(new Rect((Screen.width/1.2f) - 50, (Screen.height/2), 150, 30), "Best Score:");
        GUI.Label(new Rect((Screen.width / 1.2f) + 50, (Screen.height / 2), 150, 30), ScoreManager.instance.getScore().ToString());

        if (GUI.Button(new Rect((screenW / 2) - (ButtonW / 2), (screenH / 2) - (ButtonH / 2), ButtonW, ButtonH), "Menu"))
        {
            SceneManager.LoadScene(0);
        }

        if (GUI.Button(new Rect((screenW / 2) - (ButtonW / 2), ((screenH / 2) - (ButtonH / 2)) + 150, ButtonW, ButtonH), "Exit"))
        {
            print("QUIT!");
            //Application.Quit();
        }
    }
}
