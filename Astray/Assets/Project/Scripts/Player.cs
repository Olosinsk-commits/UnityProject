using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour {

    public Ball ball;
    public GameObject playerCamera;
    public float distanceToBall = 2f;
    public float ballThrowingForce = 5f;



    private Rigidbody rb;
    public bool isholdingBall=true;
    // Use this for initialization
    public void Start () {
        isholdingBall = true;
        ball.GetComponent<Rigidbody>().useGravity = false;
    }
	
	// Update is called once per frame
	public void FixedUpdate() {
        if (isholdingBall) { 
        ball.transform.position = playerCamera.transform.position + playerCamera.transform.forward* distanceToBall;
            if (Input.GetMouseButtonDown(0)) {
                isholdingBall = false;
                ball.ActivateTrail();
                ball.GetComponent<Rigidbody>().useGravity = true;
                ball.GetComponent<Rigidbody>().AddForce(playerCamera.transform.forward*ballThrowingForce);
            }
        }
    }
}
