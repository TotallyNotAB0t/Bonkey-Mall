using TMPro;
using UnityEngine;

//Author : Pierre
public class UIDisplay : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI velValueP1;
    [SerializeField] private Rigidbody rigP1;
    [SerializeField] private TextMeshProUGUI velValueP2;
    [SerializeField] private Rigidbody rigP2;

    // Update is called once per frame
    private void FixedUpdate()
    {
        velValueP1.text = $"{Mathf.Round(rigP1.velocity.magnitude)}";
        velValueP2.text = $"{Mathf.Round(rigP2.velocity.magnitude)}";
    }
}
