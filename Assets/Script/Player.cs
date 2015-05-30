using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	//public float p_pow = 1; 
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		float x = Input.GetAxis("Horizontal")* (Time.deltaTime + Time.deltaTime + Time.deltaTime);
		float z = Input.GetAxis ("Vertical")* (Time.deltaTime + Time.deltaTime + Time.deltaTime);
		transform.Translate (x, 0, z);
		//gameObject.GetComponent<Transform> ().AddFocre (x, 0, z);

		if (Input.GetKey(KeyCode.Space)) {
			transform.Translate (0,-0.05f, 0);

		}
	}
}
