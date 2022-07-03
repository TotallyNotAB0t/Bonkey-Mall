using UnityEngine;

public class MultiplayerManager : MonoBehaviour
{
    public bool multiplayer;

    [SerializeField] private GameObject player1Object;
    [SerializeField] private GameObject player2Object;

    private void Start()
    {
        if (!multiplayer)
        {
            player2Object.SetActive(false);
            player1Object.GetComponentInChildren<Camera>().rect = new Rect(0, 0, 1, 1);
        }
    }
}
