using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LoadOutMenu : MonoBehaviour
{
    [SerializeField] private GameObject LoadOutPanel;
    [SerializeField] private GameObject WeaponsPanel;
    [SerializeField] private GameObject PrepPanel;
    [SerializeField] private GameObject AblityPanel;
    [SerializeField] private GameObject ArmourPanel;
    [SerializeField] private GameObject CustomisePanel;
    
    [SerializeField] private Weapons _weapons;
    
    public TextMeshProUGUI GunNameTXT;
    public TextMeshProUGUI GunAccTXT;
    public TextMeshProUGUI GunDmgTXT;

    private void Start()
    {
        _weapons.GetComponent<Weapons>();
    }

    public void Update()
    {
        GunNameTXT.text = _weapons.weaponName;
        GunAccTXT.text = "Accuracy : " + _weapons.WeaponAcc.ToString();
        GunDmgTXT.text =  "Damage : " +_weapons.WeaponDmg.ToString();
    }


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
