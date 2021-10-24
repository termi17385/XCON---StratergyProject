using System;
using System.Collections;
using System.Collections.Generic;

using TMPro;

using UnityEngine;
using UnityEngine.AI;

public class Move : MonoBehaviour
{
    public int timeUnits;
    [NonSerialized] public int currentMoveUnits;
    
    [SerializeField] private LineRenderer tuLine;
    private GameObject tuIndicator;

    [NonSerialized] public NavMeshAgent agent;
    [NonSerialized] public bool mouseOver = false;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        tuLine = GetComponent<LineRenderer>();
    }
        
    void Update() 
    {
        RaycastHit hit;
            
        if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100))
        {
            var dist = Vector3.Distance(transform.position, hit.point);
            Debug.Log(Mathf.RoundToInt(dist));

            if(Input.GetMouseButtonDown(1) && !mouseOver)
            {
                var pos = transform.position;
                pos.y = 0;
                
                tuLine.SetPosition(0, pos);
                tuLine.SetPosition(1, hit.point);
                
                if(tuIndicator != null) Destroy(tuIndicator);
                var spawnPos = hit.point;
                spawnPos.y += 1;
                var obj = Instantiate(Resources.Load<GameObject>("TUIndicator"), spawnPos, Quaternion.Euler(new Vector3(90, 0, 0)));
                
                currentMoveUnits = Mathf.RoundToInt(dist);
                obj.GetComponentInChildren<TextMeshProUGUI>().text = $"{currentMoveUnits}";
                
                obj.GetComponent<MoveTo>().moveScript = GetComponent<Move>();
                obj.GetComponent<MoveTo>().movePos = hit.point;
                
                tuIndicator = obj;
            }
            
            //if(dist <= timeUnits && Input.GetMouseButtonDown(0))
            //{
                //timeUnits -= Mathf.RoundToInt(dist);
                //agent.destination = hit.point;
            //}
        }
    }

    private const float DISK_THICKNESS = 0.01f;
    private void OnDrawGizmos()
    {
        Matrix4x4 oldMatrix = Gizmos.matrix;
        Gizmos.matrix = Matrix4x4.TRS(transform.position, transform.rotation, new Vector3(1, DISK_THICKNESS, 1));
        
        Gizmos.DrawWireSphere(Vector3.zero, timeUnits);
        Gizmos.matrix = oldMatrix;
    }
}
