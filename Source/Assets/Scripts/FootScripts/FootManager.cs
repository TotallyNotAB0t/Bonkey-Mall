using System;
using TMPro;
using UnityEngine;

public class FootManager : MonoBehaviour
{
    private int P1Score, P2Score;
    [SerializeField] private TextMeshProUGUI playerOneScore;
    [SerializeField] private TextMeshProUGUI playerTwoScore;
    [SerializeField] private Transform playerOne, playerTwo, wotaMelon;

    private void SetScore(int player)
    {
        switch (player)
        {
            case 0:
                P1Score++;
                break;
            case 1:
                P2Score++;
                break;
        }
    }

    private void ResetAllPositions()
    {
        playerOne.position = new Vector3(0, 0, -10);
        playerTwo.position = new Vector3(0, 0, 10);
    }
    
    private void OnTriggerEnter(Collider other)
    {
        //TODO scene
        SceneController.GoToScene("A FAIRE");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Awake()
    {
        var instance = gameObject.AddComponent<LevelManager>();
        instance.SetMultiplayer(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
