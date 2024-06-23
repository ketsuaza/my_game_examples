using UnityEngine;
using System.Collections;

public class ender : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if((Input.GetButton("enter")==true)){
			if(gameController.getflowercount()==gameController.getflowercount2()){
				Application.LoadLevel("draw");
			}
			if(gameController.getflowercount()<gameController.getflowercount2()){
				Application.LoadLevel("ywin");
			}

			if(gameController.getflowercount()>gameController.getflowercount2()){
				Application.LoadLevel("gwin");
			}


		}
	}
}
