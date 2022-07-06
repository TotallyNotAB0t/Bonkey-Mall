using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    private float timeElapsedP1 = 0f;
    private float timeElapsedP2 = 0f;
    public static bool timerIsRunningP1;
    public static bool timerIsRunningP2;
    private string text;
    [SerializeField] private TextMeshProUGUI timeValueP1;
    [SerializeField] private TextMeshProUGUI timeValueP2;
    
    private void Start()
    {
        // Starts the timer automatically
        timerIsRunningP1 = true;
        timerIsRunningP2 = true;
    }
    
    void Update()
    {
        if (timerIsRunningP1)
        {
            timeElapsedP1 += Time.deltaTime;
            DisplayTimeP1(timeElapsedP1);
        }

        if (timerIsRunningP2)
        {
            timeElapsedP2 += Time.deltaTime;
            DisplayTimeP2(timeElapsedP2);
        }
    }

    public float GetTime(int player)
    {
        switch (player)
        {
            case 1:
                return Mathf.Round(timeElapsedP1);
            case 2:
                return Mathf.Round(timeElapsedP2);
            default:
                return Mathf.Round(timeElapsedP1);
        }
    }
    
    void DisplayTimeP1(float timeToDisplay)
    {
        timeToDisplay += 1;
        float minutes = Mathf.FloorToInt(timeToDisplay / 60); 
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        text = $"{minutes:00}:{seconds:00}";
        timeValueP1.text = text;
    }
    
    void DisplayTimeP2(float timeToDisplay)
    {
        timeToDisplay += 1;
        float minutes = Mathf.FloorToInt(timeToDisplay / 60); 
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        text = $"{minutes:00}:{seconds:00}";
        timeValueP2.text = text;
    }
}