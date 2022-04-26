using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    //Player to follow
    [SerializeField] private Transform player;
    
    private void Update () {
        transform.position = player.transform.position + new Vector3(0, 1, -5);
    }
}
