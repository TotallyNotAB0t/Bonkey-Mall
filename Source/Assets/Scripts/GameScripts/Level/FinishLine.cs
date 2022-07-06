using System.Collections;
using UnityEngine;

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
            GPManager.AddPointsP1(place == 1 ? 10 : 2);
            GPManager.AddTimeP1(go.GetTime(1));
        }
        else
        {
            GPManager.AddPointsP2(place == 1 ? 10 : 2);
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
                //BOT STATS TO MAKE
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
                //BOT STATS TO MAKE
                place++;
                Destroy(other.gameObject);
            }
        }
    }
}
