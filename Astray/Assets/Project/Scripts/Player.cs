using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour {
    // Declaration variables and initialion.  
    public Ball ball;//reference to the ball, set in editor
    public GameObject playerCamera;
    public float distanceToBall = 2f;
    public float ballThrowingForce = 5f;

    //Rigidbodies enable my GameObjects to act under the control of physics. 
    //Any GameObject must contain a Rigidbody to be influenced by gravity, 
    //act under added forces via scripting, or interact with other objects through the NVIDIA PhysX physics engine.
    private Rigidbody rb;
    //boolean variable 
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
            //The basketball is thrown when the player clicked the mouse button. 
            if (Input.GetMouseButtonDown(0)) {
                isholdingBall = false;
                ball.ActivateTrail();
                ball.GetComponent<Rigidbody>().useGravity = true;
                ball.GetComponent<Rigidbody>().AddForce(playerCamera.transform.forward*ballThrowingForce);
            }
        }
    }
}
