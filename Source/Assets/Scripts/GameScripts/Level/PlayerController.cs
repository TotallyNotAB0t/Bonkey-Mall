using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Range(1.0f, 20f)] [SerializeField] private float moveSpeed;
    [SerializeField] private Rigidbody rig;
    [SerializeField] private Transform camPlayer;
    private Vector3 force;
    private Vector3 actualDirection;

    private void PlayerMovement()
    {
        rig.AddForce(actualDirection * moveSpeed);
    }

    private void GetPlayerInput()
    {
        //Follows the axis of the camera rather than the default ones
        Vector3 controlDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        actualDirection = Vector3.ProjectOnPlane(camPlayer.TransformDirection(controlDirection), 
            Vector3.up);
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
