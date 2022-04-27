using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    private static class CameraState
    {
        public static readonly Vector3 ThirdPerson = new(0, 2, -5);
        public static readonly Vector3 FirstPerson = Vector3.zero;
    }
    
    //Player to follow
    [SerializeField] private Rigidbody rBplayer;
    private Vector3 cameraDistance;

    private Vector3 speedDirection;

    private void Follow()
    {
        transform.position = CameraState.ThirdPerson;
        speedDirection = rBplayer.velocity;
    }

    private void Rotate()
    {
        transform.position = rBplayer.transform.position + cameraDistance;
        transform.rotation = Quaternion.LookRotation(speedDirection, Vector3.up);
    }

    private void RotateAndLeave()
    {
        var position = rBplayer.position;
        
        //Rotate
        transform.RotateAround(position, Vector3.up, 50 * Time.deltaTime);
        transform.LookAt(position);
        
        //Going back
        transform.Translate(Vector3.back * 0.1f);
    }

    private void Update()
    {
        //Camera following the position of the player
        if (!FinishLine.IsFinished)
        {
            Follow();
            Rotate();
        }
        else
        {
            RotateAndLeave();
        }
        
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            cameraDistance = CameraState.FirstPerson;
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            cameraDistance = CameraState.ThirdPerson;
        }
    }
}
