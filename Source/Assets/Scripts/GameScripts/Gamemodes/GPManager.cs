using TMPro;
using UnityEngine;

//Author : Pierre
//Class handling the points and time of the players
public class GPManager : MonoBehaviour
{
    private static int totalPointP1;
    private static int totalPointP2;
    private static float totalTimeP1;
    private static float totalTimeP2;
    private static int levelIndex = 1;
    [SerializeField] private TextMeshProUGUI PointsValP1, PointsValP2, TimeValP1, TimeValP2, P2P, P2T;

    private void Start()
    {
        PointsValP1.text = $"{GetPointsP1()}";
        TimeValP1.text = $"{GetTimeP1()}";
        
        if (LevelManager.GetMultiplayer())
        {
            PointsValP2.text = $"{GetPointsP2()}";
            TimeValP2.text = $"{GetTimeP2()}";
        }
        else
        {
            P2P.gameObject.SetActive(false);
            P2T.gameObject.SetActive(false);
        }
    }

    public static int GetPointsP1()
    {
        return totalPointP1;
    }

    public static void AddPointsP1(int points)
    {
        totalPointP1 += points;
    }

    private static void ResetPointsP1()
    {
        totalPointP1 = 0;
    }

    private static int GetPointsP2()
    {
        return totalPointP2;
    }

    public static void AddPointsP2(int points)
    {
        totalPointP2 += points;
    }

    private static void ResetPointsP2()
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

    private static void ResetIndex()
    {
        levelIndex = 1;
    }

    private static float GetTimeP1()
    {
        return totalTimeP1;
    }

    public static void AddTimeP1(float time)
    {
        totalTimeP1 += time;
    }

    private static void ResetTimeP1()
    {
        totalTimeP1 = 0;
    }

    private static float GetTimeP2()
    {
        return totalTimeP2;
    }

    public static void AddTimeP2(float time)
    {
        totalTimeP2 += time;
    }

    private static void ResetTimeP2()
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
