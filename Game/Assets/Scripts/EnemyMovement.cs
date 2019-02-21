using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public GameObject target;
    public float moveAwayDistance;
    public float speed;
    GameObject [] avoidObject;

    private void FixedUpdate ()
    {
        transform.position = new Vector3 (Mathf.Clamp (transform.position.x, -(160.0f / 9.0f) / 2.0f, (160.0f / 9.0f) / 2.0f), Mathf.Clamp (transform.position.y, -5.0f, 5.0f), 0.0f);

        if (PlayerPrefs.GetString ("bot") == "true")
        {
            avoidObject = GameObject.FindGameObjectsWithTag ("Player");

            for (int i = 0; i < avoidObject.Length; i++)
            {
                if (Vector3.Distance (transform.position, avoidObject [i].transform.position) <= 3 && avoidObject [i].GetComponent<SpriteGenerator> ().color == Color.green)
                {
                    transform.position = Vector3.MoveTowards (transform.position, target.transform.position, Time.deltaTime * -speed);
                }
                else
                {
                    transform.position = Vector3.MoveTowards (transform.position, target.transform.position, Time.deltaTime * speed);
                }
            }

            if (Vector3.Distance (transform.position, target.transform.position) <= moveAwayDistance)
            {
                transform.position = Vector3.MoveTowards (transform.position, target.transform.position, Time.deltaTime * -speed);
            }
        }
        else
        {
            if (Input.GetKey (KeyCode.I))
            {
                transform.Translate (Vector3.up * Time.deltaTime * speed);
            }
            else if (Input.GetKey (KeyCode.K))
            {
                transform.Translate (Vector3.down * Time.deltaTime * speed);
            }
            if (Input.GetKey (KeyCode.J))
            {
                transform.Translate (Vector3.left * Time.deltaTime * speed);
            }
            else if (Input.GetKey (KeyCode.L))
            {
                transform.Translate (Vector3.right * Time.deltaTime * speed);
            }
        }
    }
}