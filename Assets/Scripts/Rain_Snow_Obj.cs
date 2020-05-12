using UnityEngine;
using System.Collections;

public class Rain_Snow_Obj : MonoBehaviour {

    public float Speed;

	void Update () {
        transform.Translate(Vector3.down * 5 * Time.deltaTime);
	}
}
