using UnityEngine;
using System.Collections;

public class ScoreManager : MonoBehaviour {

    public static ScoreManager instance;
    public int Score;
    public int now = 0;

    void Awake()
    {
        if (instance == null)
            instance = this;
        Score = PlayerPrefs.GetInt("Score");
    }

    public void addScore(int val = 1)
    {
        now += val;
        Score += val;
        PlayerPrefs.SetInt("Score", Score);
    }

    public void deductScore(int val = 1)
    {
        now -= val;
        Score -= val;
        PlayerPrefs.SetFloat("Score", Score);
    }

    public int getScore()
    {
        return Score;
    }

    public int getNow()
    {
        return now;
    }
}
