using UnityEngine;

public class MultiplayerManager : MonoBehaviour
{
    [SerializeField] private GameObject player1Object;
    [SerializeField] private GameObject player2Object;
    public bool test;

    private void Start()
    {
        LevelManager.SetMultiplayer(test);
        if (LevelManager.GetMultiplayer()) return;
        player2Object.SetActive(false);
        player1Object.GetComponentInChildren<Camera>().rect = new Rect(0, 0, 1, 1);
    }
}
