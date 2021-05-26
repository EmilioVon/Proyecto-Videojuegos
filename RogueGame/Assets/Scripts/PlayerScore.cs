using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class PlayerScore : MonoBehaviour
{
    public AudioClip ArcadeCoin;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "ScoreItem")
        {
            ScoreManager.instance.AddMoneyPoint();
            Destroy(collision.gameObject);
            AudioSource.PlayClipAtPoint(ArcadeCoin, transform.position);
        }
    }
}
