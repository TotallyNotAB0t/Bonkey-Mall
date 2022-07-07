using System;
using System.Collections;
using UnityEngine;
using UnityEngine.AI;
using Random = UnityEngine.Random;

public class PowerManager : MonoBehaviour
{
    [SerializeField] private Material PUBlockO;
    [SerializeField] private Material PUBlockU;
    [SerializeField] private Material PUSpeedD;
    [SerializeField] private Material PUSpeedU;
    
    private enum PowerState
    {
        BlOCKOTHER,
        BLOCKYOU,
        SPEEDUP,
        SPEEDDOWN
    }

    private PowerState state;

    private void Start()
    {
        InvokeRepeating(nameof(SwitchState), 0, 3);
    }

    private void SwitchState()
    {
        state = (PowerState)Random.Range(0, 4);
        GetComponent<MeshRenderer>().material = state switch
        {
            PowerState.BlOCKOTHER => PUBlockO,
            PowerState.BLOCKYOU => PUBlockU,
            PowerState.SPEEDUP => PUSpeedU,
            PowerState.SPEEDDOWN => PUSpeedD,
            _ => GetComponent<MeshRenderer>().material
        };
    }

    private IEnumerator OnTriggerEnter(Collider other)
    {
        StartCoroutine(StartPower(other));
        
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<BoxCollider>().enabled = false;
        
        yield return new WaitForSeconds(2);
        
        GetComponent<MeshRenderer>().enabled = true;
        GetComponent<BoxCollider>().enabled = true;
    }

    private IEnumerator StartPower(Collider other)
    {
        if (other.CompareTag("Player") || other.CompareTag("Player2"))
        {
            var rig = other.GetComponent<Rigidbody>();
            var massorigin = rig.mass;
            rig.mass = state switch
            {
                PowerState.BLOCKYOU => 1000f,
                PowerState.SPEEDUP => 0.5f,
                PowerState.SPEEDDOWN => 3f,
                _ => rig.mass
            };
            yield return new WaitForSeconds(3);
            rig.mass = massorigin;
        }
        else
        {
            var ag = other.GetComponent<NavMeshAgent>();
            var speedorigin = ag.speed;
            ag.speed = state switch
            {
                PowerState.BLOCKYOU => 0,
                PowerState.SPEEDUP => speedorigin * 2,
                PowerState.SPEEDDOWN => speedorigin / 2,
                _ => ag.speed
            };
            ag.speed = 0;
            yield return new WaitForSeconds(3);
            ag.speed = speedorigin;
        }
    }
}
