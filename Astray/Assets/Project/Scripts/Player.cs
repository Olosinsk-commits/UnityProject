using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour {

    public Ball ball;
    public GameObject playerCamera;
    public float ballDistance = 2f;
    public float ballThrowingForce = 5f;



    private Rigidbody rb;
    public bool holdingBall=true;
    // Use this for initialization
    public void Start () {
        holdingBall = true;
        ball.GetComponent<Rigidbody>().useGravity = false;
    }
	
	// Update is called once per frame
	public void FixedUpdate() {
        if (holdingBall) { 
        ball.transform.position = playerCamera.transform.position + playerCamera.transform.forward* ballDistance;
            if (Input.GetMouseButtonDown(0)) {
                holdingBall = false;
                ball.ActivateTrail();
                ball.GetComponent<Rigidbody>().useGravity = true;
                ball.GetComponent<Rigidbody>().AddForce(playerCamera.transform.forward*ballThrowingForce);
            }
        }
    }
}
