using UnityEngine;
using System.Collections;

public class wind : MonoBehaviour {
	
	private Vector3 Direction = Vector3.back * 10;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerStay(Collider other){
		if(other.rigidbody) {
			other.rigidbody.velocity = Direction;
		}
	}
}
