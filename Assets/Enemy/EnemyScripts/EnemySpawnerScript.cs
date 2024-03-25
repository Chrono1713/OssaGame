using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerScript : MonoBehaviour
{
    public float SpawnRate;

    private int EnemyNumber;
    private GameObject target;
    public GameObject Enemy;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("Player");
        spawn();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        transform.position = new Vector3(target.transform.position.x, target.transform.position.y, 2.0f);    
    }

    void spawn() 
    {
        Instantiate(Enemy);
        // new Vector3(target.transform.position.x, target.transform.position.y, 0f)
    }
}
