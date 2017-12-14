using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour {
    
    private int numAttacks = 0;

    // Use this for initialization
    void Start () {

        //anime = Dino.GetComponent<Animator>;
    }

    public void BtAttack()
    {
        //Debug.Log("Attack");
        GameObject.Find("Dino AR [rig]").GetComponent<Animator>().SetTrigger("playerAttack");
        numAttacks++;
        //GameObject.Find("Dino AR [rig]").GetComponent<Animator>().Play("Attack");
    }

    IEnumerator Example()
    {
        yield return new WaitForSeconds(2);
        GameObject.Find("Teatro_Amazonas").SetActive(false);        
    }

    void Update()
    {
        if(numAttacks > 2)
        {
            StartCoroutine(Example());            
        }
    }
}
