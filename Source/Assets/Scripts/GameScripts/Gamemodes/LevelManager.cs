using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public enum Difficulty
    {
        None,
        Easy,
        Medium,
        Hard
    }

    private static string LevelName;
    private static Difficulty LevelDifficulty;
    private static float LevelTimeP1;
    private static float LevelTimeP2;
    private static int LevelPlaceP1;
    private static int LevelPlaceP2;
    private static bool IsMultiplayer;

    public static void SetMultiplayer(bool multi)
    {
        IsMultiplayer = multi;
    }

    public static bool GetMultiplayer()
    {
        return IsMultiplayer;
    }

    public static void SetDifficulty(Difficulty difficulty)
    {
        LevelDifficulty = difficulty;
    }

    public static Difficulty GetDifficulty()
    {
        return LevelDifficulty;
    }

    public static void SetTimeP1(float time)
    {
        LevelTimeP1 = time;
    }

    public static float GetTimeP1()
    {
        return LevelTimeP1;
    }
    
    public static void SetTimeP2(float time)
    {
        LevelTimeP2 = time;
    }

    public static float GetTimeP2()
    {
        return LevelTimeP2;
    }

    public static void SetPlaceP1(int place)
    {
        LevelPlaceP1 = place;
    }

    public static int GetPlaceP1()
    {
        return LevelPlaceP1;
    }
    
    public static void SetPlaceP2(int place)
    {
        LevelPlaceP2 = place;
    }

    public static int GetPlaceP2()
    {
        return LevelPlaceP2;
    }

    public static string GetLevelName()
    {
        return LevelName;
    }

    public static void SetLevelName(string name)
    {
        LevelName = name;
    }

    public static void ResetLevelInformation()
    {
        LevelDifficulty = Difficulty.None;
        LevelTimeP1 = 0;
        LevelPlaceP1 = 0;
        LevelTimeP2 = 0;
        LevelPlaceP2 = 0;
        
    }
}
