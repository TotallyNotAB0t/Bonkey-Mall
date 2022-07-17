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

    public void ChangeAngleCams()
    {
        cam1POV.m_XAxis.Value = -25;
        cam1.m_XAxis.Value = -25;
        cam1Wide.m_XAxis.Value = -25;
        
        cam2.m_XAxis.Value = 155;
        cam2.m_XAxis.Value = 155;
        cam2Wide.m_XAxis.Value = 155;
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
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            ChangeCam(false,3);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            ChangeCam(false,4);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            ChangeCam(false,5);
        }
    }
}
