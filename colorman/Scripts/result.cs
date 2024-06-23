using UnityEngine;
using System.Collections;

public class result : MonoBehaviour {

	// Use this for initialization
	void Start () {
		gameController.resetFloor ();
	}
	
	// Update is called once per frame
	void Update () {
		if((Input.GetButton("Fire1")==true)){
			Application.LoadLevel("title");
		}
		if((Input.GetButton("P2F")==true)){
			Application.LoadLevel("title");
		}

	}
}
