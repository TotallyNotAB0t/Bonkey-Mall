using UnityEngine;
using Random = UnityEngine.Random;

//Author : Pierre
//Small script infinitely instantiating moles for the main menu
public class MoleGenerator : MonoBehaviour
{
    [SerializeField] private GameObject molePrefab;
    [SerializeField] private Transform sourceMole;

    private void Start()
    {
        Invoke(nameof(InstantiateMole), 1f);
    }

    private void InstantiateMole()
    {
        var go = Instantiate(molePrefab, sourceMole, false);
        go.transform.SetParent(null);
        MoveGenerator();
        Invoke(nameof(InstantiateMole), Random.Range(0.5f, 1.5f));
        Destroy(go, 5f);
    }

    private void MoveGenerator()
    {
        sourceMole.transform.position = new Vector3(Random.Range(-8f, 8f), 6.96f, 102.5f);
    }
}
