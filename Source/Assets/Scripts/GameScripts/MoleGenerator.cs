using UnityEngine;
using Random = UnityEngine.Random;

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
        Instantiate(molePrefab, sourceMole, false);
        Invoke(nameof(InstantiateMole), Random.Range(1.5f, 3f));
    }
}
