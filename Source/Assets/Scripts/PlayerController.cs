using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody rig;
    [SerializeField] private Transform dir;

    // Update is called once per frame
    private void FixedUpdate()
    {
        //Code test pas opti
        if (Input.GetKey(KeyCode.Z))
        {
            rig.AddForce(dir.forward * 10f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rig.AddForce(-dir.transform.forward * 10f);
        }

        if (Input.GetKey(KeyCode.Q))
        {
            rig.AddForce(-dir.transform.right * 10f);
        }
        
        if (Input.GetKey(KeyCode.D))
        {
            rig.AddForce(dir.transform.right * 10f);
        }
    }
}
