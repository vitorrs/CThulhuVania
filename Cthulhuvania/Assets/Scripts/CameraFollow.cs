using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	public float speed = 0.15f;
	private Transform target;


	// Use this for initialization
	void Start () {

		target = GameObject.FindGameObjectWithTag ("Player").transform;

	}

	// Update is called once per frame
	void Update () {

		if (target) {
			transform.position = Vector3.Lerp (transform.position, target.position, speed) + new Vector3(0,0,-2);
		}
	}
}