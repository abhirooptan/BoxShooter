using UnityEngine;
using System.Collections;

public class BasicController : MonoBehaviour {

	public float moveSpeed = 3.0f;
	public float gravity = 9.81f;

	private CharacterController controller;

	// Use this for initialization
	void Start () {
		controller = gameObject.GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 movementZ = Input.GetAxis ("Vertical") * Vector3.forward * moveSpeed * Time.deltaTime;

		Vector3 movementX = Input.GetAxis ("Horizontal") * Vector3.right * moveSpeed * Time.deltaTime;

		Vector3 movement = transform.TransformDirection (movementX + movementZ);

		movement.y -= gravity * Time.deltaTime;

		controller.Move (movement);
	}
}
