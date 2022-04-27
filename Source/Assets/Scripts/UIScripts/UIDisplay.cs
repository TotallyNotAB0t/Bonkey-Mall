using TMPro;
using UnityEngine;

public class UIDisplay : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI velValue;

    // Update is called once per frame
    void FixedUpdate()
    {
        velValue.text = $"{Mathf.Round(GameObject.FindWithTag("Player").GetComponent<Rigidbody>().velocity.magnitude)}";
    }
}
