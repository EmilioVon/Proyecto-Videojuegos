using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySlime : MonoBehaviour
{
    public Transform[] patrolPoints;

    public float speed;
    public int health;
    public AudioClip BloodSplash;
    public GameObject deathparticle;

    Transform currentPatrolPoint;
    int currentPatrolIndex;

  
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        currentPatrolIndex = 0;
        currentPatrolPoint = patrolPoints[currentPatrolIndex];
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * speed);

        if(Vector3.Distance (transform.position,currentPatrolPoint.position) < .1f)
        {
            if(currentPatrolIndex + 1 < patrolPoints.Length)
            {
                currentPatrolIndex++;
            } else
            {
                currentPatrolIndex = 0;
            }
            currentPatrolPoint = patrolPoints[currentPatrolIndex];
        }
        if (health <= 0)
        {
            Instantiate(deathparticle, transform.position, transform.rotation);
            Destroy(gameObject);
            AudioSource.PlayClipAtPoint(BloodSplash, transform.position);


        }

    }
    public void TakeDamage(int damage)
    {
        health -= damage;
        //Debug.Log("Lastimaste al enemigo");
    }

}
