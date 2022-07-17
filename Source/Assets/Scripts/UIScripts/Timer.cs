using TMPro;
using UnityEngine;

//Author : Pierre
//Class handling time in a race and displaying it
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
            DisplayTime(1, timeElapsedP1);
        }

        if (timerIsRunningP2)
        {
            timeElapsedP2 += Time.deltaTime;
            DisplayTime(2, timeElapsedP2);
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
    
    private void DisplayTime(int player, float timeToDisplay)
    {
        timeToDisplay += 1;
        float minutes = Mathf.FloorToInt(timeToDisplay / 60); 
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        text = $"{minutes:00}:{seconds:00}";
        switch (player)
        {
            case 1:
                timeValueP1.text = text;
                break;
            case 2:
                timeValueP2.text = text;
                break;
        }
    }
}