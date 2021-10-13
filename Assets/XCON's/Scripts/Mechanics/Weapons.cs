using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Weapons : MonoBehaviour
{
    [SerializeField] private int PistolDmg = 2;
    [SerializeField] private int PistolAcc = 40;
    [SerializeField] private int RifleDmg = 5;
    [SerializeField] private int RifleAcc = 60;
    public string weaponName;
    public int WeaponDmg;
    public int WeaponAcc;

    
    

    public void Update()
    {
                
    }

    // equips pistol
    public void EquipPistol()
    {
        weaponName = "Pistol";
        WeaponDmg = PistolDmg;
        WeaponAcc = PistolAcc;
    }
    // equips rifle
    public void EquipRifle()
    {
        weaponName = "Rifle";
        WeaponDmg = RifleDmg;
        WeaponAcc = RifleAcc;
    }
}
