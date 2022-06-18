using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class testIa : MonoBehaviour
{
    public GameObject gol;

    public GameObject bol;
    
    // Start is called before the first frame update
    void Start()
    {
        NavMeshAgent agent = bol.GetComponent<NavMeshAgent>();
        agent.destination = gol.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
