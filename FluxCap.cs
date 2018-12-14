using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FluxCap : MonoBehaviour {

    
    //public Transform obj;
    public float rotateSpeed = 4;
    public GameObject flux;
    
    // Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
     transform.Rotate(0, rotateSpeed, 0, Space.World);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            HUD script = other.GetComponent<HUD>();
            if (script != null)
            {
                script.partFound();
                Destroy(gameObject);
            }
        }
        //GetComponent<HUD>().partFound();


    }      
}

