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
        target = GameObject.Find("Player");
        Debug.Log(throwerScript.FrameCounter);
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
        // if (gameObject.GetComponent<"ThrowerScript">().FrameCounter < 200) 
        // {
        //     transform.position += new Vector3(moveHorizontal * MovementSpeed, moveVertical * MovementSpeed, 0f);
        // } 
        // else if (gameObject.GetComponent<"ThrowerScript">().FrameCounter >= 200 && gameObject.GetComponent<"ThrowerScript">().FrameCounter < 260)
        // {
        //     animator.SetBool("shooting", true);
        // }
        // else if (gameObject.GetComponent<"ThrowerScript">().FrameCounter >= 260)
        // {
        //     animator.SetBool("shooting", false);
        // }
    }
}
