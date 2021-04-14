using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public float speed = 3.0f;
	Rigidbody2D rb;
	Animator anim;
	Vector2 lookDirection = new Vector2(1,0);
	float horizontal;
	float vertical;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        Vector2 move = new Vector2(horizontal, vertical);

        if(!Mathf.Approximately(move.x, 0.0f) || (!Mathf.Approximately(move.y, 0.0f)))
        {
        	lookDirection.Set(move.x, move.y);
        	lookDirection.Normalize();
        }

        anim.SetFloat("Look X", lookDirection.x);
        anim.SetFloat("Look Y", lookDirection.y);
        anim.SetFloat("Speed", move.magnitude);
    }

    private void FixedUpdate()
    {
    	Vector2 position = rb.position;
    	position.x = position.x + speed * horizontal * Time.deltaTime;
    	position.y = position.y + speed * vertical * Time.deltaTime;

    	rb.MovePosition(position);
    }
}
