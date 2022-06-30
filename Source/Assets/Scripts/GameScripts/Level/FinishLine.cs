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
        switch (GameModeManager.CurrentLevelGamemode)
        {
            case GameModeManager.GameMode.SingleLevel:
                LevelManager.SetTime(go.GetTime());
                LevelManager.SetPlace(place);
                LevelManager.SetLevelName(gameObject.scene.name);
                break;
            
            case GameModeManager.GameMode.GrandPrix:
                LevelManager.SetTime(go.GetTime());
                LevelManager.SetPlace(place);
                LevelManager.SetLevelName(gameObject.scene.name);
                GPManager.IncrementIndex();
                
                //A changer avec plus de bots
                GPManager.AddPoints(place == 1 ? 10 : 2);
                GPManager.AddTime(go.GetTime());
                break;
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
            if (gameObject.scene.name == "lvl5")
            {
                SceneController.GoToScene("GPEnd");
            }
            else
            {
                NextScene();
            }
        }
        else
        {
            place++;
            Destroy(other.gameObject);
        }
    }
}
