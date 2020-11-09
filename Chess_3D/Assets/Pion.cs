using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pion : MonoBehaviour
{
	public int[] pos = new int[2];
	// Start is called before the first frame update
	void Start()
	{
		
	}

	// Update is called once per frame
	void Update()
	{
		
	}
	public bool CanMove(int x, int z){
		print("init pos : "+pos[0] + " , " + pos[1]);
		print("aim : " + x + " , "+ z);
		if (pos[0] > -1 && pos[0] < 8 && pos[1] > -1 && pos[1] < 8)
		{
			print("inboard : "+ pos[1] + " "+ z);
			if(pos[0] == x && (pos[1] == z+1 || pos[1] == z+2))
			{
				pos = new int[]{x,z};
				return true;
			}return false;

		}return false;
	}
}
