using UnityEditor;
using UnityEngine;
using UnityEngine.AI;

//Author : Pierre
public class UnityTools : MonoBehaviour
{
    //The first tool, used to instantly win a race by TPing the player to the end
    [MenuItem("Hack/Win/P1 _u")]
    public static void WinRaceInstantlyP1()
    {
        if (GameObject.FindWithTag("Player") != null)
        {
            GameObject.FindWithTag("Player").transform.position = GameObject.FindWithTag("Goal").transform.position;
        }
    }
    
    [MenuItem("Hack/Win/P2 _i")]
    public static void WinRaceInstantlyP2()
    {
        if (GameObject.FindWithTag("Player2") != null)
        {
            GameObject.FindWithTag("Player2").transform.position = GameObject.FindWithTag("Goal").transform.position;
        }
    }

    //Second tool, to simulate powerups state in game
    [MenuItem("Hack/PowerUP/SpeedUp/P1 #e")]
    public static void SpeedUpP1()
    {
        if (GameObject.FindWithTag("Player") != null)
        {
            GameObject.FindWithTag("Player").GetComponent<Rigidbody>().mass = 0.5f;
        }
    }
    
    [MenuItem("Hack/PowerUP/SpeedUp/P2 #r")]
    public static void SpeedUpP2()
    {
        if (GameObject.FindWithTag("Player2") != null)
        {
            GameObject.FindWithTag("Player2").GetComponent<Rigidbody>().mass = 0.5f;
        }
    }
    
    [MenuItem("Hack/PowerUP/SpeedUp/Bot1 #t")]
    public static void SpeedUpBot1()
    {
        if (GameObject.FindWithTag("Bot1") != null)
        {
            GameObject.FindWithTag("Bot1").GetComponent<NavMeshAgent>().speed = PowerManager.originSpeedBot * 2;
        }
    }
    
    [MenuItem("Hack/PowerUP/SpeedUp/Bot2 #y")]
    public static void SpeedUpBot2()
    {
        if (GameObject.FindWithTag("Bot2") != null)
        {
            GameObject.FindWithTag("Bot2").GetComponent<NavMeshAgent>().speed = PowerManager.originSpeedBot * 2;
        }
    }
    
    [MenuItem("Hack/PowerUP/SpeedDown/P1 ^e")]
    public static void SpeedDownP1()
    {
        if (GameObject.FindWithTag("Player") != null)
        {
            GameObject.FindWithTag("Player").GetComponent<Rigidbody>().mass = 3f;
        }
    }
    
    [MenuItem("Hack/PowerUP/SpeedDown/P2 ^r")]
    public static void SpeedDownP2()
    {
        if (GameObject.FindWithTag("Player2") != null)
        {
            GameObject.FindWithTag("Player2").GetComponent<Rigidbody>().mass = 3f;
        }
    }
    
    [MenuItem("Hack/PowerUP/SpeedDown/Bot1 ^t")]
    public static void SpeedDownBot1()
    {
        if (GameObject.FindWithTag("Bot1") != null)
        {
            GameObject.FindWithTag("Bot1").GetComponent<NavMeshAgent>().speed = PowerManager.originSpeedBot / 2;
        }
    }
    
    [MenuItem("Hack/PowerUP/SpeedDown/Bot2 ^y")]
    public static void SpeedDownBot2()
    {
        if (GameObject.FindWithTag("Bot2") != null)
        {
            GameObject.FindWithTag("Bot2").GetComponent<NavMeshAgent>().speed = PowerManager.originSpeedBot / 2;
        }
    }
    
    [MenuItem("Hack/PowerUP/Block/P1 &e")]
    public static void BlockP1()
    {
        if (GameObject.FindWithTag("Player") != null)
        {
            GameObject.FindWithTag("Player").GetComponent<Rigidbody>().mass = 1000f;
        }
    }
    
    [MenuItem("Hack/PowerUP/Block/P2 &r")]
    public static void BlockP2()
    {
        if (GameObject.FindWithTag("Player2") != null)
        {
            GameObject.FindWithTag("Player2").GetComponent<Rigidbody>().mass = 1000f;
        }
    }
    
    [MenuItem("Hack/PowerUP/Block/Bot1 &t")]
    public static void BlockBot1()
    {
        if (GameObject.FindWithTag("Bot1") != null)
        {
            GameObject.FindWithTag("Bot1").GetComponent<NavMeshAgent>().speed = 0;
        }
    }
    
    [MenuItem("Hack/PowerUP/Block/Bot2 &y")]
    public static void BlockBot2()
    {
        if (GameObject.FindWithTag("Bot2") != null)
        {
            GameObject.FindWithTag("Bot2").GetComponent<NavMeshAgent>().speed = 0;
        }
    }

    [MenuItem("Hack/PowerUP/Reset/P1 _e")]
    public static void ResetP1()
    {
        if (GameObject.FindWithTag("Player") != null)
        {
            GameObject.FindWithTag("Player").GetComponent<Rigidbody>().mass = 1f;
        }
    }
    
    [MenuItem("Hack/PowerUP/Reset/P2 _r")]
    public static void ResetP2()
    {
        if (GameObject.FindWithTag("Player2") != null)
        {
            GameObject.FindWithTag("Player2").GetComponent<Rigidbody>().mass = 1f;
        }
    }
    
    [MenuItem("Hack/PowerUP/Reset/Bot1 _t")]
    public static void ResetBot1()
    {
        if (GameObject.FindWithTag("Bot1") != null)
        {
            GameObject.FindWithTag("Bot1").GetComponent<NavMeshAgent>().speed = PowerManager.originSpeedBot;
        }
    }
    
    [MenuItem("Hack/PowerUP/Reset/Bot2 _y")]
    public static void ResetBot2()
    {
        if (GameObject.FindWithTag("Bot2") != null)
        {
            GameObject.FindWithTag("Bot2").GetComponent<NavMeshAgent>().speed = PowerManager.originSpeedBot;
        }
    }
}
