using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceChangerForClickBeetle : MonoBehaviour
{
	
  	private Rigidbody rb;
	private bool isJumping;

    void Start() {
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision otherObj) {
    	if (otherObj.gameObject.tag == "ground") {
    		isJumping = true;
    	}
    }

    private void OnCollisionExit(Collision otherObj) {
    	if (otherObj.gameObject.tag == "ground") {
    		isJumping = false;
    	}
    }

    void FixedUpdate() {
        if (isJumping == true) {
        	rb.AddForce(Vector3.up *  Random.Range(5f, 50f));
        }
    }
}
