using UnityEngine;
using System.Collections;
using System.Linq;

public class Win : MonoBehaviour {
	
	public Transform trigger1;
	public Transform trigger2;
	private int triggered = 0;
	private float winTime = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(winTime > 0 && Time.time > winTime + 2) Application.LoadLevel(0);
	}
	
	void OnTriggerEnter(Collider other){
		if(other.transform == trigger1 || other.transform == trigger2) {
			triggered++;
			if(triggered >= 2) {
				winTime = Time.time;
			}
		}
	}
}
