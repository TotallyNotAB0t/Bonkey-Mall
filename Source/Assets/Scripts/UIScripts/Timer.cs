using TMPro;
using UnityEngine;

//Author : Pierre
public class Timer : MonoBehaviour
{
    private float timeElapsedP1 = 0f;
    private float timeElapsedP2 = 0f;
    public static bool timerIsRunningP1;
    public static bool timerIsRunningP2;
    private string text;
    [SerializeField] private TextMeshProUGUI timeValueP1;
    [SerializeField] private TextMeshProUGUI timeValueP2;
    
    // Starts the timer automatically
    private void Start()
    {
        timerIsRunningP1 = true;
        timerIsRunningP2 = true;
    }
    
    //The time continues while we don't reach the end
    private void Update()
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

    //Rounds the float values
    public float GetTime(int player)
    {
        return player switch
        {
            1 => Mathf.Round(timeElapsedP1),
            2 => Mathf.Round(timeElapsedP2)
        };
    }

    private void DisplayTimeP1(float timeToDisplay)
    {
        timeToDisplay += 1;
        float minutes = Mathf.FloorToInt(timeToDisplay / 60); 
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        text = $"{minutes:00}:{seconds:00}";
        timeValueP1.text = text;
    }

    private void DisplayTimeP2(float timeToDisplay)
    {
        timeToDisplay += 1;
        float minutes = Mathf.FloorToInt(timeToDisplay / 60); 
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        text = $"{minutes:00}:{seconds:00}";
        timeValueP2.text = text;
    }
}