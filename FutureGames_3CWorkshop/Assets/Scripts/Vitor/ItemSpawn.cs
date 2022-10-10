using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawn : MonoBehaviour
{
    //Script to spawn items on the game every given seconds.

    public static ItemSpawn instance;           // we need to call this an instance and it has to be static (idk why, i just know we need to)
    [SerializeField] GameObject item;           // the item we will spawn

    private float timer;                        // timer
    private float maxTimer = 30f;               // max time (the time we want the item to wait until dropping)
    private bool isItSpawning;                  // checking if it is spawning or not

    private void Awake()                       
    {
        if (instance == null)
        {
            instance = this;                          // this is the instance part which i dont understand properly
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    public static ItemSpawn GetInstance()               // also part of instance
    {
        return instance;
    }

   
    void Update()
    {
        SpawnTimer();                                 // starts the timer method

        if (!isItSpawning)                            // if the timer stops (when it reaches the max timer we set)
        {
            TriggerSpawnTimer();                      // trigger it to start over
        }
    }

    void TriggerSpawnTimer()
    {
        SpawnTimer();                                 // trigger it to start over
    }

    void SpawnTimer()                                // the timer method
    {
        isItSpawning = true;                         // we declare that it is spawning, so it doesnt keep trying to trigger and restarting the timer every time
        timer += Time.deltaTime;                     // timer starts
        if (timer >= maxTimer)                       // if the timer reaches the max time
        {
            Spawn();                                 // starts spawn method
            ResetTimer();                            // starts reset timer method
            isItSpawning = false;                    // declares that it isnt spawning anymore
        }
    }

    void Spawn()                                         // spawn method
    {
        Debug.LogError("Item dropped");                        //debug to tell me if something happened (in case i missed something)
        GameObject newItem = Instantiate(item);                // instance of the item (still dont know much about it)
        item.transform.position = new Vector3(Random.Range(-54, 43), 0, Random.Range(-47, 58));   // the item will be spawned on a random position between the x, y and z of the game
    }                                                                                           // i had to check the position of the floor in game before set this

    void ResetTimer()
    {
        timer = 0f;           //reset the timer
    }


}
