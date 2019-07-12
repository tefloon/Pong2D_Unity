using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapCreator : MonoBehaviour
{
	[Header("Objects")]
	[SerializeField] GameObject tilePrefab;
	[SerializeField] Transform start;
	[SerializeField] Transform tilesPlaceholder;

	[Header("Definition")]
	[SerializeField] int columns = 20;
	[SerializeField] int rows = 5;

	[SerializeField] float paddingX;
	[SerializeField] float paddingY;

	// Start is called before the first frame update
	void Start()
	{
		float tileWidth = tilePrefab.transform.localScale.x;
		float tileHight = tilePrefab.transform.localScale.y;

		for (int y = 0; y < rows; y++)
		{
			for (int x = 0; x < columns; x++)
			{
				Vector2 tilePlace = new Vector2(x * (tileWidth + paddingX), -y * (tileHight + paddingY)) + (Vector2)start.position;

				Instantiate(tilePrefab, tilePlace, Quaternion.identity, tilesPlaceholder);
			}
		}
	}

	// Update is called once per frame
	void Update()
	{
		
	}
}
