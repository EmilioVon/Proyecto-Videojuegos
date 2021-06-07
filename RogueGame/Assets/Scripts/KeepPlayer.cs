using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KeepPlayer : MonoBehaviour
{
    public GameObject player;

    private void Awake()
    {
        DontDestroyOnLoad(player);

    }
}
