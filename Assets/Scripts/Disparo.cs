using UnityEngine;
using System.Collections;

public class Disparo : MonoBehaviour {

		
		
		public GameObject ammo;
		public Transform puntoDisparo;
		
		
		// Use this for initialization
		void Start () {
			
		}
		
		// Update is called once per frame
		void Update () {
			
		}
		
		public void Fire(){
			if (ammo != null) {
				var clone = Instantiate(ammo, puntoDisparo.position,
				                        Quaternion.identity) as GameObject;
				clone.transform.localScale = transform.localScale;
			}
		}
	}