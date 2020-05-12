using UnityEngine;
using System.Collections;

public class Zombie : MonoBehaviour {

    public Transform gun;
    public float speed;
	
	void Update () {
        transform.LookAt(gun);
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
	}
}
