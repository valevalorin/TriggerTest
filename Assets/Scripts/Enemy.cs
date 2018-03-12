using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public GameObject AttackGO;

	// Use this for initialization
	void Start () {
        StartCoroutine(Attack());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator Attack()
    {
        yield return new WaitForSeconds(0.5f);
        while (true)
        {
            AttackGO.SetActive(true);
            yield return new WaitForSeconds(1.0f);
            AttackGO.SetActive(false);
            yield return new WaitForSeconds(1.5f);
        }
    }


}
