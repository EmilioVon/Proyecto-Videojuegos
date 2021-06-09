using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UI;
public class DeathMenu : MonoBehaviour
{

   
    private void Start()
    {
      
    }

    

    public void BackToMenu()
    {
        SceneManager.LoadScene("menu");
    }


}
