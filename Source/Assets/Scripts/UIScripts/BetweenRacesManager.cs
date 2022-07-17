using TMPro;
using UnityEngine;

//Author : Pierre
//Class managing the scene between GP races, or single races
public class BetweenRacesManager : MonoBehaviour
{
    [SerializeField] private GameObject SingleLevel;
    [SerializeField] private GameObject GPLevel;
    [SerializeField] private TextMeshProUGUI a1, a2, a3, a4, a5, a6;

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
        a1.text += LevelManager.GetLevelName();
        a3.text = $"{LevelManager.GetTimeP1()}";
        a2.text += LevelManager.GetPlaceP1();

        if (LevelManager.GetMultiplayer())
        {
            a4.text += LevelManager.GetPlaceP2();
            a5.text = $"{LevelManager.GetTimeP2()}"; 
        }
        else
        {
            a4.gameObject.SetActive(false);
            a6.gameObject.SetActive(false);
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
