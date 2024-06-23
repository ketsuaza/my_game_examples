using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class startcountdowntext : MonoBehaviour {
	int num;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (gameController.startFlag == 0) {
			num=(int)(gameController.wakeuptime + (float)4 - Time.time);
			GetComponent<Text> ().text = num.ToString();
		} else {
			GetComponent<Text> ().text ="";
		}
	}
}
