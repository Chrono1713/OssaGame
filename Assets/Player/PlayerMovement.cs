using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerMovement : MonoBehaviour
{

    public float MovementSpeed;
    public int ProjectileDamage;
    public int MerdaDamage;
    private Animator animator;
    
    private float moveHorizontal, moveVertical;

    public int hp;

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


        if (hp <= 0f) 
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "projectile") 
        {
            hp -= ProjectileDamage;
            Debug.Log(hp);
        } else if (collision.gameObject.tag == "merda") {
            hp -= MerdaDamage;
            Debug.Log(hp);
        }
    }

}
