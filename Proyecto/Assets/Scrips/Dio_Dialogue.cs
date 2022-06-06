using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dio_Dialogue : Interactable
{
    public GameObject HoCorto;
	public GameObject HoDoble;
	public GameObject Pelea;
	public GameObject Dialogo1;
	public GameObject Dialogo2;
	public GameObject Dialogo3;
	private bool isClose, isCloser;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && isCloser){
			Instantiate(Pelea);
		}
    }
	
	protected override void OnTriggerEnter(Collider other){
		base.OnTriggerEnter(other);
		if(other.CompareTag("Player") && !isClose && !isCloser){
			isCloser = false;
			isClose = true;
			if(Dialogo1 != null){
				Dialogo1.SetActive(true);
			}
			if(Dialogo2 != null){
				Dialogo2.SetActive(false);
			}
			if(Dialogo3 != null){
				Dialogo3.SetActive(false);
			}
			Instantiate(HoCorto);
		}
		else if(other.CompareTag("Player") && isClose && !isCloser){
			isCloser = true;
			isClose = false;
			Instantiate(HoDoble);
			if(Dialogo1 != null){
				Dialogo1.SetActive(false);
			}
			if(Dialogo2 != null){
				Dialogo2.SetActive(true);
			}
			if(Dialogo3 != null){
				Dialogo3.SetActive(false);
			}
		}
		else if(other.CompareTag("Player") && !isClose && isCloser){
			if(Dialogo1 != null){
				Dialogo1.SetActive(false);
			}
			if(Dialogo2 != null){
				Dialogo2.SetActive(false);
			}
			if(Dialogo3 != null){
				Dialogo3.SetActive(true);
			}
		}
	}
	
	protected override void OnTriggerExit(Collider other){
		base.OnTriggerExit(other);
		if(other.CompareTag("Player")){
			isCloser = false;
		}
    }
}
