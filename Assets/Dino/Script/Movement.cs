using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

	public Transform target;
	private Animator anime;

    private string hitobject;
    public bool andar = false;

	public float speedMove;
	public float turnRate;
	private int lockAxis = 0;

    public float tempo = 0;
	//public float speedTarget;


	void Start () {

		anime = GetComponent<Animator>();
		target = GameObject.FindGameObjectWithTag("Target").transform;

	}

	void Update () {

        if (tempo > 4 && tempo < 5)
        {
            andar = true;
            anime.SetTrigger("playerWalk");
        }

        if (tempo > 10)
        {            
            anime.SetTrigger("playerIdle");
            andar = false;
        }

        if (andar==true)
        {

            /*Vector3 targetPosition = new Vector3(target.transform.position.x,
                                        transform.position.y,
                                        target.transform.position.z);

            transform.LookAt(targetPosition);*/
            transform.position += transform.forward * speedMove * Time.deltaTime;
            //anime.Play("Walk");                        
        }
        else
        {
            //anime.SetTrigger("playerIdle");
        }

        tempo += Time.deltaTime;



        /*if (target) {
            StartCoroutine(Example());
            //Walk ();
			//Rotate ();
		} 
		else {
			anime.Play("Idle");
		}*/
    }

    /*IEnumerator Example()
    {
        yield return new WaitForSeconds(3);
        andar = true;
        //Walk();
    }*/

    /*void Walk(){

        //transform.Translate (Vector3.forward * speedMove * Time.deltaTime);

        //transform.rotation = Quaternion.Slerp (transform.rotation, Quaternion.LookRotation (target.position - transform.position), speedMove * Time.deltaTime);
        //transform.rotation = Quaternion.Euler(lockAxis, transform.rotation.eulerAngles.y, lockAxis);

        Vector3 targetPosition = new Vector3(target.transform.position.x,
                                                transform.position.y,
                                                target.transform.position.z);

        transform.LookAt(targetPosition);

        transform.position += transform.forward * speedMove * Time.deltaTime;
        andar = true;       

    }*/


    /*void Rotate(){

		Vector3 relativePos = (target.position + new Vector3 (0, 1.5f, 0)) - transform.position;
		Quaternion rotation = Quaternion.LookRotation (relativePos);

		Quaternion current = transform.localRotation;
		var rot = Quaternion.Slerp (current, rotation, Time.deltaTime);
		transform.localRotation;
	}*/

}
