﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class chasing : MonoBehaviour
{
    private NavMeshAgent agent;
    public Transform target;
    public float range;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(target.transform.position, transform.position) < range)
        {
            agent.SetDestination(target.position);
        }
    }
}
