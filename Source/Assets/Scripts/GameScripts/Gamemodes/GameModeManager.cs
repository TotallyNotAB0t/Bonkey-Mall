using UnityEngine;

//Author : Pierre
public class GameModeManager : MonoBehaviour
{
    public enum GameMode
    {
        None,
        SingleLevel,
        GrandPrix
    };
    public static GameMode CurrentLevelGamemode;

    public void SetGameModeGP()
    {
        CurrentLevelGamemode = GameMode.GrandPrix;
    }
    
    public void SetGameModeSingleLevel()
    {
        CurrentLevelGamemode = GameMode.SingleLevel;
    }

    public static void ResetGameMode()
    {
        CurrentLevelGamemode = GameMode.None;
    }
}
