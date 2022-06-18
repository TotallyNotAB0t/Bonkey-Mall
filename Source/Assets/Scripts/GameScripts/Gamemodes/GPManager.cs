using System;
using UnityEngine;

public class GPManager : MonoBehaviour
{
    private static int totalPoint;
    private static int levelIndex;
    private static float totalTime;
    public static Level[] grandPrix = new Level[4];

    public static int GetPoints()
    {
        return totalPoint;
    }

    public static void AddPoints(int points)
    {
        totalPoint += points;
    }

    public static void ResetPoints()
    {
        totalPoint = 0;
    }

    public static int GetIndex()
    {
        return levelIndex;
    }

    public static void IncrementIndex()
    {
        levelIndex++;
    }

    public static void ResetIndex()
    {
        levelIndex = 0;
    }

    public static float GetTime()
    {
        return totalTime;
    }

    public static void AddTime(float time)
    {
        totalTime += time;
    }

    public static void ResetTime()
    {
        totalTime = 0;
    }

    [Serializable]
    public class Level
    {
        public string LevelName;
        public float Time;
        public float Place;
    }
}
