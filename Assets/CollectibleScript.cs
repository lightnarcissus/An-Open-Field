using UnityEngine;
using System.Collections;

public class CollectibleScript : MonoBehaviour {

    public GameObject coinSound;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnControllerColliderHit(ControllerColliderHit col)
    {
      //  Debug.Log("IN HERE");
        if(col.gameObject.tag=="Coins")
        {
            //Debug.Log("Recognized 0");
            TrapScript.collectibleCount++;
            coinSound.GetComponent<AudioSource>().Play();
            Destroy(col.transform.parent.gameObject);
        }
        else if (col.gameObject.tag == "Trap")
        {
            Destroy(col.transform.parent.gameObject);
        }
    }
}
