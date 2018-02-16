using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DestroyBox : MonoBehaviour {
	public GameObject enemy;

	void OnTriggerEnter(Collider other)
	{
		switch(other.gameObject.tag)
		{
		case "tongSampah":
			Destroy (this.gameObject);
			Score.UpdateScore (1);
			Debug.Log ("Masuk");
			break;
		case "Plan":
			Destroy (this.gameObject);
			Debug.Log ("Tidak Masuk");
			break;
		}


	}


}
