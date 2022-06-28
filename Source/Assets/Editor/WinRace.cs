using UnityEditor;
using UnityEngine;

public class WinRace : MonoBehaviour
{
    [MenuItem("Hack/Win")]
    public static void WinRaceInstantly()
    {
        if (GameObject.FindWithTag("Player") != null)
        {
            GameObject.FindWithTag("Player").transform.position = GameObject.FindWithTag("Goal").transform.position;
        }
    }
}
