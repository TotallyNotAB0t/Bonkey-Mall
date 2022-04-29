using UnityEngine;

public class MainMenuScript : BasicMenu
{
    [SerializeField] private GameObject[] panels;
    private int panelIndex = 0;

    private void NextPanel()
    {
        panels[panelIndex].SetActive(false);
        panelIndex++;
        panels[panelIndex].SetActive(true);
    }

    private void BackPanel()
    {
        panels[panelIndex].SetActive(false);
        panelIndex--;
        panels[panelIndex].SetActive(true);
    }

    public void Next()
    {
        NextPanel();
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
