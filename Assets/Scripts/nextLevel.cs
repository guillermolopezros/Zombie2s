using UnityEngine;
using System.Collections;

public class nextLevel : MonoBehaviour {
	
	public string nombreNivel = "scene1";// Nombre de la escena que vamos a cargar
	//public float tiempoEspera = 0.0f; // Tiempo que el Player tiene que estar para cargar
	
	bool cargando = false; // Controla si el player esta dentro del trigger
	
	void OnTriggerStay2D(Collider2D target){
		
		if (target.transform.tag == "Player") {
			Application.LoadLevel(nombreNivel);
			//if(!cargando) // Si no esta cargando empezamos la cuenta atras
			//	StartCoroutine(cargaNivel());
			
		}
	}
	
	//Si salimos del trigger cortamos la carga
	void OnTriggerExit2D(Collider2D target){
		cargando = false;
	}
	
	// Ejecutamos esto cuando entramos en el trigger
//	IEnumerator cargaNivel() {
//		cargando = true;
//		Debug.Log("Before Waiting 2 seconds");
//		yield return new WaitForSeconds(tiempoEspera); // Esperamos el tiempo definido
//		if(cargando) // Si sigue en el trigger cargamos la escena
//			Application.LoadLevel(nombreNivel);
//	}
}