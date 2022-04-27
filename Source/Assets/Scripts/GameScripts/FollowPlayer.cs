using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    private static class CameraState
    {
        public static readonly Vector3 ThirdPerson = new(0, 2, -5);
        public static readonly Vector3 FirstPerson = Vector3.zero;
    }
    
    //Player to follow
    [SerializeField] private Transform player;
    private Vector3 cameraDistance;

    private void Follow()
    {
        transform.position = player.transform.position + cameraDistance;
    }

    private void RotateAndLeave()
    {
        var position = player.position;
        
        //Rotate
        transform.RotateAround(position, Vector3.up, 50 * Time.deltaTime);
        transform.LookAt(position);
        
        //Going back
        transform.Translate(Vector3.back * 0.1f);
    }

    private void Start()
    {
        cameraDistance = CameraState.ThirdPerson;
    }

    private void Update() {
        
        //Camera following the position of the player
        if (!FinishLine.IsFinished)
        {
            Follow();
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
