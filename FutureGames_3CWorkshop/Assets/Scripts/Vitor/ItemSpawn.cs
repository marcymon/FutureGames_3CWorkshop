using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawn : MonoBehaviour
{
    public static ItemSpawn instance;
    [SerializeField] GameObject item;

    private float timer;
    private float maxTimer = 30f;
    private bool isItSpawning;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    public static ItemSpawn GetInstance()
    {
        return instance;
    }

   
    void Update()
    {
        SpawnTimer();

        if (!isItSpawning)
        {
            TriggerSpawnTimer();
        }
    }

    void TriggerSpawnTimer()
    {
        SpawnTimer();
    }

    void SpawnTimer()
    {
        isItSpawning = true;
        timer += Time.deltaTime;
        if (timer >= maxTimer)
        {
            Spawn();
            ResetTimer();
            isItSpawning = false;
        }
    }

    void Spawn()
    {
        Debug.LogError("Item dropped");
        GameObject newItem = Instantiate(item);
        item.transform.position = new Vector3(Random.Range(-14, 0), 0, Random.Range(-3, 12));
    }

    void ResetTimer()
    {
        timer = 0f;
    }


}
