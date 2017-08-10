using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardManager : MonoBehaviour {

	public GameObject currentTile;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		GameObject nearTile = currentTile.GetComponent<TileScript> ().getNearByTile (new Vector2(1, 0));
		if (nearTile != null) {
			float alpha = nearTile.GetComponent<SpriteRenderer> ().color.a;
			nearTile.GetComponent<SpriteRenderer> ().color.a = ((alpha + 1.0f) % 255);
		}
	}


	public GameObject getCurrentTile() {
		return currentTile; 
	}
}
