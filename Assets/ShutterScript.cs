using UnityEngine;
using System.Collections;

public class ShutterScript : MonoBehaviour {

	public float shutterSpeed;
	private float newYPos;
	float shutterTimer;

	public float startYpos;
	public float targetYpos;
	bool goingDown;
	public int blinkCount;

    public GameObject mainCam;

	// Use this for initialization
	void Start () {
		goingDown = true;
	}
	
	// Update is called once per frame
	void Update () {

		shutterTimer += Time.deltaTime;
//
//		newYPos = Mathf.Lerp (newTransform.y, 0, shutterTimer/15 * shutterSpeed);
//		transform.localPosition = new Vector3(0, newYPos, 1);

		if(goingDown){
			newYPos = Mathf.Lerp (startYpos, targetYpos, shutterTimer/20 * shutterSpeed);
			transform.localPosition = new Vector3(0, newYPos, 1);
			if(transform.localPosition.y == targetYpos){
				blinkCount++;
				goingDown = false;
				shutterTimer = 0;
			}
            mainCam.GetComponent<AudioLowPassFilter>().cutoffFrequency = 22000f;
          
		} else if(!goingDown){
			newYPos = Mathf.Lerp (targetYpos, startYpos, shutterTimer/5 * shutterSpeed);
			transform.localPosition = new Vector3(0, newYPos, 1);
			if(transform.localPosition.y == startYpos){
				goingDown = true;
				shutterTimer = 0;
			}
            mainCam.GetComponent<AudioLowPassFilter>().cutoffFrequency = 420f;
           
		}

	}

}
