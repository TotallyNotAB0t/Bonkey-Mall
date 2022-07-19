using System.Collections;
using UnityEngine;
using UnityEngine.AI;
using Random = UnityEngine.Random;

//Class handlind the powerups
public class PowerManager : MonoBehaviour
{
    public static float originSpeedBot;
    private GameObject Bot1;
    [SerializeField] private Material PUBlockU;
    [SerializeField] private Material PUSpeedD;
    [SerializeField] private Material PUSpeedU;
    
    //Enumeration of the actual state of our powerup
    private enum PowerState
    {
        BLOCKYOU,
        SPEEDUP,
        SPEEDDOWN
    }

    private PowerState state;

    //Every 3 seconds, the state of the powerup changes (it can stay the same)
    private void Start()
    {
        InvokeRepeating(nameof(SwitchState), 0, 0.5f);
        Bot1 = GameObject.FindWithTag("Bot1");
        if (Bot1)
        {
            originSpeedBot = Bot1.GetComponent<NavMeshAgent>().speed;
        }
    }
    
    //Rotation of the powerup
    private void Update()
    {
        transform.Rotate(0, 0.5f, 0);
    }

    private void SwitchState()
    {
        state = (PowerState)Random.Range(0, 3);
        GetComponent<MeshRenderer>().material = state switch
        {
            PowerState.BLOCKYOU => PUBlockU,
            PowerState.SPEEDUP => PUSpeedU,
            PowerState.SPEEDDOWN => PUSpeedD,
        };
    }

    //Deactivate the powerup after being picked up by a player or a bot
    private IEnumerator OnTriggerEnter(Collider other)
    {
        StartCoroutine(StartPower(other));
        
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<BoxCollider>().enabled = false;
        
        yield return new WaitForSeconds(2);
        
        GetComponent<MeshRenderer>().enabled = true;
        GetComponent<BoxCollider>().enabled = true;
    }

    //Change the speed or mass of the player / bot 
    private IEnumerator StartPower(Collider other)
    {
        if (other.CompareTag("Player") || other.CompareTag("Player2"))
        {
            var rig = other.GetComponent<Rigidbody>();
            rig.mass = state switch
            {
                PowerState.BLOCKYOU => 1000f,
                PowerState.SPEEDUP => 0.5f,
                PowerState.SPEEDDOWN => 3f
            };
            yield return new WaitForSeconds(3);
            rig.mass = 1;
        }
        else
        {
            var ag = other.GetComponent<NavMeshAgent>();
            ag.speed = state switch
            {
                PowerState.BLOCKYOU => 0,
                PowerState.SPEEDUP => originSpeedBot * 2,
                PowerState.SPEEDDOWN => originSpeedBot / 2
            };
            yield return new WaitForSeconds(3);
            if (ag != null)
            {
                ag.speed = originSpeedBot;
            }
        }
    }
}
