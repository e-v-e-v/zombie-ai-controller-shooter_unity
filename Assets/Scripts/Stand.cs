using UnityEngine;
using System.Collections;

public class Stand : MonoBehaviour {

	void Start () {
        GetComponent<MeshRenderer>().material.color = Color.black;
	}
}
