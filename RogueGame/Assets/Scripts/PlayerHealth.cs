using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

    public static int maxHealth = 4;
    public static int currentHealth;
    public HealthBar healthBar;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;

        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void TakeDamage(int damage)
    {
        currentHealth -= damage;

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
}