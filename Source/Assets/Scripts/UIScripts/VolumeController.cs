using UnityEngine;
using UnityEngine.UI;

//Author : Pierre
public class VolumeController : MonoBehaviour
{
    [SerializeField] private Slider volumeSlider;

    public void ChangeVolume()
    {
        AudioListener.volume = volumeSlider.value;
        SaveVolume();
    }
    
    //Using playerprefs to store the value between game sessions

    private void SaveVolume()
    {
        PlayerPrefs.SetFloat("volumeLevel", volumeSlider.value);
    }

    private void LoadVolume()
    {
        PlayerPrefs.GetFloat("volumeLevel");
    }

    private void Start()
    {
        if (!PlayerPrefs.HasKey("volumeLevel"))
        {
            PlayerPrefs.SetFloat("volumeLevel", 1);
            LoadVolume();
        }
        else
        {
            LoadVolume();
        }
    }
}
