using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicaContinua : MonoBehaviour
{
    public AudioSource musicSource;
    public static MusicaContinua instance = null;
    public EnemyDamage healthleft;
    

    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);

       
    }

    private void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        if (currentScene.name == "Boss1")
        {
            healthleft = FindObjectOfType<BigRedBossController>().GetComponent<EnemyDamage>();
        }

    }
    void Update()
    {
    
        Scene currentScene = SceneManager.GetActiveScene();
        if (currentScene.name == "Boss1")
        {
            musicSource.Pause();
            if (healthleft.health <= 0)
            {
                musicSource.Play();
            }
        }


 
    }
 
}
