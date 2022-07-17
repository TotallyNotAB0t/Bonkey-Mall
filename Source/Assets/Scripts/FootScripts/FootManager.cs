using Cinemachine;
using TMPro;
using UnityEditor;
using UnityEngine;

//Class handling the Foot gamemode
public class FootManager : MonoBehaviour
{
    private static int P1Score, P2Score;
    [SerializeField] private GameObject GameObj, EndObj;
    
    [SerializeField] private TextMeshProUGUI playerOneScore;
    [SerializeField] private TextMeshProUGUI playerTwoScore;

    [SerializeField] private TextMeshProUGUI EndScoreP1, EndScoreP2;
    
    [SerializeField] private Transform playerOne, playerTwo, wotaMelon;

    private void SetScore(int player)
    {
        switch (player)
        {
            case 1:
                P1Score++;
                break;
            case 2:
                P2Score++;
                break;
        }
    }

    //Small script to make the game faster
    /*[MenuItem("Hack/WinP1Foot")]
    public static void WinP1Foot()
    {
        P1Score = 4;
    }*/

    private void UpdateUIScore()
    {
        playerOneScore.text = $"{P1Score}";
        playerTwoScore.text = $"{P2Score}";
    }

    //Reset the position of the players and the ball, and their speed to 0
    private void ResetAllPositions()
    {
        GameObject.FindWithTag("Script").GetComponent<NewFOV>().ChangeAngleCams();
        playerOne.position = new Vector3(10, 20, -20);
        playerTwo.position = new Vector3(-10, 20, 20);
        wotaMelon.position = new Vector3(0, 25, 0);
        playerOne.GetComponentInChildren<Rigidbody>().velocity = Vector3.zero;
        playerTwo.GetComponentInChildren<Rigidbody>().velocity = Vector3.zero;
        wotaMelon.GetComponent<Rigidbody>().velocity = Vector3.zero;
    }

    //Switching to the end panel
    private void Winning()
    {
        Destroy(GameObj);
        EndObj.SetActive(true);
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Ball")) return;

        switch (gameObject.name)
        {
            case "GoalP1":
                SetScore(2);
                break;
            case "GoalP2":
                SetScore(1);
                break;
        }
        UpdateUIScore();

        if (P1Score == 5)
        {
            Winning();
            EndScoreP1.gameObject.SetActive(true);
            return;
        }

        if(P2Score == 5)
        {
            Winning();
            EndScoreP2.gameObject.SetActive(true);
            return;
        }
        ResetAllPositions();
    }
}
