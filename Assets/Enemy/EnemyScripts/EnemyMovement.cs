using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyScript : MonoBehaviour
{

    public float MovementSpeed;


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
        transform.position += new Vector3(moveHorizontal * MovementSpeed, moveVertical * MovementSpeed, 0f);
    }
}
