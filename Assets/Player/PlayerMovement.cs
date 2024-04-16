using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{

    public float MovementSpeed;
    private Animator animator;
    
    private float moveHorizontal, moveVertical;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        moveHorizontal = Input.GetAxisRaw("Horizontal");
        moveVertical = Input.GetAxisRaw("Vertical");        
        if (moveVertical != 0f)
        {
            animator.SetFloat("Movement", 1f);
        }
        else if (moveHorizontal != 0f)
        {
            animator.SetFloat("Movement", 1f);
        }
        else 
        {
            animator.SetFloat("Movement", 0f);
        }

        if(moveHorizontal < 0f)
        {
            transform.localScale = new Vector3(-0.5f, 0.5f, 0f);
        }
        if(moveHorizontal > 0f)
        {
            transform.localScale = new Vector3(0.5f, 0.5f, 0f);
        }  
    }

    void FixedUpdate() 
    {

        //movement
        if (moveHorizontal != 0 && moveVertical == 0) 
        {
            if (moveHorizontal > 0.1f)
            {
                transform.position += new Vector3(MovementSpeed, 0f, 0f);
            }
            if (moveHorizontal < -0.1f)
            {
                transform.position += new Vector3(-MovementSpeed, 0f, 0f);
            }   
        }
        else if (moveVertical != 0 && moveHorizontal == 0) 
        {
            if (moveVertical > 0.1f)
            {
                transform.position += new Vector3(0f, MovementSpeed, 0f);
            }
            if (moveVertical < -0.1f)
            {
                transform.position += new Vector3(0f, -MovementSpeed, 0f);
            }    
        }
        else if (moveHorizontal != 0f && moveVertical != 0f) {
            if (moveHorizontal > 0.1f)
            {
                transform.position += new Vector3(MovementSpeed * 0.707f, 0f, 0f);
            }
            if (moveHorizontal < -0.1f)
            {
                transform.position += new Vector3(-MovementSpeed * 0.707f, 0f, 0f);
            }
            if (moveVertical > 0.1f)
            {
                transform.position += new Vector3(0f, MovementSpeed * 0.707f, 0f);
            }
            if (moveVertical < -0.1f)
            {
                transform.position += new Vector3(0f, -MovementSpeed * 0.707f, 0f);
            } 
        }
    }


}
