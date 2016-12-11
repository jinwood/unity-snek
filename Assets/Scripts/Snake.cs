using UnityEngine;
using System.Collections;

public class Snake : MonoBehaviour
{
	Vector2 dir = Vector2.right;

	void Start ()
	{
		InvokeRepeating ("Move", 0.3f, 0.3f);
	}

	void Update ()
	{
		if (Input.GetKey ("w")) {

			dir = Vector2.up;
		} else if (Input.GetKey ("a")) {
			dir = Vector2.left;
		} else if (Input.GetKey ("s")) {
			dir = Vector2.down;
		} else if (Input.GetKey ("d")) {
			dir = Vector2.right;
		}
			
	}

	void Move ()
	{
		transform.Translate (dir);
	}


}
