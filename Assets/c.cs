﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class c : MonoBehaviour {
	public GameObject kuma;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.A)) {
			Instantiate (kuma);
		}
	}
}
