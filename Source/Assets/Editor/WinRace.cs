using UnityEditor;
using UnityEngine;

public class WinRace : MonoBehaviour
{
    [MenuItem("Hack/WinP1")]
    public static void WinRaceInstantlyP1()
    {
        if (GameObject.FindWithTag("Player") != null)
        {
            GameObject.FindWithTag("Player").transform.position = GameObject.FindWithTag("Goal").transform.position;
        }
    }
    
    [MenuItem("Hack/WinP2")]
    public static void WinRaceInstantlyP2()
    {
        if (GameObject.FindWithTag("Player2") != null)
        {
            GameObject.FindWithTag("Player2").transform.position = GameObject.FindWithTag("Goal").transform.position;
        }
    }
}
