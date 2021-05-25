using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    public float vel;
    private float waitTime;
    public float startWaitTime;
    public int health;
    public AudioClip BloodSplash;
    public GameObject deathparticle;

    public Transform[] Waypoints;
    private int lugarRand;
   


    // Start is called before the first frame update
    void Start()
    {
        waitTime = startWaitTime;
        lugarRand = Random.Range(0, Waypoints.Length);
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, Waypoints[lugarRand].position, vel * Time.deltaTime);
   
            if(Vector2.Distance(transform.position, Waypoints[lugarRand].position) < 0.2f)
            {
                if(waitTime <= 0)
                {
                    lugarRand = Random.Range(0, Waypoints.Length);
                    waitTime = startWaitTime;
                } else
                {
                    waitTime -= Time.deltaTime;
                }
            }
            if(health <= 0)
        {
        	Instantiate(deathparticle, transform.position, transform.rotation);
            Destroy(gameObject);
            AudioSource.PlayClipAtPoint(BloodSplash, transform.position);
        

        }
     }
    public void TakeDamage(int damage) {
        health -= damage;
        Debug.Log("Lastimaste al enemigo");
    }
        
}
