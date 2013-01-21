using UnityEngine;
using System.Collections;

public class FollowShip : MonoBehaviour {
	public Transform ship;
	private Vector3 offset;
	private float horizontalPosition;

	// Use this for initialization
	void Start () {
		offset = transform.position - ship.position;
		horizontalPosition = ship.position.x;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 p = transform.position;
		p = ship.position + offset;
		p.x = horizontalPosition;
		transform.position = p;
	}
}
