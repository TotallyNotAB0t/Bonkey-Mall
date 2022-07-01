using UnityEngine;

public class NewPlayerMovement : MonoBehaviour
{
    [Range(1.0f, 20f)] [SerializeField] private float moveSpeed;
    [SerializeField] private Rigidbody rig;
    [SerializeField] private Transform straightCam;
    private Vector3 force;
    private Vector3 inputAxis;
    private Vector3 cameraFacing;

    private void PlayerMovement()
    {
        rig.AddForce(cameraFacing * moveSpeed);
    }

    private void GetPlayerInput()
    {
        //Get the forward vector of the Camera, moved left and right
        
       inputAxis = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
       cameraFacing = (straightCam.forward * inputAxis.z);
    }

    //Getting user input
    private void Update()
    {
        GetPlayerInput();
    }

    //Applying user input
    private void FixedUpdate()
    {
        PlayerMovement();
    }
}
