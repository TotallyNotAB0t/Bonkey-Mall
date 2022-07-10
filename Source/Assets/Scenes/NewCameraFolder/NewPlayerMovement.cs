using UnityEngine;

public class NewPlayerMovement : MonoBehaviour
{ 
    [Range(1.0f, 20f)] [SerializeField] private float moveSpeed = 10;
    [SerializeField] private Rigidbody rig;
    [SerializeField] private Transform cam;
    private Vector3 actualDirection;
    private Vector3 inputAxis;
    private Vector3 cameraFacing;

    private void PlayerMovement()
    {
        //rig.AddForce(cameraFacing * moveSpeed);
        rig.AddForce(actualDirection * moveSpeed);
    }

    private void GetPlayerInput()
    {
        //Get the forward vector of the Camera, moved left and right
        if (gameObject.CompareTag("Player"))
        {
            inputAxis = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")); 
        }
        else if (gameObject.CompareTag("Player2"))
        {
            inputAxis = new Vector3(Input.GetAxis("HorizontalP2"), 0, Input.GetAxis("VerticalP2")); 
        }
        //Getting straight vector
        //cameraFacing = new Vector3(inputAxis.x, 0, inputAxis.z);

        actualDirection = cam.TransformDirection(inputAxis);
        /*actualDirection = Vector3.ProjectOnPlane(cam.TransformDirection(controlDirection), 
            Vector3.up);*/
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
