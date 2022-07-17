using UnityEngine;
using UnityEngine.Localization.Settings;

//Author : Pierre
//Every UI script should inherit this class for basic events
public class BasicMenu : MonoBehaviour
{
    public void QuitGame()
    {
        Application.Quit();
    }

    public void SwitchLanguage()
    {
        LocalizationSettings.SelectedLocale =
            LocalizationSettings.SelectedLocale == LocalizationSettings.AvailableLocales.Locales[0] ?
                LocalizationSettings.AvailableLocales.Locales[1] :
                LocalizationSettings.AvailableLocales.Locales[0];
    }
}
