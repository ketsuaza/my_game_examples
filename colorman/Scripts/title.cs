using UnityEngine;
using System.Collections;

public class title : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if((Input.GetButton("Fire1")==true)){
			Application.LoadLevel("explain");
		}
		if((Input.GetButton("P2F")==true)){
			Application.LoadLevel("explain");
		}
	}
}
