using UnityEngine;
using System.Collections;

public class Player : Tank {
	public float rotationSpeed = 3f;
	public float moveSpeed = 0.3f;
	Rigidbody rb;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	protected override void Update () {
		FireOnClick ();
		base.Update ();
	}

	void FireOnClick ()
	{
		if (Input.GetButtonDown ("Fire1"))
		{
			fireBullet();
			
		}
	}
	void MovePlayer ();
	{
		if (Input.GetKey(KeyCode.UpArrow))
		{
			transform.Translate(Vector3.forward * moveSpeed);
			
		}
		if (Input.GetKey (KeyCode.DownArrow))
		{
			transform.Translate(-Vector3.forward * moveSpeed);
		}
		if (Input.GetKey (KeyCode.LeftArrow))
		{
			transform.Rotate(-Vector3.up * rotationSpeed);
		}
		if (Input.GetKey (KeyCode.RightArrow))
		{
			transform.Rotate(Vector3.up * rotationSpeed);
		}

	}
	void UndoVelocity ();
	{
		if (rb.velocity != Vector3.zero)
		{
			rb.velocity = Vector3.zero;
		}
		if (rb.angularVelocity != Vector3.zero)
		{
			rb.angularVelocity = Vector3.zero;
		}
	}
}
