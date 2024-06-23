using UnityEngine;
using System.Collections;

public class gameController : MonoBehaviour {
	// Use this for initialization
	public GameObject car1;
	public GameObject car2;
	public static float wakeuptime;
	public static float starttime;
	public static int startFlag=0;
	public static int endFlag=0;
	public GameObject underfloor;
	public static int flowercount=0;
	public static int flowercount2=0;
	void Start () {
		startFlag=0;
		endFlag=0;
		car1.GetComponent<Rigidbody> ().constraints = RigidbodyConstraints.FreezeAll;
		car2.GetComponent<Rigidbody> ().constraints = RigidbodyConstraints.FreezeAll;
		wakeuptime = Time.time;
		starttime = 0;
		StartCoroutine (starting());
		StartCoroutine(ender());
		StartCoroutine(flooring());
	}	
	public static void resetFloor() {
		flowercount = 0;
		flowercount2 = 0;
	}
	public static int getflowercount() {
		return flowercount;
	}
	public static int getflowercount2() {
		return flowercount2;
	}

	IEnumerator starting(){
		yield return new WaitForSeconds(3);
		car1.GetComponent<Rigidbody> ().constraints = RigidbodyConstraints.FreezePositionY;
		car2.GetComponent<Rigidbody> ().constraints = RigidbodyConstraints.FreezePositionY;
		starttime = Time.time;
		startFlag = 1;
	}
	// Update is called once per frame
	IEnumerator ender () {
		yield return new WaitForSeconds(66);
		Application.LoadLevel("ender");
	}
	IEnumerator flooring(){
		yield return new WaitForSeconds(63);
		Debug.Log (flowercount);
		endFlag = 1;
	}
}
