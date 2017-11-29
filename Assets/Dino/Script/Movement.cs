using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

	//public Transform target;
	public Transform myTransform;
	private Animator anime;

	public float speedMove;
	//public float speedTarget;


	void Start () {
		anime = GetComponent<Animator>();
	}

	void Update () {

		//direção e distância da transalção
		//transform.Translate (Vector3.forward * speedMove * Time.deltaTime);
		//transform.Translate (Vector3.up * Time.deltaTime, Space.World);

		//x com o eixo dos x, y com o eixo dos y, z com o eixo dos z
		//transform.Translate (0, 0, Time.deltaTime);
		//transform.Translate (0, Time.deltaTime, 0, Space.World);

		//direção e distância da transalção
		//transform.Translate (Vector3.right * Time.deltaTime, Camera.main.transform);

		//x com o eixo dos x, y com o eixo dos y, z com o eixo dos z
		//transform.Translate (Time.deltaTime, 0, 0, Camera.main.transform);

		//transform.LookAt (target);
		transform.Translate (Vector3.forward * speedMove * Time.deltaTime);
		anime.SetTrigger("Andando");
	}
}
