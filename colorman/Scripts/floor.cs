﻿using UnityEngine;
using System.Collections;

public class floor : MonoBehaviour {
	// Use this for initialization
	void OnCollisionEnter(Collision other) {
	}
	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("k") == true) {
			Destroy(gameObject);
		}
	}
}
