using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] GameObject enemyPrefab;

    [SerializeField] private float enemyInterval = 3.5f;

    private float timer;

    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnEnemy(enemyInterval, enemyPrefab));
    }

    private IEnumerator spawnEnemy(float interval, GameObject enemy)
    {
        yield return new WaitForSeconds(interval);
        GameObject newEnemy = Instantiate(enemy, new Vector3(Random.Range(-5f, 5), 0, Random.Range(-6f, 6f)), Quaternion.identity);
        StartCoroutine(spawnEnemy(interval, enemy));
    }

    private void Update()
    {
        DecreaseInterval();
    }


    public void DecreaseInterval()
    {
        timer += Time.deltaTime;
        if(timer >= 30f)
        {
            enemyInterval -= 0.3f;
            timer = 0;
        }
    }


}
