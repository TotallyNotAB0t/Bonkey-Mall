using UnityEngine;
using UnityEngine.SceneManagement;

//Author : Pierre
//Class handling loading scenes
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
