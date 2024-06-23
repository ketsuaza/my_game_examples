using UnityEngine;
using System.Collections;

public class seed2 : MonoBehaviour {
	// Use this for initialization
	public GameObject flower;
	public GameObject newFlower;
	Quaternion flowerRotation=new Quaternion(0,0,0,0);
	void OnCollisionEnter(Collision other) {
		flowerRotation.eulerAngles=new Vector3(90,0,0);
		if (other.gameObject.ToString () == "Cube (UnityEngine.GameObject)") {
			Destroy (gameObject);
			gameController.flowercount2++;
			newFlower = Instantiate (flower, new Vector3(GetComponent<Rigidbody> ().position.x,0,GetComponent<Rigidbody> ().position.z), flowerRotation) as GameObject;
		} else {
			if (other.gameObject.ToString () == "Cube 2 (UnityEngine.GameObject)" || other.gameObject.ToString () == "Cube 3 (UnityEngine.GameObject)" || other.gameObject.ToString () == "Cube 4 (UnityEngine.GameObject)" || other.gameObject.ToString () == "Cube 5 (UnityEngine.GameObject)") {
			}else{
				Destroy (gameObject);
			}
		}
	}
	// Update is called once per frame
	void Update () {
		
	}
}
