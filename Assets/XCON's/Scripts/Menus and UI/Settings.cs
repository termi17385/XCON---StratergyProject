using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Slider = UnityEngine.UI.Slider;

public class Settings : MonoBehaviour
{
    public AudioMixer Master;
    private Resolution[] reso;
    public int currentResoIndex;
    public Dropdown resoDropdown;
    public Dropdown qualityDropdown;
    public Slider VolumeSlider;
    public GameObject menu;
    public GameObject Settingspanel;
    
    public Resolution resolution;
    
    public int frameindex;
    public Dropdown FrameDropdown;
    
    
    public int resosaved = 0;
    public int qulitysaved = 0;
    public int Framesaved = 0;
 

    /// <summary>
    /// all set up functions for each changable setting
    /// </summary>
    private void Start()
    {
        // using ints as bools to check if has previous saves
        resosaved = PlayerPrefs.GetInt("ResoHasSave");
        qulitysaved = PlayerPrefs.GetInt("QualityHasSave");
        Framesaved = PlayerPrefs.GetInt("FramesHasSaved");
        // makes array of possible resolutions
       reso = Screen.resolutions;
        // clears resolutions drop down
       resoDropdown.ClearOptions();

       List<string> options = new List<string>();
        
       // loops through possible resolutions adding to options list
       
       for (int i = 0; i < reso.Length; i++)
       {
           string option = reso[i].width + "x" + reso[i].height;
           options.Add(option);

           if (reso[i].width == Screen.currentResolution.width && reso[i].height == Screen.currentResolution.height)
           {
               currentResoIndex = i;
           }
       }
       // adds options to drop down checks if has save if doesn't sets to native resolution
       resoDropdown.AddOptions(options);
       if (Framesaved != 0)
       {
           frameindex = PlayerPrefs.GetInt("FrameSave");
       }
       else
       {
           frameindex = 2;
       }

       FrameDropdown.value = frameindex;
     
       if (resosaved == 0)
       {
           resoDropdown.value = currentResoIndex;
           SetReso(currentResoIndex);
           
       }
       else
       {
           currentResoIndex = PlayerPrefs.GetInt("ResoSave");
           resoDropdown.value = currentResoIndex;
           SetReso(currentResoIndex);
           
       }
       resoDropdown.RefreshShownValue();
       FrameDropdown.RefreshShownValue();
       

        if (qulitysaved != 0)
        {
            int QualityIndex = PlayerPrefs.GetInt("QualitySave");
            qualityDropdown.value = QualityIndex;
            SetQuality(QualityIndex);
        }
        
       float volume = PlayerPrefs.GetFloat("SavedVolume");
       SetVolume(volume);
       VolumeSlider.value = volume;
       
       
    }
/// <summary>
/// sets resolution
/// </summary>
/// <param name="resolutionIndex"></param>
    public void SetReso(int resolutionIndex)
    {
        currentResoIndex = resolutionIndex;
        resolution = reso[currentResoIndex];
        Screen.SetResolution(resolution.width,resolution.height, Screen.fullScreen);
        PlayerPrefs.SetInt("ResoSave" , currentResoIndex);
        resosaved = 1;
        PlayerPrefs.SetInt("ResoHasSave", resosaved);
        
        framelimiting(frameindex);
    }
/// <summary>
/// sets voulume
/// </summary>
/// <param name="volume"></param>
    public void SetVolume(float volume)
    {
        Master.SetFloat("Master", volume);
        PlayerPrefs.SetFloat("SavedVolume" , volume);
    }
/// <summary>
/// sets quality
/// </summary>
/// <param name="qualityIndex"></param>
    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel((qualityIndex));
        PlayerPrefs.SetInt("QualitySave" , qualityIndex);
        qulitysaved = 1;
        PlayerPrefs.SetInt("QualityHasSave" , qulitysaved);

    }
/// <summary>
/// toggles fullscreen
/// </summary>
/// <param name="isFullscreen"></param>
    public void SetFullscreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }
/// <summary>
/// loads main menu
/// </summary>
    public void backToMenu()
    {
        menu.SetActive(true);
        Settingspanel.SetActive(false);
    }
/// <summary>
/// limits framerate
/// </summary>
public void framelimiting(int Frameindex)
{
    frameindex = Frameindex;
    if (frameindex == 0)
    {
        Screen.SetResolution(resolution.width, resolution.width, Screen.fullScreen, 30);
    }
    if (frameindex == 1)
    {
        Screen.SetResolution(resolution.width, resolution.width, Screen.fullScreen, 60);
    }
    if (frameindex == 2)
    {
        Screen.SetResolution(resolution.width, resolution.width, Screen.fullScreen, 90);
    }
    if (frameindex == 3)
    {
        Screen.SetResolution(resolution.width, resolution.width, Screen.fullScreen, 120);
    }
    if (frameindex == 4)
    {
        Screen.SetResolution(resolution.width, resolution.width, Screen.fullScreen, 144);
    }
    PlayerPrefs.SetInt("FrameSave", frameindex);
    Framesaved = 1;
    PlayerPrefs.SetInt("FramesHasSaved", Framesaved);
    

}
}
