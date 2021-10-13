using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinLose : MonoBehaviour
{
    private int unitCount;
    private int unitsSpawned;
    private int enemysCount;
    private int enemysSpawned;
    void Start()
    {
        unitCount = unitsSpawned;
        enemysCount = enemysSpawned;
    }

    // checks if all units or ememys are dead then calls win or lose
    void Update()
    {
        if (unitCount <= 0)
        {
            lose();
        }

        if (enemysCount <= 0)
        {
            win();
        }
        
    }

    void win()
    {
        
    }

    void lose()
    {
        
    }
}
