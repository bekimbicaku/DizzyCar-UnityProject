using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class waypoint : MonoBehaviour
{
    public NavMeshAgent agent;
    

    public GameObject PATH;
    private Transform[] PathPoints;

    public float minDistance = 10;

    public int index = 0;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        

        PathPoints = new Transform[PATH.transform.childCount];
        for (int i = 0; i < PathPoints.Length; i++)
        {
            PathPoints[i] = PATH.transform.GetChild(i);
        }
    }

    void Update()
    {
        roam();
    }

    void roam()
    {
        if (Vector3.Distance(transform.position, PathPoints[index].position) < minDistance)
        {
            if (index > 0 && index < PathPoints.Length)
            {
                index += 1;
            }
            else
            {
                index = 0;
            }
        }
        agent.SetDestination(PathPoints[index].position);
        
    }
}
