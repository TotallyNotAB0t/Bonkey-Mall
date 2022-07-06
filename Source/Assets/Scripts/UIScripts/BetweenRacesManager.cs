using TMPro;
using UnityEngine;

public class BetweenRacesManager : MonoBehaviour
{
    [SerializeField] private GameObject SingleLevel;
    [SerializeField] private GameObject GPLevel;
    public TextMeshProUGUI a1;
    public TextMeshProUGUI a2;
    public TextMeshProUGUI a3;
    public TextMeshProUGUI a4;
    public TextMeshProUGUI a5;

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
        a2.text = $"Place : {LevelManager.GetPlaceP1()}";
        a3.text = $"Time : {LevelManager.GetTimeP1()}";
        if (LevelManager.GetMultiplayer())
        {
            a4.text = $"Place : {LevelManager.GetPlaceP2()}";
            a5.text = $"Time : {LevelManager.GetTimeP2()}"; 
        }
        else
        {
            a4.gameObject.SetActive(false);
            a5.gameObject.SetActive(false);
        }
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
