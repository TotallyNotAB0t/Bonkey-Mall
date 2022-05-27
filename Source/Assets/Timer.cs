using UnityEngine;
public class Timer : MonoBehaviour
{
    private float timeElapsed = 0f;
    public bool timerIsRunning;
    private string text;
    private void Start()
    {
        // Starts the timer automatically
        timerIsRunning = true;
    }
    void Update()
    {
        if (timerIsRunning)
        {
            timeElapsed += Time.deltaTime;
            DisplayTime(timeElapsed);
        }
    }
    
    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;
        float minutes = Mathf.FloorToInt(timeToDisplay / 60); 
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        text = $"{minutes:00}:{seconds:00}";
        Debug.Log(text);
    }
}