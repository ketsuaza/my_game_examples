using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class HpBarCtrl : MonoBehaviour {
	public Slider slider;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		float sumArea=gameController.flowercount+gameController.flowercount2;
		if (gameController.flowercount == 0 && gameController.flowercount2 == 0) {
			slider.value = 0.5f;
		} else {
			slider.value = gameController.flowercount / sumArea;
		}

	}
}
