using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

	public Transform target;
	private Animator anime;
	//private Rigidbody rb;

	public float speedMove;
	//public float turnRate;
	private int lockAxis = 0;
	//public float speedTarget;


	void Start () {

		anime = GetComponent<Animator>();
		target = GameObject.FindGameObjectWithTag("Target").transform;
		//rb = GetComponent<Rigidbody>();

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

		transform.rotation = Quaternion.Slerp (transform.rotation, Quaternion.LookRotation (target.position - transform.position), speedMove * Time.deltaTime); //rotaciona o Dino pro alvo
		transform.rotation = Quaternion.Euler(lockAxis, transform.rotation.eulerAngles.y, lockAxis); // anula os eixos XZ

		transform.position += transform.forward * speedMove * Time.deltaTime;
		anime.Play("Walk");
	}
		

}
