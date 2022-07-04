using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class blockOthers : MonoBehaviour
{

    [SerializeField] private GameObject player;

    [SerializeField] private GameObject bot1;

    [SerializeField] private GameObject bot2;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            StartCoroutine(blockBot1Bot2());
        }
        
        if (collision.gameObject.CompareTag("Bot1"))
        {
            StartCoroutine(blockPlayerBot2());
        }
        
        if (collision.gameObject.CompareTag("Bot2"))
        {
            StartCoroutine(blockPlayerBot1());
        }

    }

    private IEnumerator blockBot1Bot2()
    {
        Debug.Log("oui");
        bot1.GetComponent<NavMeshAgent>().speed = 0;
        bot2.GetComponent<NavMeshAgent>().speed = 0;
        yield return new WaitForSeconds(3);
        bot1.GetComponent<NavMeshAgent>().speed = 12;
        bot2.GetComponent<NavMeshAgent>().speed = 12;
    }
    
    private IEnumerator blockPlayerBot2()
    {
        player.GetComponent<Rigidbody>().mass = 10000f;
        bot2.GetComponent<NavMeshAgent>().speed = 0;
        yield return new WaitForSeconds(3);
        player.GetComponent<Rigidbody>().mass = 1;
        bot2.GetComponent<NavMeshAgent>().speed = 12;
    }
    
    private IEnumerator blockPlayerBot1()
    {
        player.GetComponent<Rigidbody>().mass = 10000f;
        bot1.GetComponent<NavMeshAgent>().speed = 0;
        yield return new WaitForSeconds(3);
        player.GetComponent<Rigidbody>().mass = 1;
        bot1.GetComponent<NavMeshAgent>().speed = 12;
    }
}
