using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

    public int maxHealth = 4;
    public int currentHealth;
    public HealthBar healthBar;

    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
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
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("touched enemy");
    }
}