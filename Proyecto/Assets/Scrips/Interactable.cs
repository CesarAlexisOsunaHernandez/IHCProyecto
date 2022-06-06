using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
	protected bool isInsideZone;
    void Start()
    {
        
    }

    void Update()
    {
        if(isInsideZone && Input.GetKeyDown(KeyCode.E)){
			Interact();
		}
    }
	
	protected virtual void OnTriggerEnter(Collider other){
		if(other.CompareTag("Player")){
			isInsideZone = true;
			//Debug.Log("Hola " + other.name);
		}
    }
	
	protected virtual void OnTriggerExit(Collider other){
		if(other.CompareTag("Player")){
			isInsideZone = false;
			//Debug.Log("Adios " + other.name);
		}
    }
	
	protected virtual void Interact(){
		Debug.Log("Interaccion");
	}
}
