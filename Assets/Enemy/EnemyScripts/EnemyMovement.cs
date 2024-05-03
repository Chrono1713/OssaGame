using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyScript : MonoBehaviour
{
    private Animator animator;
    public float MovementSpeed;
    private int FrameCounter = 0;

    public ThrowerScript throwerScript;


    private GameObject target;
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
        target = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > target.transform.position.x + 1.0f)
        {
            moveHorizontal = -1;
        }
        if (transform.position.x < target.transform.position.x - 1.0f)
        {
            moveHorizontal = 1;
        }
        if (transform.position.y > target.transform.position.y + 1.0f)
        {
            moveVertical = -1;
        }
        if (transform.position.y < target.transform.position.y - 1.0f)
        {
            moveVertical = 1;
        }        
    }

    void FixedUpdate()
    {
        if (throwerScript.FrameCounter < 200) 
        {
            transform.position += new Vector3(moveHorizontal * MovementSpeed, moveVertical * MovementSpeed, 0f);
        } 
        else if (throwerScript.FrameCounter >= 200 && throwerScript.FrameCounter < 245)
        {
            animator.SetBool("shooting", true);
        }
        else if (throwerScript.FrameCounter >= 240)
        {
            animator.SetBool("shooting", false);
        }
    }
}
