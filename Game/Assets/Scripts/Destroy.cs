using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Destroy : MonoBehaviour
{
    public bool isFollower;
    public string hazardTag;

    private void OnCollisionEnter2D (Collision2D collision)
    {
        if (collision.gameObject.CompareTag (hazardTag))
        {
            if (isFollower)
            {
                GetComponent<Follower> ().followObject.GetComponent<FollowerController> ().amountOfFollowers--;
            }
            else if (gameObject.CompareTag ("Enemy"))
            {
                PlayerPrefs.SetInt ("Cyan", PlayerPrefs.GetInt ("Cyan") + 1);
                SceneManager.LoadScene ("Main");
            }
            else if (gameObject.CompareTag ("Player"))
            {
                PlayerPrefs.SetInt ("Red", PlayerPrefs.GetInt ("Red") + 1);
                SceneManager.LoadScene ("Main");
            }

            Destroy (gameObject);
        }
    }
}