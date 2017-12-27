using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour {

    public GameObject scoreObject;
    public ScoreManager scoreScript;

	// Use this for initialization
	void Start () {
        scoreObject = GameObject.Find("ScoreManager");
        scoreScript = scoreObject.GetComponent<ScoreManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("collect"))
        {
            scoreScript.BitCollected();
            StartCoroutine(BitSound());
            //Debug.Log("bit collected");
        }
    }

    IEnumerator BitSound()
    {
        Collider col = gameObject.GetComponent<Collider>();
        col.enabled = false;
        Renderer rend = gameObject.GetComponent<Renderer>();
        rend.enabled = false;
        gameObject.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(1.25f);
        Destroy(gameObject);
    }

}
