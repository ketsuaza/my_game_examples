using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class timertext : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		int countdownTime = (int)(gameController.starttime + 60 - Time.time);
		if (gameController.startFlag==0||gameController.endFlag==1) {
			GetComponent<Text> ().text = "";
		} else {
			GetComponent<Text> ().text = countdownTime.ToString ()+"秒";
		}
	}
}
