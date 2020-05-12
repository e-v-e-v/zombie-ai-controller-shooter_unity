using UnityEngine;
using System.Collections;

public class Amo_bullet : MonoBehaviour {

	void OnGUI()
    {
        GUI.Label(new Rect(70, (Screen.height) - 27, 100, 50) , Raycast.instance.gun_bullet.ToString());
        GUI.Label(new Rect(190, (Screen.height) - 27, 100, 50), Raycast.instance.rpg7_bullet.ToString());
        GUI.Label(new Rect(336, (Screen.height) - 27, 100, 50), Raycast.instance.raygun_bullet.ToString());

        GUI.Label(new Rect(837, (Screen.height) - 25, 100, 50), ScoreManager.instance.getNow().ToString());
    }
}
