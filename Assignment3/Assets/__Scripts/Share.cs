using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Share : MonoBehaviour
{
    private const string TWITTER_ADDRESS = "http://twitter.com/intent/tweet";

    public void ShareOnTwitter()
    {
        string _tweet = "Score: " + ScoreManager.SCORE;
        Application.OpenURL(TWITTER_ADDRESS + "?text=" + WWW.EscapeURL(_tweet));
    }

}
