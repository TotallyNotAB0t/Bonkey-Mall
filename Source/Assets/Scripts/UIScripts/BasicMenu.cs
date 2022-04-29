using UnityEngine;
using UnityEngine.Localization.Settings;

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
