using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoVolador : MonoBehaviour
{
    public float radioVision;
    public float ataqueVision;
    public float speed;

    GameObject player;
    Vector3 initialPosition;
 
    Rigidbody2D rb2d;
    Animator anim;
 
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");

        initialPosition = transform.position;
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 target = initialPosition;

        RaycastHit2D hit = Physics2D.Raycast(
            transform.position, player.transform.position - transform.position, radioVision, 1 << LayerMask.NameToLayer("Default")
            );

        Vector3 forward = transform.TransformDirection(player.transform.position - transform.position);
        Debug.DrawRay(transform.position, forward, Color.red);

        if (hit.collider != null)
        {
            if (hit.collider.tag == "Player")
            {
                target = player.transform.position;
            }
        }

        float distance = Vector3.Distance(target, transform.position);
        Vector3 dir = (target - transform.position).normalized;

        if (target != initialPosition && distance < ataqueVision)
        {
            anim.SetFloat("movX", dir.x);
            anim.SetFloat("movY", dir.y);
        }

        else
        {
            rb2d.MovePosition(transform.position + dir * speed * Time.deltaTime);
            anim.speed = 1;
            anim.SetFloat("movX", dir.x);
            anim.SetFloat("movY", dir.y);
        }

        if(target == initialPosition && distance < 0.02f)
        {
            transform.position = initialPosition;
        }

        Debug.DrawLine(transform.position, target, Color.green);
    }

    
}
