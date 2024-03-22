using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{

    public float MovementSpeed;
    
    private float moveHorizontal, moveVertical;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveHorizontal = Input.GetAxisRaw("Horizontal");
        moveVertical = Input.GetAxisRaw("Vertical");        
    }

    void FixedUpdate() 
    {

        //movement

        if (moveHorizontal > 0.1f)
        {
            transform.position += new Vector3(MovementSpeed, 0f, 0f);
        }
        if (moveHorizontal < -0.1f)
        {
            transform.position += new Vector3(-MovementSpeed, 0f, 0f);
        }        
        if (moveVertical > 0.1f)
        {
            transform.position += new Vector3(0f, MovementSpeed, 0f);
        }
        if (moveVertical < -0.1f)
        {
            transform.position += new Vector3(0f, -MovementSpeed, 0f);
        }    
    }


}
