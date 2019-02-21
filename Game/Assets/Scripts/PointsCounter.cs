using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsCounter : MonoBehaviour
{
    public GameObject text;
    public GameObject p2Text;

    private void Start ()
    {
        text.GetComponent<Text> ().text = "Cyan: " + PlayerPrefs.GetInt ("Cyan") + "\nRed: " + PlayerPrefs.GetInt ("Red");

        if (PlayerPrefs.GetString ("bot") == "false")
        {
            p2Text.GetComponent<Text> ().text = "Player 2 Enabled";
        }
    }

    private void FixedUpdate ()
    {
        if (Input.GetKeyDown (KeyCode.Backspace))
        {
            if (PlayerPrefs.GetString ("bot") == "true")
            {
                PlayerPrefs.SetString ("bot", "false");
                p2Text.GetComponent<Text> ().text = "Player 2 Enabled";
            }
            else if (PlayerPrefs.GetString ("bot") == "false")
            {
                PlayerPrefs.SetString ("bot", "true");
                p2Text.GetComponent<Text> ().text = " ";
            }
        }
    }
}