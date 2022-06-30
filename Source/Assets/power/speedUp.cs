using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class speedUp : MonoBehaviour
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
        if (collision.gameObject.tag == "Player")
        {
            StartCoroutine(speedPlayer());
        }
        
        if (collision.gameObject.tag == "Bot1")
        {
            StartCoroutine(speedBot1());
        }
        
        if (collision.gameObject.tag == "Bot2")
        {
            StartCoroutine(speedBot2());
        }

    }

    private IEnumerator speedPlayer()
    {
        player.GetComponent<Rigidbody>().mass = 0.5f;
        yield return new WaitForSeconds(3);
        player.GetComponent<Rigidbody>().mass = 1;
    }
    
    private IEnumerator speedBot1()
    {
        bot1.GetComponent<NavMeshAgent>().speed = 9;
        yield return new WaitForSeconds(3);
        bot1.GetComponent<NavMeshAgent>().speed = 18;
    }
    
    private IEnumerator speedBot2()
    {
        bot2.GetComponent<NavMeshAgent>().speed = 9;
        yield return new WaitForSeconds(3);
        bot2.GetComponent<NavMeshAgent>().speed = 18;
    }
}
