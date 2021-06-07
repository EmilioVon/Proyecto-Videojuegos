using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossDamage : MonoBehaviour
{

    public int health;
    public AudioClip BloodSplash;
    public GameObject deathparticle;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            Instantiate(deathparticle, transform.position, transform.rotation);
            Destroy(gameObject);
            AudioSource.PlayClipAtPoint(BloodSplash, transform.position);
            ScoreManager.instance.AddKillPoint();

        }
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        //Debug.Log("Lastimaste al enemigo");
    }
}
