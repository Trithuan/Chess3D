﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragObject : MonoBehaviour
{
	private Vector3 mOffset;
	private float mZCoord;
	private int jump_size = 150;
	private float static_height = 0;


	void OnMouseDown()
	{
		print("click");
		mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
		//Store offset = gameObject.transform.position - GetMouseWorldPos();
		mOffset = gameObject.transform.position - GetMouseWorldPos();
		static_height = gameObject.transform.position.y;
	}
	private Vector3 GetMouseWorldPos()
	{
		//pixel coordinates (x,y)
		Vector3 mousePoint = Input.mousePosition;

		// z coordinate of game object on screen
		mousePoint.z = mZCoord;

		return Camera.main.ScreenToWorldPoint(mousePoint);
	}
	void OnMouseDrag()
	{
		transform.position = new Vector3(GetMouseWorldPos().x + mOffset.x, static_height+jump_size, (int)GetMouseWorldPos().z + mOffset.z);
		//transform.position = mousePosWorld+mOffset
	}
	void OnMouseUp()
	{
		transform.position = new Vector3(GetMouseWorldPos().x + mOffset.x, static_height, (int)GetMouseWorldPos().z + mOffset.z);
	}
}
