using UnityEngine;

public class MainMenuScript : BasicMenu
{
    [SerializeField] private GameObject[] panels;
    private int panelIndex = 0;

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
            SceneController.GoToScene("lvl1");
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
