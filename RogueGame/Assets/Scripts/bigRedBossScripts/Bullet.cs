using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    float moveSpeed = 5f;

    float rotationPerMinute = 20.0f;

    
    Rigidbody2D rb;

    PlayerMovement target;

    Vector2 moveDirection;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        target = GameObject.FindObjectOfType<PlayerMovement>();
        moveDirection = (target.transform.position - transform.position).normalized * moveSpeed;
        rb.velocity = new Vector2(moveDirection.x, moveDirection.y);
        Destroy(gameObject, 3f);
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
            Debug.Log("hit!");
            Destroy(gameObject);
        }
        
    }

    private void Update()
    {
        transform.Rotate(0, 0, 6.0f * rotationPerMinute * Time.deltaTime, 0);
    }
}
