using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class powerUp : MonoBehaviour
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
        StartCoroutine(speed());
    }

    private IEnumerator speed()
    {
        player.GetComponent<Rigidbody>().mass = 0.5f;
        yield return new WaitForSeconds(3);
        player.GetComponent<Rigidbody>().mass = 1;
    }
}
