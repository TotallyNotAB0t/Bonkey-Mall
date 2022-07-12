using Cinemachine;
using UnityEngine;

//Author : Pierre
public class NewFOV : MonoBehaviour
{
    [SerializeField] private SpriteRenderer moleP1;
    [SerializeField] private SpriteRenderer moleP2;
    [SerializeField] private CinemachineFreeLook cam1POV;
    [SerializeField] private CinemachineFreeLook cam1;
    [SerializeField] private CinemachineFreeLook cam1Wide;
    
    [SerializeField] private CinemachineFreeLook cam2POV;
    [SerializeField] private CinemachineFreeLook cam2;
    [SerializeField] private CinemachineFreeLook cam2Wide;

    private void ChangeCam(bool player1, int cam)
    {
        if (player1)
        {
            cam1POV.gameObject.SetActive(cam == 0);
            moleP1.enabled = cam != 0;
            cam1.gameObject.SetActive(cam == 1);
            cam1Wide.gameObject.SetActive(cam == 2);
        }
        else
        {
            cam2POV.gameObject.SetActive(cam == 3);
            moleP2.enabled = cam != 3;
            cam2.gameObject.SetActive(cam == 4);
            cam2Wide.gameObject.SetActive(cam == 5);
        }
    }
    
    private void Update()
    {
        //P1 Cameras
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            ChangeCam(true,0);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            ChangeCam(true,1);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            ChangeCam(true,2);
        }
        
        //P2 cameras
        if (Input.GetKeyDown(KeyCode.Delete))
        {
            ChangeCam(false,3);
        }
        else if (Input.GetKeyDown(KeyCode.End))
        {
            ChangeCam(false,4);
        }
        else if (Input.GetKeyDown(KeyCode.PageDown))
        {
            ChangeCam(false,5);
        }
    }
}
