using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepUI : MonoBehaviour
{
    public GameObject rootCanvas;

    private void Awake()
    {
        DontDestroyOnLoad(rootCanvas);
        
    }
}
