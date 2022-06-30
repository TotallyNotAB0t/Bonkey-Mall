using System;
using UnityEngine;
using UnityEngine.AI;

public class testIa : MonoBehaviour
{
    public GameObject gol;

    public GameObject bol;

    public Transform[] gols;
    private NavMeshAgent agent;
    private int destGol = 0;

    // Start is called before the first frame update
    void Start()
    {
        agent = bol.GetComponent<NavMeshAgent>();
        goToNextPoint();
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
            default:
                throw new ArgumentOutOfRangeException();
        }
        
    }
    
    void goToNextPoint() {
            // Returns if no points have been set up
            if (gols.Length == 0)
                return;

            // Set the agent to go to the currently selected destination.
            agent.destination = gols[destGol].position;

            // Choose the next point in the array as the destination,
            // cycling to the start if necessary.
            destGol = (destGol + 1) % gols.Length;
        }

    // Update is called once per frame
    void Update()
    {
        if (!agent.pathPending && agent.remainingDistance < 4.0f)
            goToNextPoint();
    }
}
