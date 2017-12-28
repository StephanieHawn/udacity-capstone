using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MotherboardLaunch : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("collect"))
        {
            //add code to launch new scene into space cockpit
            SceneManager.LoadScene("Spaceship");
            StartCoroutine(BitSound());
            //Debug.Log("motherboard collected");
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
