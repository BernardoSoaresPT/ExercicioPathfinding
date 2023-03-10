using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    private Camera cam;
    [SerializeField] NavMeshAgent agent;
    private void Start()
    {
        cam = Camera.main;
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;
            if (Physics.Raycast(ray,out hit))
            {
                agent.SetDestination(hit.point);
            } 
        }
        if (agent.isOnOffMeshLink)
        {
            agent.CompleteOffMeshLink();
        }
    }
}
