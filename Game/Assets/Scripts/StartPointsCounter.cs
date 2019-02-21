using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartPointsCounter : MonoBehaviour
{
    private void Start ()
    {
        PlayerPrefs.SetInt ("Cyan", 0);
        PlayerPrefs.SetInt ("Red", 0);

        PlayerPrefs.SetString ("bot", "true");

        SceneManager.LoadScene ("Main");
    }
}