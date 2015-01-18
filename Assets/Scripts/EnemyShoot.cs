using UnityEngine;
using System.Collections;

public class EnemyShoot : MonoBehaviour {
	private float reloadTime;
	public float timeToReload;
	public GameObject bulletPrefab;
	public float shootingRange;
	private Transform turret;
	private Transform nozzel;
	// Use this for initialization
	void Start () {
		reloadTime = 0;

		Transform[] transforms = this.gameObject.GetComponentInChildren<Transform> ();
		foreach (Transform t in transforms) 
		{
			if(t.gameObject.name == "turret")
			{
					turret = t;
			}
			if(t.gameObject.name == "nozzel")
			{
				nozzel = t;
			}
		}
	
	}
	
	// Update is called once per frame
	void Update () {
		reloadTime += Time.deltaTime;
		if (reloadTime >= timeToReload) 
		{
			CheckForPlayer();
		}
	
	}
	private void CheckForPlayer()
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
				Instantiate(bulletPrefab, nozzel.position, nozzelrotation);

				reloadTime = 0f;
			}
		}

	}
}
