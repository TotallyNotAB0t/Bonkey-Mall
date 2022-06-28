using System;
using UnityEngine;
using UnityEngine.AI;

public class testIa : MonoBehaviour
{
    public GameObject gol;

    public GameObject bol;

    // Start is called before the first frame update
    void Start()
    {
        NavMeshAgent agent = bol.GetComponent<NavMeshAgent>();
        agent.destination = gol.transform.position;
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

    // Update is called once per frame
    void Update()
    {
        
    }
}
