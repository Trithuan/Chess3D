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
	float rayon = 50;
	float taille_pièce = 80;
	float taille_pion = 50;

	void InitCase(){
	for(int i = 0; i < 8; i++)
		{
			for(int j = 0; j < 8; j++)
			{
				GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
				cube.transform.position = new Vector3(i*taille_cases, 0, j*taille_cases);
				cube.transform.localScale  = new Vector3(taille_cases, épaisseur_cases, taille_cases);
				cube.transform.parent = gameObject.transform;
				cube.name = char.ConvertFromUtf32(65+i) +  (j+1);
				if((i + j) % 2 == 1)
				{
					cube.GetComponent<Renderer>().material.color = Color.black;
				}
				TileArray[i, j] = cube;
			}
		}
	}
	void InitNoir(){
		for(int i = 0; i < 8; i++){
			GameObject pièce = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
			pièce.transform.localScale  = new Vector3(rayon, taille_pièce, rayon);
			pièce.transform.position = new Vector3(i*taille_cases, taille_pièce, taille_cases*7);
			pièce.transform.parent = gameObject.transform;
			pièce.GetComponent<Renderer>().material.color = Color.gray;
			GameObject pion = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
			pion.transform.localScale  = new Vector3(rayon, taille_pion, rayon);
			pion.transform.position = new Vector3(i*taille_cases, taille_pion, taille_cases*6);
			pion.transform.parent = gameObject.transform;
			pion.GetComponent<Renderer>().material.color = Color.gray;
		}
	}
	void InitBlanc(){
		for(int i = 0; i < 8; i++){
			GameObject pièce = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
			pièce.transform.localScale  = new Vector3(rayon, taille_pièce, rayon);
			pièce.transform.position = new Vector3(i*taille_cases, taille_pièce, 0);
			pièce.transform.parent = gameObject.transform;
			pièce.GetComponent<Renderer>().material.color = Color.red;
			GameObject pion = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
			pion.transform.localScale  = new Vector3(rayon, taille_pion, rayon);
			pion.transform.position = new Vector3(i*taille_cases, taille_pion, taille_cases*1);
			pion.transform.parent = gameObject.transform;
			pion.GetComponent<Renderer>().material.color = Color.red;
		}
	}
	void InitPièce(){
		InitNoir();
		InitBlanc();
	}
	void Start()
	{
		InitCase();
		InitPièce();
	}

	// Update is called once per frame
	void Update()
	{
		
	}
}