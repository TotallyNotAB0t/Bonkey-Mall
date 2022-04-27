using System.Collections;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    public static bool IsFinished;

    private void Start()
    {
        IsFinished = false;
    }

    private void GoToMenu()
    {
        SceneController.GoToScene("MainMenu");
    }

    private void GoToNextLevel(string nextLevel)
    {
        Debug.Log("Going to next level");
        //TODO
        //SceneController.GoToScene(nextLevel);
    }
    
    private IEnumerator OnTriggerEnter(Collider other)
    {
        IsFinished = true;
        yield return new WaitForSeconds(3f);
        GoToMenu();
    }
}
