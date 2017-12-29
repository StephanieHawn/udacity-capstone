using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    public int i = 0;
    public Text countScore;
    public GameObject computerChip;


	// Use this for initialization
	void Start () {
        i = 0;

        print(i);
        BitTextCount();
	}
	
	// Update is called once per frame
	void Update () {
        if (i >= 5)
        {
            computerChip.SetActive(true);
        }
	}

    public void BitCollected()
    {
        //i++;
        i = i + 1;
        print("i =" + i);
        BitTextCount();
    }

    public void BitTextCount()
    {
        countScore.text = "Collected " + i.ToString() + "/5 Computer Bits";
    }
}
