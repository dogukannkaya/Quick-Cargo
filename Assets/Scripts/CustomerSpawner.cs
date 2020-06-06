using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerSpawner : MonoBehaviour
{
    public Vector3 center;
    public Vector3 size;
    public GameObject customerPrefab;
    private float timeBtwSpawn;
    public float startTimeBtwSpawn;
    public float decreaseTime;
    public float minTime = 0.65f;
    public HealthBar healthBar;

    void Update()
    {
        if (timeBtwSpawn <= 0 )
        {
            SpawnSpawner();
            timeBtwSpawn = startTimeBtwSpawn;
            if (startTimeBtwSpawn > minTime)
            {
                startTimeBtwSpawn -= decreaseTime;
            }
        }
        else
        {
            timeBtwSpawn -= Time.deltaTime;
        }
    }

    public void SpawnSpawner()
    {
        Vector3 pos = center + new Vector3(Random.Range(-size.x , size.x), Random.Range(-size.y - 1, size.y - 1), 0);
        if (pos.x > (3) || pos.x < (-3))
        {
            Instantiate(customerPrefab, pos, Quaternion.identity);
        }
        else if (pos.y > (3) || pos.y < (-3))
        {
            Instantiate(customerPrefab, pos, Quaternion.identity);
        }

        if (GameObject.FindGameObjectsWithTag("Customer").Length >= 5)
        {
            healthBar.TakeDamage();
        }
    }
}
