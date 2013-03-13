using UnityEngine;
using System.Collections;

public class pushbutton : MonoBehaviour {
	
	public Transform Other;
	public GameObject TheLight;
	public Transform ToUp;
	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}
	
	void OnTriggerEnter(Collider other){
		if(other.transform == Other){
			iTween.MoveBy(this.transform.parent.gameObject, iTween.Hash(
				"amount", Vector3.down,
				"oncomplete", "Appear",
				"oncompletetarget", this.gameObject));
		}
	}
	
	void Appear() {
		this.TheLight.SetActive(true);
		iTween.MoveBy(ToUp.gameObject, iTween.Hash(
				"amount", Vector3.up * 5));
	}
				
}
