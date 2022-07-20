using UnityEngine;

//Author : Theo
public class Share : MonoBehaviour 
{
    /*TWITTER*/
    private readonly string TWITTER_ADDRESS = "http://twitter.com/intent/tweet";
    private readonly string TWEET_LANGUAGE = "en";
    private readonly string textToDisplay="Hey Guys! Check out my place on this race of Bonkey Mall : ";
    private readonly string textToDisplayGP = "I just finished a Bonkey Mall Grand Prix ! Look at my time : ";
    private readonly string textToDisplayGP2 = " and my points : ";
    

    /*FACEBOOK*/
    private readonly string AppID = "553708503016668";
    private readonly string Link = "https://github.com/TotallyNotAB0t/Bonkey-Mall/tree/master";
    private readonly string PictureFirst = "https://i.imgur.com/U72BfWR.png"; 
    private readonly string PictureSecond = "https://i.imgur.com/8h74FZg.png";
    private readonly string PictureThird = "https://i.imgur.com/4N9Itdo.png";
    private readonly string PictureFourth = "https://imgur.com/QY4Y3Fg";
    /* l'API de facebook ne permet plus de préremplir des post, ceux pourquoi nous avons opté pour cette solution qui est la meilleure pour le moment */
    
    public void shareScoreOnTwitter () 
    {
        if (GameModeManager.CurrentLevelGamemode == GameModeManager.GameMode.GrandPrix)
        {
            Application.OpenURL (TWITTER_ADDRESS + "?text=" + WWW.EscapeURL(textToDisplayGP) + LevelManager.GetTimeP1() + WWW.EscapeURL(textToDisplayGP2) + LevelManager.GetTimeP1() + "&amp;lang=" + WWW.EscapeURL(TWEET_LANGUAGE));
        }
        else
        {
            Application.OpenURL (TWITTER_ADDRESS + "?text=" + WWW.EscapeURL(textToDisplay) + LevelManager.GetPlaceP1() + "&amp;lang=" + WWW.EscapeURL(TWEET_LANGUAGE));
        }
    }

    // Facebook Share Button
    public void shareScoreOnFacebook ()
    {
        if (GameModeManager.CurrentLevelGamemode == GameModeManager.GameMode.GrandPrix)
        {
            switch (LevelManager.GetPlaceP1())
            {
                case 1:
                    Application.OpenURL ("https://www.facebook.com/dialog/feed?" + "app_id=" + AppID + "&picture=" + PictureFirst);
                    break;
                case 2:
                    Application.OpenURL ("https://www.facebook.com/dialog/feed?" + "app_id=" + AppID + "&picture=" + PictureSecond);
                    break;
                case 3:
                    Application.OpenURL ("https://www.facebook.com/dialog/feed?" + "app_id=" + AppID + "&picture=" + PictureThird);
                    break;
                case 4:
                    Application.OpenURL ("https://www.facebook.com/dialog/feed?" + "app_id=" + AppID + "&picture=" + PictureFourth);
                    break;
            }
        }
        else switch (LevelManager.GetPlaceP1())
        {
            case 1:
                Application.OpenURL ("https://www.facebook.com/dialog/feed?" + "app_id=" + AppID + "&picture=" + PictureFirst);
                break;
            case 2:
                Application.OpenURL ("https://www.facebook.com/dialog/feed?" + "app_id=" + AppID + "&picture=" + PictureSecond);
                break;
            case 3:
                Application.OpenURL ("https://www.facebook.com/dialog/feed?" + "app_id=" + AppID + "&picture=" + PictureThird);
                break;
            case 4:
                Application.OpenURL ("https://www.facebook.com/dialog/feed?" + "app_id=" + AppID + "&picture=" + PictureFourth);
                break;
        }
    }
}