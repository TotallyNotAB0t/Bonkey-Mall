using TMPro;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    [Range(1.0f, 20f)] [SerializeField] private float moveSpeed;
    [SerializeField] private Rigidbody rig;
    [SerializeField] private TextMeshProUGUI velValue;
    private Vector3 force;

    private void PlayerMovement()
    {
        rig.AddForce(force * moveSpeed);
    }

    private void GetPlayerInput()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        force = new Vector3(horizontal, 0, vertical);
    }

    //Getting user input
    private void Update()
    {
        GetPlayerInput();
    }

    //Applying user input
    private void FixedUpdate()
    {
        velValue.text = $"{rig.velocity.magnitude}";
        PlayerMovement();
    }
}
