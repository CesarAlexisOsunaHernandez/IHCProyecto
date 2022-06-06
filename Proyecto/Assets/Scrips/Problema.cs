using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Problema : MonoBehaviour
{
    public int[] input;
	
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P)){
			sumaMaxima(input);
		}
    }
	
	private void sumaMaxima(int[] arr){
		int[] aux = new int[arr.Length];
		int mayor = arr[0], suma;
		
		for(int i = 0; i < arr.Length; i++){
			for(int k = 0; k < arr.Length; k++){
				suma = 0;
				if(i + k + 1 < arr.Length){
					for(int j = k; j < i + k + 1; j++){
						aux[j] = arr[j];
						suma += aux[j];
					}
					if(mayor < suma){
						mayor = suma;
					}
				}
			}
        }
		Debug.Log("Maximo total: " + mayor);
	}
	
}
