using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider col)
    {
        Debug.Log("OnTriggerEnter");
        Debug.Log("I AM: " + gameObject.ToString());
        Debug.Log("I COLLIDED WITH: " + col.gameObject.ToString());
    }
}
