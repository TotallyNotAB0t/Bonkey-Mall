using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class blockYou : MonoBehaviour
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
            StartCoroutine(blockPlayer());
        }
        
        if (collision.gameObject.CompareTag("Bot1"))
        {
            StartCoroutine(blockBot1());
        }
        
        if (collision.gameObject.CompareTag("Bot2"))
        {
            StartCoroutine(blockBot2());
        }

    }

    private IEnumerator blockPlayer()
    {
        Debug.Log("oui");
        player.GetComponent<Rigidbody>().mass = 10000f;
        yield return new WaitForSeconds(3);
        player.GetComponent<Rigidbody>().mass = 1;
    }
    
    private IEnumerator blockBot1()
    {
        bot1.GetComponent<NavMeshAgent>().speed = 0;
        yield return new WaitForSeconds(3);
        bot1.GetComponent<NavMeshAgent>().speed = 12;
    }
    
    private IEnumerator blockBot2()
    {
        bot2.GetComponent<NavMeshAgent>().speed = 0;
        yield return new WaitForSeconds(3);
        bot2.GetComponent<NavMeshAgent>().speed = 12;
    }
}
