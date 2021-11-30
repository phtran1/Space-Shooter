using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnRate = 1.5f;

    private float lastSpawnTime;

    // Update is called once per frame
    void Update()
    {
        if (Time.time - lastSpawnTime > spawnRate){
            float x = Random.Range(-5, 5);
            GameObject enemy = Instantiate(enemyPrefab, transform.position + Vector3.right * x, Quaternion.identity);
            enemy.GetComponent<Rigidbody2D>().velocity = Vector3.down * 3;
            lastSpawnTime = Time.time;
        }
    }
}
