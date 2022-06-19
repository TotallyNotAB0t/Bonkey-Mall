using System.Collections;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    private int place = 1;
    public static bool IsFinished;

    private void Start()
    {
        IsFinished = false;
    }

    private void NextScene()
    {
        SceneController.GoToScene("BetweenRaces");
    }

    private void LevelSetupStats()
    {
        var go = GameObject.FindWithTag("Script").GetComponent<Timer>();
        if (GameModeManager.CurrentLevelGamemode == GameModeManager.GameMode.SingleLevel)
        {
            LevelManager.SetTime(go.GetTime());
            LevelManager.SetPlace(place);
            LevelManager.SetLevelName(gameObject.scene.name);
        }
        else if (GameModeManager.CurrentLevelGamemode == GameModeManager.GameMode.GrandPrix)
        {
            GPManager.IncrementIndex();
            GPManager.AddPoints(2);
            GPManager.AddTime(go.GetTime());
        }
    }

    private IEnumerator OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            IsFinished = true;
            Timer.timerIsRunning = false;
            LevelSetupStats();
            yield return new WaitForSeconds(3f);
            NextScene();
        }
        else
        {
            place++;
            Destroy(other.gameObject);
        }
    }
}
