using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject boss;
    private EnemyDamage healthscript;
    public Transform[] spawnPoints;
    public GameObject enemy;

    public float spawnTime;
    public float spawnDelay;



    private void Start()
    {
        healthscript = boss.GetComponent<EnemyDamage>();
     

    }
    private void Update()
    {
        if (!IsInvoking("spawnObject") && healthscript.health == 250)
        {
            InvokeRepeating("spawnObject", spawnTime, spawnDelay);

        }
        if(healthscript.health == 0)
        {
            CancelInvoke("spawnObject");
            
        }
       
    }


    public void spawnObject()
    {
        int randspawnPoint = Random.Range(0, spawnPoints.Length);

        Instantiate(enemy, spawnPoints[randspawnPoint].position, transform.rotation);
       
    }

}
