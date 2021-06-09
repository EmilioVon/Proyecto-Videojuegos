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
            healthleft = GameObject.Find("BigRedBoss").GetComponent<EnemyDamage>();
        }

    }
    void Update()
    {
    
        Scene currentScene = SceneManager.GetActiveScene();
        if (currentScene.name == "Boss1")
        {
            musicSource.Pause();
            
        }

        if (currentScene.name != "Boss1" && !musicSource.isPlaying)
        {
            musicSource.Play();
        }

    }
 
}
