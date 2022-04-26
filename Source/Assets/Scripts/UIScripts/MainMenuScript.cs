using UnityEngine;

public class MainMenuScript : MonoBehaviour
{
    public void PlayGame()
    {
        SceneController.GoToScene("TestScene");
    }
    
    public void QuitGame()
    {
        Application.Quit();
    }
}
