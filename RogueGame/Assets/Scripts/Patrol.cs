﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class Patrol : MonoBehaviour
{
    public float vel;
    private float waitTime;
    public float startWaitTime;
    public int health;
    public AudioClip BloodSplash;
    public AIPath aiPath;
    

    private int lugarRand;
   


    // Start is called before the first frame update
    void Start()
    {
       
        
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
            AudioSource.PlayClipAtPoint(BloodSplash, transform.position);
        }

        if (aiPath.desiredVelocity.x >= 0.01f)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }
        else if (aiPath.desiredVelocity.x <= 0.01f)
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
    }
    public void TakeDamage(int damage) {
        health -= damage;
        //Debug.Log("Lastimaste al enemigo");
    }
        
}
