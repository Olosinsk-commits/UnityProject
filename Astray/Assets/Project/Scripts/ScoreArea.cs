using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreArea : MonoBehaviour {
    public Text countText;
    public Text winText;
    private int count;

    public GameObject effectObject;
    private GameController gameController;
    private void Start()
    {
        setEffect();
        count = 1;
        SetCountText();
    }

    public void setEffect()
    {
        effectObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider otherCollider)
    {
        if (otherCollider.GetComponent<Ball>() != null) {
            effectObject.SetActive(true);
            count = count + 1;
            SetCountText();
        }
    }

    void SetCountText()
    {
        countText.text = "Count: " + count;
    }
}
