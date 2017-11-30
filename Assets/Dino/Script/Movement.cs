using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

	public Transform target;
	public Transform myTransform;
	private Animator anime;

	public float speedMove;
	//public float speedTarget;


	void Start () {

		anime = GetComponent<Animator>();
		target = GameObject.FindGameObjectWithTag("Target").transform;

	}

	void Update () {

		if (target) {
			walk ();
		} 
		else {
			anime.Play("Idle");
		}
	}

	void walk(){
		//transform.Translate (Vector3.forward * speedMove * Time.deltaTime);

		transform.rotation = Quaternion.Slerp (transform.rotation, Quaternion.LookRotation (target.position - transform.position), speedMove * Time.deltaTime);

		transform.position += transform.forward * speedMove * Time.deltaTime;
		anime.Play("Walk");
	}
}

