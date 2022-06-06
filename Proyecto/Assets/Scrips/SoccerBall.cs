using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoccerBall : Interactable
{
    private Rigidbody rb;
	public Vector3 direction;
	public float KickForce = 10f;
	
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    /*// Update is called once per frame
    void Update()
    {
        
    }*/
	
	
	
	protected override void Interact(){
		base.Interact();
		
		rb.AddForce(direction * KickForce);
	}
}
