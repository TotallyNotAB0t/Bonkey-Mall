using TMPro;
using UnityEngine;

public class GPManager : MonoBehaviour
{
    private static int totalPointP1;
    private static int totalPointP2;
    private static float totalTimeP1;
    private static float totalTimeP2;
    private static int levelIndex = 1;
    [SerializeField] private TextMeshProUGUI PointsValP1;
    [SerializeField] private TextMeshProUGUI PointsValP2;
    [SerializeField] private TextMeshProUGUI TimeValP1;
    [SerializeField] private TextMeshProUGUI TimeValP2;

    private void Start()
    {
        PointsValP1.text = GetPointsP1().ToString();
        PointsValP2.text = GetPointsP2().ToString();
        TimeValP1.text = GetTimeP1().ToString();
        TimeValP2.text = GetTimeP2().ToString();
    }

    public static int GetPointsP1()
    {
        return totalPointP1;
    }

    public static void AddPointsP1(int points)
    {
        totalPointP1 += points;
    }

    public static void ResetPointsP1()
    {
        totalPointP1 = 0;
    }
    
    public static int GetPointsP2()
    {
        return totalPointP2;
    }

    public static void AddPointsP2(int points)
    {
        totalPointP2 += points;
    }

    public static void ResetPointsP2()
    {
        totalPointP2 = 0;
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
        levelIndex = 1;
    }

    public static float GetTimeP1()
    {
        return totalTimeP1;
    }

    public static void AddTimeP1(float time)
    {
        totalTimeP1 += time;
    }

    public static void ResetTimeP1()
    {
        totalTimeP1 = 0;
    }
    
    public static float GetTimeP2()
    {
        return totalTimeP2;
    }

    public static void AddTimeP2(float time)
    {
        totalTimeP2 += time;
    }

    public static void ResetTimeP2()
    {
        totalTimeP2 = 0;
    }

    public static void ResetGPStats()
    {
        ResetIndex();
        ResetPointsP1();
        ResetPointsP2();
        ResetTimeP1();
        ResetTimeP2();
    }
}
