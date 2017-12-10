using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pulse : MonoBehaviour {


	float rate = 0.5f;
	float maxScale = 1.2f;
	float minScale = 0.8f;

	void Update () {
		float scale = (Mathf.Sin(Time.time * (rate * 2 * Mathf.PI)) + 1) / 2;
		scale =  Mathf.Lerp (minScale, maxScale, scale);
		transform.localScale = new Vector3 (scale,scale,scale);
	}
}
