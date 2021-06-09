using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneCounter : MonoBehaviour
{
    //keeps scenecounter
    public GameObject sceneCounter;
    public int cont;
    private void Awake()
    {
        cont = 0;
        DontDestroyOnLoad(sceneCounter);

    }


}
