using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

    public static GameOver instance;

    void Awake()
    {
        if (instance == null)
            instance = this;
    }

    void Update()
    {
        gameOver();
    }

    public void gameOver()
    {
        if (Raycast.instance.gun_bullet <= 0 && Raycast.instance.rpg7_bullet <= 0 && Raycast.instance.raygun_bullet <= 0)
        {
            SceneManager.LoadScene(2);
        }
    }
}
