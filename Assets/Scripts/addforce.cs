using UnityEngine;
using System.Collections;

public class addforce : MonoBehaviour {

	// Use this for initialization
	void Start () {
		this.rigidbody.AddForce(Vector3.back * 10);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
