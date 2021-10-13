using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Units : MonoBehaviour
{
    private Weapons _weapons;
    [SerializeField] private int baseHP = 100;
    [SerializeField] private int baseTU = 100;
    public int Strength;
    public int stamina;
    public int HP;
    public int TU;
    public int currentHP;
    public int currentTU;
    [SerializeField] private int hitChance;
   [SerializeField] private float Hitroll;
    [SerializeField] private bool crouching;
   // sets stats on start
    void Start()
    {
        _weapons.GetComponent<Weapons>();
        HP = baseHP + Strength;
        TU = baseHP + stamina;
        currentHP = HP;
        currentTU = TU;
    }

    
    void Update()
    {
        // if hp is 0 kills unit
        if (HP >= 0);
        {
            Dead();
        }
    }
    // allows crouch toggle
    public void Crouch()
    {
        crouching = !crouching;
    }

    // shots and calulates if shot hits or misses
    public void Shot()
    {
        if (crouching)
        {
            hitChance = _weapons.WeaponAcc * 2;
        }
        else
        {
            hitChance = _weapons.WeaponAcc;
        }

        Hitroll = 0 + (Random.Range(-10f, 10f));
        
        if( Hitroll <= hitChance)
        {
            hit();
        }
        else
        {
            miss();
        }
    }
    public void Dead()
    {
        
    }

    public void hit()
    {
        
    }

    public void miss()
    {
        
    }
    
    
}
