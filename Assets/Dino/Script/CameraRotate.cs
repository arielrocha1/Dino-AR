using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotate : MonoBehaviour {

	public float mouseSensivity = 10;
	public Transform target;
	public float dstFromTarget;

	private float yaw;
	private float pitch;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		yaw += Input.GetAxis ("Mouse X") * mouseSensivity;
		pitch -= Input.GetAxis ("Mouse Y") * mouseSensivity;

		Vector3 targetRotation = new Vector3 (pitch, yaw);
		transform.eulerAngles = targetRotation;

		transform.position = target.position - transform.forward * dstFromTarget;

	}
}
