using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_point : MonoBehaviour {

	public GameObject game_Obj;

	// Update is called once per frame
	void Start () {

		Instantiate (game_Obj,transform.position,Quaternion.identity);
		
	}
}
