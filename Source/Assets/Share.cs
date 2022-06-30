using UnityEngine;

public class Share : MonoBehaviour 
{
    /*TWITTER*/
    string TWITTER_ADDRESS = "http://twitter.com/intent/tweet";
    string TWEET_LANGUAGE = "en";
    string textToDisplay="Hey Guys! Check out my place on this race of Bonkey Mall : ";

    /*FACEBOOK*/
    string AppID = "553708503016668";
    string Link = "https://github.com/Chaussurre/Glitch-Racers/tree/NewProjectBranch";
    string PictureFirst = "https://i.imgur.com/U72BfWR.png"; 
    string PictureSecond = "https://i.imgur.com/8h74FZg.png";
    string PictureThird = "https://i.imgur.com/4N9Itdo.png";
    /* l'API de facebook ne permet plus de préremplir des post, ceux pourquoi nous avons opté pour cette solution qui est la meilleure pour le moment */
    
    public void shareScoreOnTwitter () 
    {
        Application.OpenURL (TWITTER_ADDRESS + "?text=" + WWW.EscapeURL(textToDisplay) + LevelManager.GetPlace() + "&amp;lang=" + WWW.EscapeURL(TWEET_LANGUAGE));
    }
	
    // Facebook Share Button
    public void shareScoreOnFacebook ()
    {
        ScreenCapture.CaptureScreenshot("SomeLevel");
        if (LevelManager.GetPlace() == 1)
        {
            Application.OpenURL ("https://www.facebook.com/dialog/feed?" + "app_id=" + AppID + "&picture=" + PictureFirst);
        }

        if (LevelManager.GetPlace() == 2)
        {
            Application.OpenURL ("https://www.facebook.com/dialog/feed?" + "app_id=" + AppID + "&picture=" + PictureSecond);
        }

        if (LevelManager.GetPlace() == 3)
        {
            Application.OpenURL ("https://www.facebook.com/dialog/feed?" + "app_id=" + AppID + "&picture=" + PictureThird);
        }
    }
}