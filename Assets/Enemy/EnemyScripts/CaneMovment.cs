using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CaneMovment : MonoBehaviour
{
    // private Animator animator;
    public float MovementSpeed;


    private GameObject target;
    private float moveHorizontal, moveVertical;
    void Start()
    {
        // animator = GetComponent<Animator>();
        target = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > target.transform.position.x + 1.0f)
        {
            moveHorizontal = -1;
            transform.localScale = new Vector3(-0.75f, 0.75f, 1f);
        }
        if (transform.position.x < target.transform.position.x - 1.0f)
        {
            moveHorizontal = 1;
            transform.localScale = new Vector3(0.75f, 0.75f, 1f);
        }
        if (transform.position.y > target.transform.position.y + 1.0f)
        {
            moveVertical = -1;
        }
        if (transform.position.y < target.transform.position.y - 1.0f)
        {
            moveVertical = 1;
        }        

        transform.rotation = Quaternion.identity;
    }

    void FixedUpdate()
    {
        transform.position += new Vector3(moveHorizontal * MovementSpeed, moveVertical * MovementSpeed, 0f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player") 
        {
            Destroy(gameObject);
        }
    }
}
