using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NonCustomerSpawner : MonoBehaviour
{
    public Vector3 center;
    public Vector3 size;
    public GameObject noncustomerPrefab;
    private float timeBtwSpawn = 10;
    public float startTimeBtwSpawn;
    public float decreaseTime;
    public float minTime = 1f;

    void Update()
    {
        if (timeBtwSpawn <= 0)
        {
            timeBtwSpawn = startTimeBtwSpawn;
            SpawnNonCustomer();
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

    public void SpawnNonCustomer()
    {
        Vector3 pos = center + new Vector3(Random.Range(-size.x, size.x), Random.Range(-size.y - 1, size.y - 1), 0);
        if (pos.x > (3) || pos.x < (-3))
        {
            Instantiate(noncustomerPrefab, pos, Quaternion.identity);
        }
        else if (pos.y > (3) || pos.y < (-3))
        {
            Instantiate(noncustomerPrefab, pos, Quaternion.identity);
        }
    }

}
