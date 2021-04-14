using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{

    public void BackToMenu()
    {
        SceneManager.LoadScene("menu");
    }

    // Start is called before the first frame update
   
    public void SetVolume (float volume)
    {

    }



}
