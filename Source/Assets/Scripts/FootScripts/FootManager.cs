using System;
using UnityEngine;

public class FootManager : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        //TODO scene
        SceneController.GoToScene("A FAIRE");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Awake()
    {
        var instance = gameObject.AddComponent<LevelManager>();
        instance.SetMultiplayer(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
