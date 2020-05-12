using UnityEngine;
using System.Collections;

public class Rain_Snow : MonoBehaviour {

    public GameObject obj;
    private float makeItRain;
	
	void Start () 
    {
        makeItRain = Random.Range(0.2f, 1.2f);
        StartCoroutine(rain());
	}

    IEnumerator rain()
    {
        while(true)
        {
            yield return new WaitForSeconds(makeItRain);
            Instantiate(obj, transform.position, Quaternion.identity);
        }
    }
}
