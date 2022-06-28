using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Share : MonoBehaviour
{
    private string TWITTER_ADDRESS = "https://twitter.com/intent/tweet";

    private string TWEET_LANGUAGE = "en";

    private string textToShare = "Just made a new high score : ";
    
    // Start is called before the first frame update
    public void shareOnTwitter()
    {
        Application.OpenURL(TWITTER_ADDRESS + "?text=" + WWW.EscapeURL(textToShare) + "999" + "&amp;lang=" + WWW.EscapeURL(TWEET_LANGUAGE));
    }

}
