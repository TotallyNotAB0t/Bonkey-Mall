using UnityEngine;

public class MainMenuScript : BasicMenu
{
    [SerializeField] private GameObject[] panels;
    private int panelIndex = 0;

    private void Start()
    {
        if (gameObject.scene.name == "MainMenu")
        {
            GameModeManager.ResetGameMode();
            GPManager.ResetGPStats();
        }
    }

    public void SetDifficulty(int enumInt)
    {
        switch ((LevelManager.Difficulty)enumInt)
        {
            case LevelManager.Difficulty.None:
                LevelManager.SetDifficulty(LevelManager.Difficulty.None);
                break;
            case LevelManager.Difficulty.Easy:
                LevelManager.SetDifficulty(LevelManager.Difficulty.Easy);
                break;
            case LevelManager.Difficulty.Medium:
                LevelManager.SetDifficulty(LevelManager.Difficulty.Medium);
                break;
            case LevelManager.Difficulty.Hard:
                LevelManager.SetDifficulty(LevelManager.Difficulty.Hard);
                break;

        }
    }

    //Using the canva component because disabled GameObject are very poorly usable with serialization
    private void NextPanel()
    {
        panels[panelIndex].GetComponent<Canvas>().enabled = false;
        panelIndex++;
        panels[panelIndex].GetComponent<Canvas>().enabled = true;
        /*panels[panelIndex].SetActive(false);
        panelIndex++;
        panels[panelIndex].SetActive(true);*/
    }

    private void BackPanel()
    {
        panels[panelIndex].GetComponent<Canvas>().enabled = false;
        panelIndex--;
        panels[panelIndex].GetComponent<Canvas>().enabled = true;
        /*panels[panelIndex].SetActive(false);
        panelIndex--;
        panels[panelIndex].SetActive(true);*/
    }

    public void Next()
    {
        if (GameModeManager.CurrentLevelGamemode == GameModeManager.GameMode.GrandPrix)
        {
            SceneController.GoToSceneInt(1);
        }
        else
        {
            NextPanel();
        }
    }

    public void Back()
    {
        BackPanel();
    }

    public void StartLevel(string levelName)
    {
        SceneController.GoToScene(levelName);
    }
}
