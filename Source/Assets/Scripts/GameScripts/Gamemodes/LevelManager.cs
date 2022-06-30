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
    private static float LevelTime;
    private static int LevelPlace;

    public static void SetDifficulty(Difficulty difficulty)
    {
        LevelDifficulty = difficulty;
    }

    public static Difficulty GetDifficulty()
    {
        return LevelDifficulty;
    }

    public static void SetTime(float time)
    {
        LevelTime = time;
    }

    public static float GetTime()
    {
        return LevelTime;
    }

    public static void SetPlace(int place)
    {
        LevelPlace = place;
    }

    public static int GetPlace()
    {
        return LevelPlace;
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
        LevelTime = 0;
        LevelPlace = 0;
    }
}
