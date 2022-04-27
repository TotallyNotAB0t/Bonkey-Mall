using TMPro;
using UnityEngine;

public class UIDisplay : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI velValue;
    [SerializeField] private Rigidbody rig;

    // Update is called once per frame
    private void FixedUpdate()
    {
        velValue.text = $"{Mathf.Round(rig.velocity.magnitude)}";
    }
}
