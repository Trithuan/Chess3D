using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;

public class Board : MonoBehaviour
{
	GameObject[,] TileArray  = new GameObject[8,8];
	// Start is called before the first frame update
	float taille_cases = 100;
	float épaisseur_cases = 1;

	void Start()
	{
		for(int i = 0; i < 8; i++)
		{
			for(int j = 0; j < 8; j++)
			{
				GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
				cube.transform.position = new Vector3(i*taille_cases, 0, j*taille_cases);
				cube.transform.localScale  = new Vector3(taille_cases, épaisseur_cases, taille_cases);
				cube.transform.parent = gameObject.transform;
				cube.name = char.ConvertFromUtf32(65+i) +  (j+1);
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