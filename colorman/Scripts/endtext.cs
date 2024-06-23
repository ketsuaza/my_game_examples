using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class endtext : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(gameController.endFlag==0){
			GetComponent<Text> ().text="";
		}else{
			GetComponent<Text> ().text="END!!";
		}
	}
}
