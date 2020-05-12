using UnityEngine;
using System.Collections;

public class EnemyGenerator_1 : MonoBehaviour {

    public GameObject zombie;
    public Transform pos;
    private float rate;
	
	void Start () {
        StartCoroutine(CreatEnemy());
	}

    void Update()
    {
        if (Raycast.instance.emptyAmo())
        {
            StopCoroutine(CreatEnemy());
        }
    }

    IEnumerator CreatEnemy()
    {
        while(true)
        {
            yield return new WaitForSeconds(rate);
            rate = Random.Range(0.7f, 3f);
            Instantiate(zombie, pos.position, Quaternion.identity);
        }
    }
}
