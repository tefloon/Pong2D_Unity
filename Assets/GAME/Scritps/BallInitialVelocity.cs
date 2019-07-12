using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallInitialVelocity : MonoBehaviour
{
	[SerializeField] float velocityX;
	[SerializeField] float velocityY;

	// Start is called before the first frame update
	void Start()
	{
		GetComponent<Rigidbody2D>().AddForce(new Vector2(velocityX, velocityY), ForceMode2D.Impulse);
	}
}
