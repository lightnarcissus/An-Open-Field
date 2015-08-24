using UnityEngine;
using System.Collections;

public class DestroyScript : MonoBehaviour {

	// Use this for initialization
    private float timer = 0f;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if(timer<10f)
        {
            timer += Time.deltaTime;
        }
        else
        {
            Destroy(gameObject);    
        }

        
	
	}

   
}
