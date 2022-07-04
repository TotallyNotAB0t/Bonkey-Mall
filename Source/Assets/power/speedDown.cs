using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class speedDown : MonoBehaviour
{
    [SerializeField] private GameObject player;

    [SerializeField] private GameObject bot1;

    [SerializeField] private GameObject bot2;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            StartCoroutine(SpeedPlayer());
        }
        
        if (collision.gameObject.CompareTag("Bot1"))
        {
            StartCoroutine(SpeedBot1());
        }
        
        if (collision.gameObject.CompareTag("Bot2"))
        {
            StartCoroutine(SpeedBot2());
        }

    }

    private IEnumerator SpeedPlayer()
    {
        player.GetComponent<Rigidbody>().mass = 3f;
        yield return new WaitForSeconds(3);
        player.GetComponent<Rigidbody>().mass = 1;
    }
    
    private IEnumerator SpeedBot1()
    {
        bot1.GetComponent<NavMeshAgent>().speed = 9;
        yield return new WaitForSeconds(3);
        bot1.GetComponent<NavMeshAgent>().speed = 18;
    }
    
    private IEnumerator SpeedBot2()
    {
        bot2.GetComponent<NavMeshAgent>().speed = 9;
        yield return new WaitForSeconds(3);
        bot2.GetComponent<NavMeshAgent>().speed = 18;
    }
}
