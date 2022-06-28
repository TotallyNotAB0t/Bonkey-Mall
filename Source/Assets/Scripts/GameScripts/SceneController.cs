using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public static void GoToScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    
    public static void GoToSceneInt(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
