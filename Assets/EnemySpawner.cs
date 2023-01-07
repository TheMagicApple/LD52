using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public int spawnRate; //0-99
    public int enemyType;
    private int timer=300;
    public GameObject enemyPrefab;
    private GameObject createdEnemy;
    // Start is called before the first frame update
    void Start()
    {
        spawnRate = (100-spawnRate);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(timer);
        timer--;
        if (timer < 0) {
            createdEnemy = Instantiate(enemyPrefab, new Vector3(Random.Range(0,20), Random.Range(0,20), 0), Quaternion.identity);
            createdEnemy.GetComponent<EnemyMovement>().speed = 0.01f;
            timer = Random.Range(1000,200)*(spawnRate/10);
        }
    }
}
