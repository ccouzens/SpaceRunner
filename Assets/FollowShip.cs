using UnityEngine;
using System.Collections;

public class FollowShip : MonoBehaviour {
	public Transform ship;
	private float height;

	// Use this for initialization
	void Start () {
		height = (transform.position - ship.position).z;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = ship.position + Vector3.forward * height;
	}
}
