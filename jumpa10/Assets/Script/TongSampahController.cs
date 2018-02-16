using UnityEngine;
using System.Collections;

public class TongSampahController : MonoBehaviour {

	public float speed = 1.0f;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.A)){
			GoLeft ();
		}
		if (Input.GetKey (KeyCode.D)) {
			GoRight ();
		}
	}

	private void GoLeft() {
		transform.Translate (Vector3.left * speed * Time.deltaTime);
	}
	private void GoRight() {
		transform.Translate (Vector3.right * speed * Time.deltaTime);
	}
}
