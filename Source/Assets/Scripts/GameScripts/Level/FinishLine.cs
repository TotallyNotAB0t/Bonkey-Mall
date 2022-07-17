using System.Collections;
using UnityEngine;

//Author : Pierre
//Class attributing points to the players
public class FinishLine : MonoBehaviour
{
    private int place = 1;
    private bool P1Finished;
    private bool P2Finished;

    private void LevelSetupStats(int player)
    {
        var go = GameObject.FindWithTag("Script").GetComponent<Timer>();
        
        if (player == 1)
        {
            LevelManager.SetTimeP1(go.GetTime(1));
            LevelManager.SetPlaceP1(place);
        }
        else
        {
            LevelManager.SetTimeP2(go.GetTime(2));
            LevelManager.SetPlaceP2(place);
        }
        LevelManager.SetLevelName(gameObject.scene.name);

        if (GameModeManager.CurrentLevelGamemode != GameModeManager.GameMode.GrandPrix) return;
        //A changer avec plus de bots
        if (player == 1)
        {
            switch (place)
            {
                case 1:
                    GPManager.AddPointsP1(10);
                    break;
                case 2:
                    GPManager.AddPointsP1(5);
                    break;
                case 3:
                    GPManager.AddPointsP1(3);
                    break;
                case 4:
                    GPManager.AddPointsP1(1);
                    break;
            }
            GPManager.AddTimeP1(go.GetTime(1));
        }
        else
        {
            switch (place)
            {
                case 1:
                    GPManager.AddPointsP2(10);
                    break;
                case 2:
                    GPManager.AddPointsP2(5);
                    break;
                case 3:
                    GPManager.AddPointsP2(3);
                    break;
                case 4:
                    GPManager.AddPointsP2(1);
                    break;
            }
            GPManager.AddTimeP2(go.GetTime(2));
        }
    }

    private void NextScene()
    {
        if (gameObject.scene.name == "lvl5" && GameModeManager.CurrentLevelGamemode == GameModeManager.GameMode.GrandPrix)
        {
            SceneController.GoToScene("GPEnd");
        }
        else
        {
            SceneController.GoToScene("BetweenRaces");
        }
    }

    //Stopping the timer, updating the stats and waiting for the race to end
    private IEnumerator OnTriggerEnter(Collider other)
    {
        if (!LevelManager.GetMultiplayer())
        {
            if (other.gameObject.CompareTag("Player"))
            {
                other.gameObject.SetActive(false);
                P1Finished = true;
                Timer.timerIsRunningP1 = false;
                LevelSetupStats(1);
                GPManager.IncrementIndex();
                yield return new WaitForSeconds(1.5f);
                NextScene();
            }
            else
            {
                place++;
                Destroy(other.gameObject);
            }
        }
        else if (LevelManager.GetMultiplayer())
        {
            if (other.gameObject.CompareTag("Player"))
            {
                other.gameObject.SetActive(false);
                P1Finished = true;
                Timer.timerIsRunningP1 = false;
                LevelSetupStats(1);
                place++;
                yield return new WaitForSeconds(1.5f);
                if (P1Finished && P2Finished)
                {
                    GPManager.IncrementIndex();
                    NextScene();
                }
            }
            else if (other.gameObject.CompareTag("Player2"))
            {
                other.gameObject.SetActive(false);
                P2Finished = true;
                Timer.timerIsRunningP2 = false;
                LevelSetupStats(2);
                place++;
                yield return new WaitForSeconds(1.5f);
                if (P1Finished && P2Finished)
                {
                    GPManager.IncrementIndex();
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
}
