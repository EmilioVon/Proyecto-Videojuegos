using System.Collections;
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

    //audio setting
    public AudioMixer audioMixer;
   public void SetVolume(float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }


    //quality setting
    public void SetQuality (int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }

    //fullscreen setting
    public void SetFullscreen(bool IsFullScreen)
    {
        Screen.fullScreen = IsFullScreen;
    }


    Resolution[] Resolutions;
    public Dropdown resolutionsDropdown;
    private void Start()
    {
       Resolutions=  Screen.resolutions;
        resolutionsDropdown.ClearOptions();

        List<string> options = new List<string>();

        int currentResolutionIndex = 0; 

        for (int i = 0; i < Resolutions.Length; i++)
        {
            string option = Resolutions[i].width + " x " + Resolutions[i].height;
            options.Add(option);

            if (Resolutions[i].width== Screen.currentResolution.width && Resolutions[i].height == Screen.currentResolution.height)
            {
                currentResolutionIndex = i;
            }
        }

        resolutionsDropdown.AddOptions(options);
        resolutionsDropdown.value = currentResolutionIndex;
        resolutionsDropdown.RefreshShownValue();
    }

    public void SetResoluton(int ResolutionIndex)
    {
        Resolution resolution = Resolutions[ResolutionIndex];
        Screen.SetResolution(resolution.width,resolution.height, Screen.fullScreen);
    }
}
