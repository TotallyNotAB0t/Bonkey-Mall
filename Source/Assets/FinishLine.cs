using UnityEngine;

public class FinishLine : MonoBehaviour
{
    public static bool IsFinished;
    
    private void OnTriggerEnter(Collider other)
    {
        IsFinished = true;
    }
}
