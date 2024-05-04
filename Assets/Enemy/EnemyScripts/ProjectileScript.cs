using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileScript : MonoBehaviour
{
    public float ProjectileSpeed;

    private GameObject target;

    private float targetx;
    private float targety;
    private float dx;
    private float dy;
    private Vector3 nemico;


    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("Player");
        targetx = target.transform.position.x;
        targety = target.transform.position.y;
        dx = gameObject.transform.position.x - targetx;
        dy = gameObject.transform.position.y - targety;
        nemico = new Vector3(targetx - 5*dx, targety - 5*dy, 1f);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = Vector3.MoveTowards(transform.position, nemico, ProjectileSpeed/10f);
        if (transform.position.x == nemico.x && transform.position.y == nemico.y) {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player") 
        {
            Destroy(gameObject);
        }
    }


}


