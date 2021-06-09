﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerHealth : MonoBehaviour
{

    public int maxHealth = 4;
    public int currentHealth;
    public HealthBar healthBar;
    public AudioClip PlayerHurt;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;

        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if(currentHealth == 0)
        {

            SceneManager.LoadScene("DeathScene", LoadSceneMode.Single);
            Destroy(this);
            Destroy(GameObject.Find("Player"));
            Destroy(GameObject.Find("BackgroundAudio"));
            Destroy(GameObject.Find("Game Camera"));
        }
        
    }


    void TakeDamage(int damage)
    {
        AudioSource.PlayClipAtPoint(PlayerHurt, transform.position);
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);
    }

    void getHealth(int damage)
    {
        currentHealth += damage;

        healthBar.SetHealth(currentHealth);
    }


    private void OnCollisionEnter2D(Collision2D other1)
    {
        if (other1.collider.tag == "Enemy")
        {
            Debug.Log("has collided with gobling");
            TakeDamage(1);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Trap"))
        {
            Debug.Log("has collided with trap");
            TakeDamage(1);
        }

        if (collision.gameObject.CompareTag("HealthPotion"))
        {
            Debug.Log("has taken healthPotion");
            getHealth(1);
        }

        if (collision.gameObject.CompareTag("Bullet"))
        {
            Debug.Log("has collided with trap");
            TakeDamage(1);
        }

    }

}