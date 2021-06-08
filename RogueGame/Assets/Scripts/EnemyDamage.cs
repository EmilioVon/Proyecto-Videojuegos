using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public int health;
    public int swordDamage; 
    public AudioClip BloodSplash;
    public GameObject deathparticle;
    public SpriteRenderer sprite;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Sword")
        {
            StartCoroutine(FlashRed());
            health -= swordDamage;
        }
    }


    public IEnumerator FlashRed()
    {
        sprite.color = Color.red;
        yield return new WaitForSeconds(0.1f);
        sprite.color = Color.white;
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

    /*
    public void TakeDamage(int damage)
    {
        health -= damage;
        //Debug.Log("Lastimaste al enemigo");
    }
    */
}
