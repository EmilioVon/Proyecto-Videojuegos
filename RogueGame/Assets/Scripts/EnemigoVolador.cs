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

    Animator anim;
    Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("PLayer");
        initialPosition = transform.position;

        anim = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 target = initialPosition;

        RaycastHit2D hit = Physics2D.Raycast(
            transform.position, player.transform.position - transform.position, radioVision,
            1 << LayerMask.NameToLayer("Default")
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

       
    }
}
