using UnityEngine;
using System.Collections;

public class FoodSpawner : MonoBehaviour
{

	public GameObject food;
	public Transform borderTop;
	public Transform borderBottom;
	public Transform borderLeft;
	public Transform borderRight;

	private int maxFood = 5;
	private int foodCounter = 0;


	void Update ()
	{
		if (foodCounter < maxFood) {
			foodCounter++;
			Spawn ();
		}
	}

	void Spawn ()
	{
		int x = (int)Random.Range (borderLeft.position.x, borderRight.position.x);
		int y = (int)Random.Range (borderTop.position.y, borderBottom.position.y);

		Instantiate (food, new Vector2 (x, y), Quaternion.identity);
	}
}
