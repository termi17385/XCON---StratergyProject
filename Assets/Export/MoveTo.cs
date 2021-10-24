using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveTo : MonoBehaviour
{
    public Vector3 movePos;
    public Move moveScript; 

    private void OnMouseOver()
    {
        moveScript.mouseOver = true;
        if(Input.GetMouseButtonDown(1) && moveScript.currentMoveUnits <= moveScript.timeUnits)
        {
            moveScript.timeUnits -= moveScript.currentMoveUnits;
            moveScript.agent.SetDestination(movePos);
        }
    }

    private void OnMouseExit() => moveScript.mouseOver = false;
}
