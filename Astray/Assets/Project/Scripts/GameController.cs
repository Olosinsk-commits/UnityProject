using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {
    public GameObject ball;
    public Player player;

    void Start() { }
	void Update () {
        if (player.isholdingBall == false)
        {
            Invoke("restart", 4);

        }
	}
    void restart()
    {
        SceneManager.LoadScene("Game");
    }

}
