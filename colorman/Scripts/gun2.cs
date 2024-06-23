using UnityEngine;
using System.Collections;
using System;
public class gun2 : MonoBehaviour {
	public GameObject seed;
	public GameObject nowSeed1;
	public GameObject nowSeed2;
	public GameObject nowSeed3;
	Vector3 offset;
	float nowAngle=0;
	// Update is called once per frame
	void Update () {
		float x = Input.GetAxisRaw ("P2H2");
		// 上・下
		float y = Input.GetAxisRaw ("P2V2");
		
		Vector3 direction;
		if(x==0&&y==0){
			transform.rotation = Quaternion.Euler(90, nowAngle, 0);
		}
		direction = new Vector3 (x,0,y);
		if(x!=0||y!=0){
			transform.rotation = Quaternion.Euler(90, (float)(Math.Atan2(direction.x,direction.z)*180/Math.PI), 0);
		}
		nowAngle=transform.eulerAngles.y;
	}
	void Shot(Vector3 vel)
	{
		Vector3 shotPosition1;
		Vector3 shotPosition2;
		Vector3 shotPosition3;
		System.Random rnd=new System.Random();
		if (gameController.startFlag==1&&gameController.endFlag==0) {
			Vector3 offsetPosition1=new Vector3((float)(rnd.NextDouble()*4),2,-(float)(rnd.NextDouble()*4));
			Vector3 offsetPosition2=new Vector3((float)(rnd.NextDouble()*4),5,(float)(rnd.NextDouble()*4));
			Vector3 offsetPosition3=new Vector3((float)(rnd.NextDouble()*4),7,(float)(rnd.NextDouble()*4));
			shotPosition1 = GetComponent<Rigidbody> ().position + offsetPosition1;
			shotPosition2 = GetComponent<Rigidbody> ().position + offsetPosition2;
			shotPosition3 = GetComponent<Rigidbody> ().position + offsetPosition3;
			nowSeed1 = Instantiate (seed, shotPosition1, new Quaternion (1, 1, 1, 0)) as GameObject;
			nowSeed2 = Instantiate (seed, shotPosition2, new Quaternion (1, 1, 1, 0)) as GameObject;
			nowSeed3 = Instantiate (seed, shotPosition3, new Quaternion (1, 1, 1, 0)) as GameObject;
			Vector3 lowVel = new Vector3 (vel.x * 30, vel.y * 30, vel.z * 30);
			nowSeed1.GetComponent<Rigidbody> ().AddForce (transform.up * 800 + lowVel, ForceMode.Impulse);
			nowSeed2.GetComponent<Rigidbody> ().AddForce (transform.up * 800 + lowVel, ForceMode.Impulse);
			nowSeed3.GetComponent<Rigidbody> ().AddForce (transform.up * 800 + lowVel, ForceMode.Impulse);
		}
	}
}