using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	public GameObject[] Obsticle_part;
	private float time_betn_spawn;
	public float start_timer_btn_Spawn;
	public float decrese_time;
	public float min_time;
	// Update is called once per frame
	void FixedUpdate () {
		if (time_betn_spawn <= 0) {
			int rand = Random.Range (0, Obsticle_part.Length);
			Instantiate (Obsticle_part [rand], transform.position, Quaternion.identity);
			time_betn_spawn = start_timer_btn_Spawn;
			if (start_timer_btn_Spawn > min_time) {
				start_timer_btn_Spawn -= decrese_time;
			}
		} else {
			time_betn_spawn -= Time.deltaTime;
		}



		
	}
}
