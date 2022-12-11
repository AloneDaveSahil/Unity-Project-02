using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

	public float speed;
	Rigidbody2D rb;
	public GameObject effect;
	public GameObject player;
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		
		
	}
	public void moveRight(){
		rb.velocity = new Vector2 (speed,0);
	}
	public void moveLeft(){
		rb.velocity = new Vector2 (-speed,0);
	}
	public void zeroVelocity(){
		rb.velocity = Vector2.zero;
	}
	void OnTriggerEnter2D(Collider2D other){
		if (other.CompareTag("obsticle")){
			Instantiate (effect,transform.position,Quaternion.identity);
			Destroy (player);
			Debug.Log ("hit");
		}

	}
}

