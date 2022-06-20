using TMPro;
using UnityEngine;

public class BetweenRacesManager : MonoBehaviour
{
    [SerializeField] private GameObject SingleLevel;
    [SerializeField] private GameObject GPLevel;
    public TextMeshProUGUI a1;
    public TextMeshProUGUI a2;
    public TextMeshProUGUI a3;
    
    private void Start()
    {
        switch (GameModeManager.CurrentLevelGamemode)
        {
            case GameModeManager.GameMode.SingleLevel:
                SingleLevel.SetActive(true);
                break;
            case GameModeManager.GameMode.GrandPrix:
                GPLevel.SetActive(true);
                break;
        }
        a1.text = $"Level : {LevelManager.GetLevelName()}";
        a2.text = $"Place : {LevelManager.GetPlace()}";
        a3.text = $"Time : {LevelManager.GetTime()}";
    }

    public void NextRace()
    {
        SceneController.GoToSceneInt(GPManager.GetIndex());
    }

    public void ResetLevelState()
    {
        LevelManager.ResetLevelInformation();
    }
}
