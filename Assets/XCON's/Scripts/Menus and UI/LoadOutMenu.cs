using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadOutMenu : MonoBehaviour
{
    [SerializeField] private GameObject LoadOutPanel;
    [SerializeField] private GameObject WeaponsPanel;
    [SerializeField] private GameObject PrepPanel;
    [SerializeField] private GameObject AblityPanel;
    [SerializeField] private GameObject ArmourPanel;
    [SerializeField] private GameObject CustomisePanel;
    
    public void SaveLoadout()
    {
        //empty atm not sure what data gonna save yet
    }

    public void BackToPrep()
    {
        LoadOutPanel.SetActive(false);
        PrepPanel.SetActive(true);
    }

    public void OpenLoadout()
    {
        LoadOutPanel.SetActive(true);
        PrepPanel.SetActive(false);
    }
    
    public void BackToLoadOut()
    {
        CustomisePanel.SetActive(true);
        ArmourPanel.SetActive(false);
        AblityPanel.SetActive(false);
        WeaponsPanel.SetActive(false);
    }

    public void OpenWeapons()
    {
        CustomisePanel.SetActive(false);
        WeaponsPanel.SetActive(true);
    }

    public void OpenAbilites()
    {
        CustomisePanel.SetActive(false);
        AblityPanel.SetActive(true);
    }

    public void OpenArmour()
    {
        CustomisePanel.SetActive(false);
        ArmourPanel.SetActive(true);
    }
    
    
    






}
