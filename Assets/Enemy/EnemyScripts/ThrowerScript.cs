using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowerScript : MonoBehaviour
{

    public int FrameCounter = 0;

    public int ThrowRate;

    public GameObject Projectile;
    private float x, y, z;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    void FixedUpdate()
    { 
        

        if (FrameCounter > ThrowRate * 50) {
            FrameCounter = 0;
            Throw();
        } else {
            FrameCounter++;
        }
    }

    void Throw()
    {
        Instantiate(Projectile, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z), Quaternion.identity);
    }
}
