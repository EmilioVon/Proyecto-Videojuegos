using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    public string sceneToLoad;

    public int levelGenerate;

    public class Global
    {
        public static int contador = 0;
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player") && !other.isTrigger)
        {
            levelGenerate = Random.Range(3, 11);

            if (Global.contador % 6 == 0 && Global.contador != 0)
            {
                Global.contador++;
                SceneManager.LoadScene(11);

                Debug.Log(Global.contador);
            }
            else
            {
                Global.contador++;
                SceneManager.LoadScene(levelGenerate);

                Debug.Log(Global.contador);
            }
        }
    }

    
}
