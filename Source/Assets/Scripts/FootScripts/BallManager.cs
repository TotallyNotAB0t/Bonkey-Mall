using UnityEngine;

public class BallManager : MonoBehaviour
{
    [SerializeField] private float explosionForce;
    [SerializeField] private float explosionRadius;
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player") || collision.gameObject.CompareTag("Player2"))
        {
            Debug.Log("kaboom");
            gameObject.GetComponent<Rigidbody>().AddExplosionForce(explosionForce, collision.transform.position, explosionRadius, 0f, ForceMode.Impulse);
        }
        else if (collision.gameObject.CompareTag("Wall"))
        {
            Debug.Log("wol");
            gameObject.GetComponent<Rigidbody>().AddExplosionForce(explosionForce * 200, collision.transform.position, explosionRadius, 0f, ForceMode.Impulse);
        }
    }
}
