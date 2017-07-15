using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileScript : MonoBehaviour {
	public int tileLen = 5;
	public bool DEBUG = true;
	public GameObject myBoxCollider2D;

	private GameObject resonanceTile = null;
	// Use this for initialization

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public GameObject getNearByTile(Vector2 coordination){
		//add checking the coordination later to make 
		//sure it is valid coord

		//detect
		BoxCollider2D detector = _MyBoxCollider();
		detector.offset = detector.offset + coordination;

		GameObject targetTile = resonanceTile;
		resonanceTile = null;
		return targetTile;
	}



	private BoxCollider2D _MyBoxCollider(){
		return gameObject.GetComponent<BoxCollider2D> ();
	}

	private void _logDebug(string msg){
		if (DEBUG) {
			Debug.Log (msg);
		}
	}

	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "tile") {
			resonanceTile = col.gameObject;
		}
	}
		

}
