using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follower : MonoBehaviour
{
    public GameObject followObject;
    public float minimumDistance;
    public float maximumDistance;
    public float speed;

    private void Start ()
    {
        StartCoroutine (Multiply ());
    }

    private void FixedUpdate ()
    {
        transform.position = new Vector3 (Mathf.Clamp (transform.position.x, -(160.0f / 9.0f) / 2.0f, (160.0f / 9.0f) / 2.0f), Mathf.Clamp (transform.position.y, -5.0f, 5.0f), 0.0f);

        if (Vector3.Distance (transform.position, followObject.transform.position) > maximumDistance)
        {
            transform.position = Vector3.MoveTowards (transform.position, followObject.transform.position, Time.deltaTime * speed);
        }
        if (Vector3.Distance (transform.position, followObject.transform.position) < minimumDistance)
        {
            transform.position = Vector3.MoveTowards (transform.position, followObject.transform.position, Time.deltaTime * -speed);
        }
    }

    IEnumerator Multiply ()
    {
        while (true)
        {
            if (followObject.GetComponent<FollowerController> ().amountOfFollowers <= 64)
            {
                yield return new WaitForSeconds (2.5f + Random.Range (-2.5f, 2.5f));
                followObject.GetComponent<FollowerController> ().amountOfFollowers++;
                Instantiate (gameObject, new Vector3 (transform.position.x + 0.001f, transform.position.y, 0.0f), Quaternion.Euler (Vector3.zero));
            }
            else
            {
                yield return new WaitForSeconds (1.0f);
            }
        }
    }
}