using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;

public class Board : MonoBehaviour
{
	GameObject[,] PièceArray  = new GameObject[8,8];
	// Start is called before the first frame update
	public static int taille_cases = 100;
	public static float épaisseur_cases = 1;
	public static float rayon = 50;
	public static float taille_pièce = 40;
	public static float taille_pion = 20;

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
				// TileArray[i, j] = cube;
			}
		}
	}
	void InitPiece(Color color,int pion_z,int piece_z){
		for(int i = 0; i < 8; i++){
			GameObject pièce = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
			pièce.transform.localScale  = new Vector3(rayon, taille_pièce, rayon);
			pièce.transform.position = new Vector3(i*taille_cases, taille_pièce, taille_cases*piece_z);
			pièce.transform.parent = gameObject.transform;
			pièce.GetComponent<Renderer>().material.color = color;
			pièce.AddComponent<Pion>();
			pièce.GetComponent<Pion>().x = i;
			pièce.GetComponent<Pion>().z = piece_z;
			pièce.AddComponent<DragObject>();

			GameObject pion = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
			pion.transform.localScale  = new Vector3(rayon, taille_pion, rayon);
			pion.transform.position = new Vector3(i*taille_cases, taille_pion, taille_cases*pion_z);
			pion.transform.parent = gameObject.transform;
			pion.GetComponent<Renderer>().material.color = color;
			pion.AddComponent<Pion>();
			pion.GetComponent<Pion>().x = i;
			pion.GetComponent<Pion>().z = pion_z;
			pion.AddComponent<DragObject>();
		}
	}
	void Start()
	{
		InitCase();
		InitPiece(Color.grey, 6,7);
		InitPiece(Color.red, 1,0);
	}

	// Update is called once per frame
	void Update()
	{
		
	}
}