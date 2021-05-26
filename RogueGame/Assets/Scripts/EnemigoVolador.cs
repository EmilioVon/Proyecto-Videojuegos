using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoVolador : MonoBehaviour
{
    public float radioVision;
    public float ataqueVision;
    public float speed;

    [SerializeField]
    Transform CastPoint;

    [SerializeField]
    Transform player;
 
    Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();    
    }

    // Update is called once per frame
    void Update()
    {
        float distPlayer = Vector2.Distance(transform.position, player.position);

        if (CanSeePlayer(radioVision))
        {
            ChasePlayer();
        }
        else
        {
            StopChasingPlayer();
        }
       
    }

    bool CanSeePlayer(float distance)
    {
        bool val = false;
        float castDist = distance;

        Vector2 endPos = CastPoint.position + Vector3.right * distance;
        RaycastHit2D hit = Physics2D.Linecast(CastPoint.position, endPos, 1 << LayerMask.NameToLayer("Default"));

        if(hit.collider != null)
        {
            if (hit.collider.gameObject.CompareTag("Player"))
            {
                val = true;
            }
            else
            {
                val = false;
            }

        }
        return val;
    }

    void ChasePlayer()
    {
        if(transform.position.x < player.position.x)
        {
            rb2d.velocity = new Vector2(speed, 0);
            transform.localScale = new Vector2(1, 1);
        }
        else
        {
            rb2d.velocity = new Vector2(-speed, 0);
            transform.localScale = new Vector2(-1, 1);
        }
    }

    void StopChasingPlayer()
    {
        rb2d.velocity = new Vector2(0, 0);

    }
}
