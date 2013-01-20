using UnityEngine;
using System.Collections;

public class ShipController : MonoBehaviour {
	public float verticalSpeed;
	public float horizontalSpeed;
	
	public Texture2D explosionTexture;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(0, verticalSpeed * Time.deltaTime, 0);
		
		
		transform.Translate(-horizontalSpeed * Time.deltaTime * Input.GetAxis("Horizontal"), 0, 0);
	}
	
	void OnTriggerEnter(Collider other) {
		verticalSpeed = 0;
		horizontalSpeed = 0;
		renderer.material.mainTexture = explosionTexture;
	}
}
