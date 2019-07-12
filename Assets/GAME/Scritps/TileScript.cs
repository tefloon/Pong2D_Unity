using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileScript : MonoBehaviour
{
	[SerializeField] int numberOfLives = 3;
	[SerializeField] int currentLives;

	SpriteRenderer sr;

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.collider.CompareTag("Ball"))		
		{
			currentLives--;


			UpdateColor();


			if (currentLives <= 0)
			{
				Destroy(gameObject);
			}		
		}
	}

	private void UpdateColor()
	{
		float a = ((float)currentLives / (float)numberOfLives);
		sr.color = new Color(sr.color.r, sr.color.g, sr.color.b, a);
	}


	// Start is called before the first frame update
	void Start()
	{
		sr = GetComponent<SpriteRenderer>();
		currentLives = numberOfLives;
	}

	// Update is called once per frame
	void Update()
	{
		
	}
}
