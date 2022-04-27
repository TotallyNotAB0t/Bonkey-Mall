using UnityEngine;

public class PauseMenuScript : MonoBehaviour
{
    [SerializeField] private GameObject pauseMenu;

    private void Pause()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pauseMenu.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    public void ResumeGame()
    {
        Time.timeScale = 1f;
        pauseMenu.SetActive(false);
    }

    public void GoToMenu()
    {
        Time.timeScale = 1f;
        SceneController.GoToScene("MainMenu");
    }
    
    public void QuitGame()
    {
        Application.Quit();
    }

    private void Update()
    {
        Pause();
    }
}
