using UnityEngine;
using System.Collections;

public class SoundObjectScript : MonoBehaviour {

    private float timer = 0f;
    public AudioClip clip;
    private GameObject player;
    private float factor = 0f;
    private float endTimer = 0f;
	// Use this for initialization
	void OnEnable () {
        endTimer = TrapScript.soundTimer;
        factor = 1f / endTimer;
        
        TrapScript.soundTimer = 0f;
        GetComponent<AudioSource>().clip = clip;
        GetComponent<AudioSource>().Play();
        player = GameObject.Find("0");
        
	}
	
	// Update is called once per frame
	void Update () {

        timer += Time.deltaTime;
        transform.position = Vector3.Lerp(transform.position, player.transform.position, timer * factor);
        if(timer>endTimer)
        {  
            Destroy(gameObject);
        }
	}
}
