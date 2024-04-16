using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileScript : MonoBehaviour
{
    public float ProjectileSpeed;

    private GameObject target;

    private float dx;
    private float dy;
    private float damuoverex;
    private float damuoverey;


    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("Player");
        dx = target.transform.position.x - gameObject.transform.position.x;
        dy = target.transform.position.y - gameObject.transform.position.y;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // transform.position += new Vector3((float)System.Math.Cos(alfa)*ProjectileSpeed, (float)System.Math.Sin(alfa)*ProjectileSpeed);
        damuoverex = dx*ProjectileSpeed/100f;
        damuoverey = dy*ProjectileSpeed/100f;
        transform.position += new Vector3(damuoverex, damuoverey, 0);
    }
}
