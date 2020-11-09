using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pion : MonoBehaviour
{
	public int x, z;
	bool dead = false;
	bool firstmove = true; 
	
	// Start is called before the first frame update
	void Start()
	{
		
	}

	// Update is called once per frame
	void Update()
	{
		
	}
	public bool CanMove(int posX, int posZ){
		print("init pos : "+x+ " , " +z);
		print("aim : " + posX + " , "+ posZ);

		if (isInBoard(posX,posZ))
		{
			print("inboard : "+ z + " "+ posZ);
			if(x == posX && (z == posZ+1 || (z == posZ+2 && firstmove))){
				firstmove = false; 
				return true;
			}
			return false;
		}return false;
	}


	public bool isInBoard(int x, int z){
	return x > -1 && x < 8 && z > -1 && z < 8; 
	}
}
