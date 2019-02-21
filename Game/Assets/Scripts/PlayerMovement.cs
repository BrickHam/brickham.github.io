using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;

    private void FixedUpdate ()
    {
        transform.position = new Vector3 (Mathf.Clamp (transform.position.x, -(160.0f/9.0f)/2.0f, (160.0f / 9.0f) / 2.0f), Mathf.Clamp (transform.position.y, -5.0f, 5.0f), 0.0f);

        if (Input.GetKey (KeyCode.W))
        {
            transform.Translate (Vector3.up * Time.deltaTime * speed);
        }
        else if (Input.GetKey (KeyCode.S))
        {
            transform.Translate (Vector3.down * Time.deltaTime * speed);
        }
        if (Input.GetKey (KeyCode.A))
        {
            transform.Translate (Vector3.left * Time.deltaTime * speed);
        }
        else if (Input.GetKey (KeyCode.D))
        {
            transform.Translate (Vector3.right * Time.deltaTime * speed);
        }
    }
}