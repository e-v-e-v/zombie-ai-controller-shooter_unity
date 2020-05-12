using UnityEngine;
using System.Collections;

public class rpg7m : MonoBehaviour {

    public float speed;

    void Start()
    {
        Destroy(gameObject, 6);
    }

    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
