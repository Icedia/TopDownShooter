using UnityEngine;
using System.Collections;

public class Enemy : Tank {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void DetermineTarget()
	{
		if (Player != null) {
			targetPos = Player.position + Vector3.up * 1.33f;
			base.Update ();
		}
	}
	void CheckIfSeesPlayer()
	{
		Ray myRay = new Ray ();
		myRay.origin = transform.position;
		myRay.direction = transform.forward;
		
		RaycastHit hitInfo;
		
		if (Physics.Raycast (myRay, out hitInfo, shootingRange)) 
		{
			string hitObjectName = hitInfo.collider.gameObject.name;
			if(hitObjectName == "Tank")
			{
				
				fireBullet();
				reloadTime = 0f;
			}
		}
	}

}
