using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMove : MonoBehaviour
{
	[SerializeField] private float paddleY = -4.5f;

	// Start is called before the first frame update
	void Start()
	{
		print("a");
	}

	// Update is called once per frame
	void Update()
	{
		Vector2 paddlePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		paddlePosition.y = paddleY;
		transform.position = paddlePosition;
	}
}
