using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TopoScript : MonoBehaviour
{
    private Animator animator;
    public float MovementSpeed;
    private float targetx;
    private float targety;
    private int rndx;
    private int rndy;
    private int counter = 0;

    private bool moving = true;

    public ThrowerScript throwerScript;

    private float moveHorizontal, moveVertical;

    // Start is called before the first frame update

    // private static void StrBiome()
    // {
    //     var strB = Random.Range(0, int.MaxValue);
    //     Debug.Log(strB);
    // }
    void Start()
    {
        animator = GetComponent<Animator>();
        rndx = Random.Range(-10, 10);
        rndy = Random.Range(-10, 10);
        targetx = transform.position.x + rndx;
        targety = transform.position.y + rndy;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {   
        if (Mathf.Abs(transform.position.x - targetx) < 1f && Mathf.Abs(transform.position.y - targety) < 1f) {
            counter++;
            moving = false;
            if (counter > 50) {
                counter = 0;
                moving = true;
                rndx = Random.Range(-10, 10);
                rndy = Random.Range(-10, 10);
                targetx = transform.position.x + rndx;
                targety = transform.position.y + rndy;
            } 
        } 
        if (moving) {
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(targetx, targety, 1f), MovementSpeed);
        }
    }

}
