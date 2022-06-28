using UnityEngine;

public class Respawn : MonoBehaviour
{
    [SerializeField] private Transform mole;
    [SerializeField] private Transform lastCP;

    private void OnCollisionEnter(Collision collision)
    {
        TpObject(mole, lastCP);
        ResetSpeed(mole.GetComponent<Rigidbody>());
    }

    private static void TpObject(Transform mole, Transform CP)
    {
        mole.transform.position = CP.transform.position;
    }

    private void ResetSpeed(Rigidbody rig)
    {
        rig.velocity = Vector3.zero;
    }

    private void ChangeCp(Transform newCp)
    {
        lastCP = newCp;
    }
}
