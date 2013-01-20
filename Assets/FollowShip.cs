using UnityEngine;
using System.Collections;

public class FollowShip : MonoBehaviour {
	public Transform ship;
	private Vector3 offset;

	// Use this for initialization
	void Start () {
		offset = transform.position - ship.position;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = ship.position + offset;
	}
}
