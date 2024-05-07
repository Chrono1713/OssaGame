using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerScript : MonoBehaviour
{
    private int counter = 0;
    private int numberofenemies = 4;
    public float SpawnRate;
    private GameObject target;
    private int FrameCounter = 0;
    public GameObject Thrower;
    public GameObject Topo;
    public GameObject Cane;
    public GameObject Covid;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        // spawning enemy
        if (FrameCounter == SpawnRate * 50) {
            spawn();
            FrameCounter++;
        } else if (FrameCounter > SpawnRate * 50 + 25) {
            FrameCounter = 0;
        } else {
            FrameCounter++;
        }
        
        // keeping position on player (kinda useless)
        transform.position = new Vector3(target.transform.position.x, target.transform.position.y, 2.0f); 
        
    }

    void spawn() 
    {
        if (counter%numberofenemies == 0) {
            Instantiate(Thrower);
            counter++;
        } else if (counter%numberofenemies == 1) {
            Instantiate(Topo);
            counter++;
        } else if (counter%numberofenemies == 2) {
            Instantiate(Cane);
            counter++;
        } else if (counter%numberofenemies == 3) {
            Instantiate(Covid);
            counter++;
        }
    }
}
