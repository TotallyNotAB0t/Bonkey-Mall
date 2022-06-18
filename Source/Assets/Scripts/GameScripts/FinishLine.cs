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

    private IEnumerator OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            IsFinished = true;
            Timer.timerIsRunning = false;
            var go = GameObject.FindWithTag("Script").GetComponent<Timer>();
            LevelManager.SetTime(go.GetTime());
            LevelManager.SetPlace(place);
            LevelManager.SetLevelName(gameObject.scene.name);
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
