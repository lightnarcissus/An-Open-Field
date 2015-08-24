using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class MemoryScript : MonoBehaviour {

    public Vector3 originalPos;
    private int randRelic = 0;
    public List<GameObject> relics;
    public GameObject mainRelic;
    private float timer = 0f;
    private float currentDistance = 0f;
	// Use this for initialization
	void Start () {

        originalPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {

      //  if (transform.position.z > 100f && (transform.position.x <50f && transform.position.y < 50f))
        if(currentDistance>=250f)
        {
            transform.position = new Vector3(originalPos.x-30f,originalPos.y,originalPos.z-20f);
            randRelic = Random.Range(0, relics.Count);
            relics[randRelic].SetActive(true);
            relics.Remove(relics[randRelic]);
            currentDistance = 0f;
        }

        if(timer<2f)
        {
            timer += Time.deltaTime;
        }
        else
        {
            
            currentDistance = Vector3.Distance(transform.position, mainRelic.transform.position);
           // Debug.Log(currentDistance);
            timer = 0f;
        }
	
	}

  
}
