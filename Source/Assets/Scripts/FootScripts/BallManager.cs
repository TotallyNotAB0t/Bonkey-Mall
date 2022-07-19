using UnityEngine;

public class BallManager : MonoBehaviour
{
    [SerializeField] private float explosionForce;
    [SerializeField] private float explosionRadius;
    
    [SerializeField] private float explosionForceWall;
    [SerializeField] private float explosionRadiusWall;
    
    //Depending on the collision, adds a force to the ball
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player") || collision.gameObject.CompareTag("Player2"))
        {
            gameObject.GetComponent<Rigidbody>().AddExplosionForce(explosionForce, collision.transform.position, explosionRadius, 0f, ForceMode.Impulse);
        }
        else if (collision.gameObject.CompareTag("Wall"))
        {
            gameObject.GetComponent<Rigidbody>().AddExplosionForce(explosionForceWall, collision.transform.position, explosionRadiusWall, 0f, ForceMode.Impulse);
        }
    }
}
