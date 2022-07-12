using TMPro;
using UnityEngine;

//Author : Pierre
public class GraphicsController : MonoBehaviour
{
    [SerializeField] private TMP_Dropdown dropdown;
    public void SetQuality()
    {
        QualitySettings.SetQualityLevel(dropdown.value, true);
    }
}
