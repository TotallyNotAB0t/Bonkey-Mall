using UnityEngine;
using System.Collections;

public class Share : MonoBehaviour 
{
    /*TWITTER*/
    string TWITTER_ADDRESS = "http://twitter.com/intent/tweet";
    string TWEET_LANGUAGE = "en";
    string textToDisplay="Hey Guys! Check out my score: ";

    /*FACEBOOK*/
    string AppID = "553708503016668";
    string Link = "https://github.com/Chaussurre/Glitch-Racers/tree/NewProjectBranch";
    public void shareScoreOnTwitter () 
    {
        Application.OpenURL (TWITTER_ADDRESS + "?text=" + WWW.EscapeURL(textToDisplay) + LevelManager.GetPlace() + "&amp;lang=" + WWW.EscapeURL(TWEET_LANGUAGE));
    }
	
    // Facebook Share Button
    public void shareScoreOnFacebook ()
    {
        ScreenCapture.CaptureScreenshot("SomeLevel");
        Application.OpenURL ("https://www.facebook.com/dialog/feed?" + "app_id=" + AppID + "&link=" + Link);
    }
}