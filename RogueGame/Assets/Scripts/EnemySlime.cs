using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySlime : MonoBehaviour
{
    // for the patrol
    public Transform[] patrolPoints;
    public float speed;
    private int randomSpot;
    private float waitTime;
    public float startWaitTime;
    


    Transform currentPatrolPoint;
    int currentPatrolIndex;


    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        waitTime = startWaitTime; 
        randomSpot = Random.Range(0, patrolPoints.Length);
        anim = GetComponent<Animator>();
        currentPatrolIndex = 0;
        currentPatrolPoint = patrolPoints[currentPatrolIndex];
    }

    // Update is called once per frame
    void Update()
    {
        // transform.Translate(Vector3.up * Time.deltaTime * speed);

        transform.position = Vector2.MoveTowards(transform.position, patrolPoints[randomSpot].position, speed * Time.deltaTime);

        if (Vector2.Distance(transform.position, patrolPoints[randomSpot].position) < 0.2f)
        {   
            if(waitTime <=0)
            {
                randomSpot = Random.Range(0, patrolPoints.Length);
                waitTime = startWaitTime; 
            }
            else
            {
                waitTime -= Time.deltaTime;
            }                
        }

        /*
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
        */


    }
  
}
