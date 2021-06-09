using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KeepPlayer : MonoBehaviour
{
    public GameObject player;
    public int cont;
   


    private void Awake()
    {
        DontDestroyOnLoad(player);

    }

 
}
