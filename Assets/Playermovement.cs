﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour {

	public KeyCode rightKey = KeyCode.RightArrow;
	public KeyCode leftKey = KeyCode.LeftArrow;

	public float moveSpeed = 5f;

	// Use this for initialization
	void Start () {

		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey(rightKey)) {
			transform.Translate (moveSpeed * Time.deltaTime, 0, 0);
		}
		if (Input.GetKey(leftKey)) {
			transform.Translate (-moveSpeed * Time.deltaTime, 0, 0);
		}

	}
}
