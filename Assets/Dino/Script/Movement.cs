using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

	public Transform target;
	private Animator anime;

	public float speedMove;
	public float turnRate;
	private int lockAxis = 0;
	//public float speedTarget;


	void Start () {

		anime = GetComponent<Animator>();
		target = GameObject.FindGameObjectWithTag("Target").transform;

	}

	void Update () {

		if (target) {
			Walk ();
			//Rotate ();
		} 
		else {
			anime.Play("Idle");
		}
	}

	void Walk(){
		//transform.Translate (Vector3.forward * speedMove * Time.deltaTime);

		transform.rotation = Quaternion.Slerp (transform.rotation, Quaternion.LookRotation (target.position - transform.position), speedMove * Time.deltaTime);
		//transform.rotation = Quaternion.Euler(lockAxis, transform.rotation.eulerAngles.y, lockAxis);

		transform.position += transform.forward * speedMove * Time.deltaTime;
		anime.Play("Walk");
	}

	/*void Rotate(){

		Vector3 relativePos = (target.position + new Vector3 (0, 1.5f, 0)) - transform.position;
		Quaternion rotation = Quaternion.LookRotation (relativePos);

		Quaternion current = transform.localRotation;
		var rot = Quaternion.Slerp (current, rotation, Time.deltaTime);
		transform.localRotation;
	}*/

}
