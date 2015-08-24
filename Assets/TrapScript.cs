using UnityEngine;
using System.Collections;

public class TrapScript : MonoBehaviour {

    private float timer = 0f;
    public Transform player;
    public static int collectibleCount = 0;
    public GameObject coins;
    public GameObject lava;
    public GameObject spikes;
    public GameObject fire;
    private int randTrap = 0;

    public static float soundTimer = 0f;
    private bool createObj = false;
    public GameObject soundObj;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (player.eulerAngles.y > 0f && player.eulerAngles.y < 180f) //going east towards death anxiety
        {
            if(timer<10f)
            timer += Time.deltaTime;
            else
            {
                randTrap = Random.Range(0, 3);
                if(randTrap==0)
                {
                    Instantiate(lava, new Vector3(player.position.x + player.forward.x * 1f, -0.1f, player.position.z + player.forward.z * 1f), Quaternion.identity);
                }
                else if (randTrap == 1)
                {
                    Instantiate(spikes, new Vector3(player.position.x + player.forward.x * 1f, -0.22f, player.position.z + player.forward.z * 1f), Quaternion.identity);
                }
                else if (randTrap == 2)
                {
                    Instantiate(fire, new Vector3(player.position.x + player.forward.x * 1f, -0.59f, player.position.z + player.forward.z * 1f), Quaternion.identity);
                }
                timer = 0f;
            }
        }

        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            soundTimer += Time.deltaTime;
            createObj = true;
        }
        else
        {
            if(createObj)
            {
                Instantiate(soundObj, new Vector3(player.position.x + player.forward.x * 2f, -0.22f, player.position.z + player.forward.z * 2f), Quaternion.identity);
                createObj = false;
            }
           
        }

        if (player.eulerAngles.y > 90f && player.eulerAngles.y < 270f) //going south towards agon
        {
            if(timer<10f)
            timer += Time.deltaTime;
            else
            {
                Instantiate(coins, new Vector3(player.position.x + player.forward.x*1f, -0.1f, player.position.z + player.forward.z*1f), Quaternion.identity);
                timer = 0f;
            }
           // Debug.Log(timer);
        }
	
	}
}
