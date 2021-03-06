using UnityEngine;

//Author : Pierre
//Class respawning the fallen rigidbody
public class Respawn : MonoBehaviour
{
    [SerializeField] private Transform lastCP;

    //When entering the void, bring back the player to the start
    private void OnCollisionEnter(Collision collision)
    {
        TpObject(collision.gameObject.transform, lastCP);
        ResetSpeed(collision.gameObject.GetComponent<Rigidbody>());
        if (collision.gameObject.CompareTag("Player"))
        {
            GameObject.FindWithTag("Script").GetComponent<NewFOV>().ChangeAngleCams(0, -1);
        }

        if (collision.gameObject.CompareTag("Player2"))
        {
            GameObject.FindWithTag("Script").GetComponent<NewFOV>().ChangeAngleCams(-1, 0);
        }
    }

    private static void TpObject(Transform mole, Transform CP)
    {
        mole.transform.position = CP.transform.position;
    }

    private static void ResetSpeed(Rigidbody rig)
    {
        rig.velocity = Vector3.zero;
    }
}
