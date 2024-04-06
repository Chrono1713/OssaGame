using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStartTeleport : MonoBehaviour
{
    private GameObject target;

    void Start()
    {
        target = GameObject.Find("Player");
        var int1 = Random.Range(-10, 10);
        var int2 = Random.Range(-10, 10);
        transform.position = new Vector3(target.transform.position.x + int1, target.transform.position.y + int2, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
