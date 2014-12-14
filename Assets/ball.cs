using UnityEngine;
using System.Collections;

public class ball : MonoBehaviour {

	public bool touching;

	// Use this for initialization
	void Start () {
	
		rigidbody.velocity = new Vector3(1, 0, 1);
	}
	
	// Update is called once per frame
	void Update () {
				touching = Physics.Raycast (transform.position, Vector3.down, 0.5f);

				if (touching) {
	    
						if (Input.GetKeyDown (KeyCode.Space)) {

								
								rigidbody.velocity = new Vector3 (rigidbody.velocity.x, 5, rigidbody.velocity.z);
						}
						
						if (Input.GetKey (KeyCode.A) || Input.GetKey (KeyCode.LeftArrow)) {
								rigidbody.AddTorque (Vector3.left * 10);

						} else if (Input.GetKey (KeyCode.D) || Input.GetKey (KeyCode.RightArrow)) {
								rigidbody.AddTorque (Vector3.right * 10);
						}
						
						if (Input.GetKey (KeyCode.W) || Input.GetKey (KeyCode.UpArrow)) {
								rigidbody.AddTorque (Vector3.forward * 10);

						} else if (Input.GetKey (KeyCode.S) || Input.GetKey (KeyCode.DownArrow)) {
								rigidbody.AddTorque (Vector3.back * 10);

						}	
				}
		else {
				}
		}
	}
