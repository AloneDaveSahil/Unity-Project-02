using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obsticle_Move : MonoBehaviour {

	public float Speed;
	public float minX;
	public float maxX;
	public float minY;
	public float maxY;
	Vector2 terget_position;

	void start(){
		terget_position = getRandomPosition();
	}
	

	void FixedUpdate () {
		
		//if((Vector2)transform.position != terget_position){
			//transform.position = Vector2.MoveTowards (transform.position,terget_position,Speed*Time.deltaTime);
			transform.Translate (Vector2.down*Speed*Time.deltaTime);

		//}
		
	}
	Vector2 getRandomPosition(){
		float randomX = Random.Range (minX,maxX);
		float randomY = Random.Range (minY,maxY);
		return new Vector2 (randomX,randomY);
	}
}
