using UnityEngine;
using System.Collections;

public class Raycast : MonoBehaviour {

    public static Raycast instance;

    public float speed;
    public float lenght;

    public GameObject bullet;
    public GameObject rpg7;
    public GameObject raygun;
    public Transform pos;

    //bool isShooting = false;
    bool isMoving = true;

    public float rpg7_bullet;
    public float gun_bullet;
    public float raygun_bullet;

    private bool Gun_Bullet = true;
    private bool Rpg7_Bullet = true; 
    private bool Raygun_Bullet = true;

    void Awake()
    {
        if (instance == null)
            instance = this;
    }

    void Update()
    {
        if (isMoving)
        {
                transform.RotateAround(transform.position, Vector3.up, speed * Input.GetAxisRaw("Horizontal"));
                transform.RotateAround(transform.position, Vector3.left, speed/2 * Input.GetAxisRaw("Vertical"));
        }

        StartShooting();

        //RayCast();
    }

    //void RayCast()
    //{
    //    Vector3 fwd = transform.TransformDirection(Vector3.forward);
    //    RaycastHit hit;
    //    if (Physics.Raycast(transform.position, fwd, out hit, lenght))
    //    {
    //        if (hit.transform.tag == "enemy")
    //        {
    //            isMoving = false;
    //            if (isShooting == false)
    //            {
    //                StartCoroutine(StartShooting());
    //            }
    //        }
    //    }
    //    else
    //    {
    //        isMoving = true;
    //        isShooting = false;
    //        //StopCoroutine(StartShooting());
    //        StopAllCoroutines();
    //    }
    //    Debug.DrawRay(transform.position, fwd, Color.red);
    //}

    void StartShooting()
    {
        //isShooting = true;
        //while (true)
        //{
            if (Input.GetKey(KeyCode.Z))
            {
                if(Gun_Bullet)
                {
                    Instantiate(bullet, pos.position, transform.rotation);
                }
                gun_bullet--;
                if (gun_bullet <= 0)
                {
                    Gun_Bullet = false;
                }

            }

            if(Input.GetKeyDown(KeyCode.X))
            {
                if (Rpg7_Bullet)
                {
                    Instantiate(rpg7, pos.position, transform.rotation);
                }

                rpg7_bullet--;
                if (rpg7_bullet <= 0)
                {
                    Rpg7_Bullet = false;
                }
                
            }

            if (Input.GetKeyDown(KeyCode.V))
            {
                if (Raygun_Bullet)
                {
                    Instantiate(raygun, pos.position, transform.rotation);
                }

                raygun_bullet--;
                if (raygun_bullet <= 0)
                {
                    Raygun_Bullet = false;
                }

            }
        //}
    }

    public bool emptyAmo()
    {
        if (Raycast.instance.gun_bullet <= 0 && Raycast.instance.rpg7_bullet <= 0 && Raycast.instance.raygun_bullet <= 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
