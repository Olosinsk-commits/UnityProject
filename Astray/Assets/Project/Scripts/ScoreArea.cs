using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreArea : MonoBehaviour
{
    public Text countText;//reference to the ScoreText gameobject, set in editor
    public Text winText;
    private string winT;

    public GameObject effectObject;
    private GameController gameController;
    private void Start()
    {
        setEffect();
        winT = "";
        SetCountText();
    }

    public void setEffect()
    {
        effectObject.SetActive(false);
    }

    //OnTriggerEnter is called when the Collider other enters the trigger.
    private void OnTriggerEnter(Collider otherCollider) //if ball hits basket collider
    {
        if (otherCollider.GetComponent<Ball>() != null)
        {
            effectObject.SetActive(true);
            winT = "Goal!";
            SetCountText();
        }
    }

    void SetCountText()
    {
        countText.text = winT;
    }
}
