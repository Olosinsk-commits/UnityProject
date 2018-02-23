using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {
    // public UnityEngine.UI.Text scoreText;
    public GameObject ball;
    //public GameObject pl;
    //public ScoreArea sc;
    private GameObject ballClone;
   // private GameObject playerClone;
    public Player player;
    public Vector3 ballPos;
    GameObject go;
    void Start() { }
	void Update () {
        if (player.holdingBall == false)
        {
            Invoke("restart", 3);

        }
	}
    private Vector3 throwSpeed = new Vector3(0, 26, 40);
    void restart()
    {
        //sc.setEffect();
        player.holdingBall = true;
        //ball = new GameObject();
       // Destroy(ball);
       // ballClone = Instantiate(ball, ballPos, transform.rotation) as GameObject;
        // Destroy(ball);
        //Destroy(pl);
        //ballClone = Instantiate(ball, ballPos, transform.rotation) as GameObject;
        //player.holdingBall = true;
        //playerClone = Instantiate(pl, transform.position, transform.rotation) as GameObject;
        SceneManager.LoadScene("Game");
    }

}
