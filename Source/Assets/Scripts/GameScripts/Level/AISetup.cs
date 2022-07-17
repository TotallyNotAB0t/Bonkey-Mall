using UnityEngine;
using UnityEngine.AI;

//Author : Pierre
public class AISetup : MonoBehaviour
{
    [SerializeField] private GameObject goal;
    [SerializeField] private GameObject ball;
    
    //Enabling the IA and setting up its speed, or destroying it without bots
    private void Start()
    {
        NavMeshAgent agent = ball.GetComponent<NavMeshAgent>();
        agent.destination = goal.transform.position;
        switch (LevelManager.GetDifficulty())
        {
            case LevelManager.Difficulty.None:
                Destroy(gameObject);
                break;
            case LevelManager.Difficulty.Easy:
                agent.speed = 12;
                break;
            case LevelManager.Difficulty.Medium:
                agent.speed = 14;
                break;
            case LevelManager.Difficulty.Hard:
                break;
        }
    }
}