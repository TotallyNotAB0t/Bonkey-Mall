using System.Collections;
using System.Collections.Generic;
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

    private static Difficulty LevelDifficulty;

    public static void SetDifficulty(Difficulty difficulty)
    {
        LevelDifficulty = difficulty;
    }

    public static Difficulty GetDifficulty()
    {
        return LevelDifficulty;
    }
}
