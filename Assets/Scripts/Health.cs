using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {

    public float H;

    void Start()
    {
        H = Random.Range(10, 45);
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.transform.tag == "bullet")
        {
            H -= 5;
        }
        else if (col.transform.tag == "rpg7")
        {
            H -= 8;
        }

        if (col.transform.tag == "raygun")
        {
            H -= 15;
        }

        if (H <= 0)
        {
            ScoreManager.instance.addScore();
            Destroy(gameObject);
        }

        if (col.transform.tag == "rpg7" || col.transform.tag == "bullet" || col.transform.tag == "raygun")
        {
            Destroy(col.gameObject);
        }
    }
}
