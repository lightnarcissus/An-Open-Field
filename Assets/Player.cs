using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public static int activeCam = 0;
    public static GameObject currentCam;
    public static int currentInt = 0;
    public GameObject childCam;
    public GameObject manager;
	// Use this for initialization
	void Start () {

        GetComponent<AudioSource>().enabled = false;
      //  play1.GetComponent<CharacterController>().enabled = false;
      
       // play2.GetComponent<CharacterController>().enabled = false;
	
	}
	
	// Update is called once per frame
	void Update () {

       
       // Debug.Log("The new cam will be:" + activeCam);
       // Debug.Log("The current ca is:" + currentInt);
        if (Input.GetKeyDown(KeyCode.Q))
            activeCam = 0;
        if (Input.GetKeyDown(KeyCode.E))
            activeCam = 1;
        if (Input.GetKeyDown(KeyCode.R))
            activeCam = 2;
        
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(activeCam==0)
            {
                if(currentInt==1)
                {
                   // Debug.Log("Switch from 1 to 0");
                    manager.SendMessage("DoFade10");
               /*     if (this.gameObject.tag == "0")
                    {
                        Debug.Log("Char0 active");
                        this.gameObject.GetComponent<CharacterController>().enabled = true;
                    }
                    else
                        this.gameObject.GetComponent<CharacterController>().enabled = false;*/
                }
                if (currentInt == 2)
                {
                    manager.SendMessage("DoFade20");
                   /*  if (this.gameObject.tag == "0")
                    {
                        Debug.Log("Char0 active");
                        this.gameObject.GetComponent<CharacterController>().enabled = true;
                    }
                    else
                        this.gameObject.GetComponent<CharacterController>().enabled = false;*/
                }
                    currentCam = childCam;
                    currentInt = 0; 
            }
            if(activeCam==1)
            {
                if (currentInt == 0)
                {
                     //Debug.Log("Running in:" + gameObject.name);
                    Debug.Log("Switch from 0 to 1");
                    manager.SendMessage("DoFade01");
                
               /*      if (this.gameObject.tag == "1")
                    {
                        Debug.Log("Char1 active");
                        this.gameObject.GetComponent<CharacterController>().enabled = true;
                    }
                    else
                        this.gameObject.GetComponent<CharacterController>().enabled = false;*/
                }
                if (currentInt == 2)
                {
                    manager.SendMessage("DoFade21");
                  /*   if (this.gameObject.name == "1")
                    {
                        this.gameObject.GetComponent<CharacterController>().enabled = true;
                    }
                    else
                        this.gameObject.GetComponent<CharacterController>().enabled = false;*/
                }
                    currentCam = childCam;
                    currentInt = 1;

            }
            if (activeCam == 2)
            {
                if (currentInt == 0)
                {
                    manager.SendMessage("DoFade02");
                   /*  if (this.gameObject.name == "2")
                    {
                      this.gameObject.GetComponent<CharacterController>().enabled = true;
                    }
                    else
                        this.gameObject.GetComponent<CharacterController>().enabled = false;*/
                }
                if (currentInt == 1)
                {
                    manager.SendMessage("DoFade12");
                  /*   if (this.gameObject.name == "2")
                    {
                        this.gameObject.GetComponent<CharacterController>().enabled = true;
                    }
                    else
                        this.gameObject.GetComponent<CharacterController>().enabled = false;*/
                }
                    currentCam = childCam;
                    currentInt = 2;

            }

        }

        if(Input.GetKey(KeyCode.W) ||Input.GetKey(KeyCode.A)||Input.GetKey(KeyCode.S)||Input.GetKey(KeyCode.D)||Input.GetKey(KeyCode.UpArrow)||Input.GetKey(KeyCode.DownArrow)||Input.GetKey(KeyCode.LeftArrow)||Input.GetKey(KeyCode.RightArrow))
        {
            GetComponent<AudioSource>().enabled=true;
        }
        else
        {
            GetComponent<AudioSource>().enabled = false;
        }

        /*    if(Random.value<0.05) //Death Sequence Start
            {

            }
        */
	}
}
