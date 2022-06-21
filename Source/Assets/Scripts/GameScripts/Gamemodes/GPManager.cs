using TMPro;
using UnityEngine;

public class GPManager : MonoBehaviour
{
    private static int totalPoint;
    private static float totalTime;
    private static int levelIndex = 1;
    [SerializeField] private TextMeshProUGUI TextPoints;
    [SerializeField] private TextMeshProUGUI TextTime;

    private void Start()
    {
        TextPoints.text = GetPoints().ToString();
        TextTime.text = GetTime().ToString();
    }

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
        levelIndex = 1;
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
}
