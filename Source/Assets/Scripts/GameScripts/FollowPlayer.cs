using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    private static class CameraState
    {
        public static readonly Vector3 ThirdPerson = new(0, 2f, -5);
        public static readonly Vector3 FirstPerson = Vector3.zero;
    }
    
    //Player to follow
    [SerializeField] private Rigidbody rBplayer;
    [SerializeField] private Camera cameraPlayer;

    [SerializeField, Range(0, 0.5f)] private float smoothness;
    private Vector3 speedDirection;

    private void Follow()
    {
        transform.position = rBplayer.transform.position;
        speedDirection = rBplayer.velocity;
    }

    private void Rotate()
    {
        if (Vector3.Distance(speedDirection, Vector3.zero) >= 0.01f)
        {
            Vector3 result = Vector3.Lerp(transform.forward, speedDirection.normalized, smoothness);
            if (Vector3.Dot(result, Vector3.up) > 0)
                result = Vector3.ProjectOnPlane(result, Vector3.up);
            
            transform.rotation = Quaternion.LookRotation(result, Vector3.up);
        }
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

    private void Start()
    {
        cameraPlayer.transform.localPosition = CameraState.ThirdPerson;
    }

    private void Update()
    {
        Debug.DrawLine(rBplayer.transform.position, speedDirection, Color.green);
        
        if (!FinishLine.IsFinished)
        {
            Follow();
            Rotate();
        }
        else
        {
            RotateAndLeave();
        }
        
        //Camera Views
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            cameraPlayer.transform.localPosition = CameraState.FirstPerson;
        }
        
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            cameraPlayer.transform.localPosition = CameraState.ThirdPerson;
        }
    }
}
