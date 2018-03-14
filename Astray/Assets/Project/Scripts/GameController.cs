using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {
    public GameObject ball;//reference to the ball, set in editor
    public Player player;//reference to the player, set in editor

    void Start() { }
	void Update () {
        if (player.isholdingBall == false)
        {
            Invoke("restart", 4);

        }
	}
    //The restart method runs 4 seconds after the player lost the ball, restarting the game.
    void restart()
    {
        SceneManager.LoadScene("Game");
    }

}
