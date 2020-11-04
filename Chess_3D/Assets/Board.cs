using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
	GameObject[,] TileArray  = new GameObject[8,8];
	// Start is called before the first frame update
	void Start()
	{
		for(int i = 0; i < 8; i++)
		{
			for(int j = 0; j < 8; j++)
			{
				GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
				cube.transform.position = new Vector3(i+(0.1f*i), 0, j+(0.1f*j));
				cube.transform.localScale  = new Vector3(1, 0.1f, 1);
				cube.transform.parent = gameObject.transform;
				if((i + j) % 2 == 1){
				cube.GetComponent<Renderer>().material.color = Color.black;
				}
				TileArray[i, j] = cube;
			}
		}
	}

	// Update is called once per frame
	void Update()
	{
		
	}
}
