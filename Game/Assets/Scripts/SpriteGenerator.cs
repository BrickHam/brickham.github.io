using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof (MeshRenderer))]
[RequireComponent (typeof (MeshFilter))]
[RequireComponent (typeof (PolygonCollider2D))]
public class SpriteGenerator : MonoBehaviour
{
    public Color color;

    private void Start ()
    {
        float rnd = Random.Range (0.0f, 1.0f);
        Mesh mesh = new Mesh ();

        if (rnd < 0.5f)
        {
            Vector3 [] verticies = new Vector3 [3];

            verticies [0] = new Vector3 (0, 0, 0);
            verticies [1] = new Vector3 (Mathf.Sqrt (16 / 3), 0, 0);
            verticies [2] = new Vector3 (Mathf.Sqrt (16 / 3) / 2, 2, 0);

            mesh.vertices = verticies;
            mesh.triangles = new int [] {0, 1, 2};

            GetComponent<MeshFilter> ().mesh = mesh;
            GetComponent<MeshRenderer> ().material.color = color;

            Vector2 [] points = new Vector2 [3];

            points [0] = new Vector2 (0, 0);
            points [1] = new Vector2 (Mathf.Sqrt (16 / 3), 0);
            points [2] = new Vector2 (Mathf.Sqrt (16 / 3) / 2, 2);

            GetComponent<PolygonCollider2D> ().points = points;
        }
        else
        {
            Vector3 [] verticies = new Vector3 [4];

            verticies [0] = new Vector3 (0, 0, 0);
            verticies [1] = new Vector3 (Mathf.Sqrt (2), 0, 0);
            verticies [2] = new Vector3 (Mathf.Sqrt (2), Mathf.Sqrt (2), 0);
            verticies [3] = new Vector3 (0, Mathf.Sqrt (2), 0);

            mesh.vertices = verticies;
            mesh.triangles = new int [] {0, 1, 2, 0, 2, 3};

            GetComponent<MeshFilter> ().mesh = mesh;
            GetComponent<MeshRenderer> ().material.color = color;

            Vector2 [] points = new Vector2 [4];

            points [0] = new Vector2 (0, 0);
            points [1] = new Vector2 (Mathf.Sqrt (2), 0);
            points [2] = new Vector2 (Mathf.Sqrt (2), Mathf.Sqrt (2));
            points [3] = new Vector2 (0, Mathf.Sqrt (2));

            GetComponent<PolygonCollider2D> ().points = points;
        }
    }
}