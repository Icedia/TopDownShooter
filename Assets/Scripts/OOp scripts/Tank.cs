using UnityEngine;
using System.Collections;

public class Tank : DestructableObject {
	protected Vector3 targetPos;
	private Transform[] transforms;
	protected Transform turret;
	protected Transform nozzel;
	private float reloadTime;
	public float timeToReload;
	// Use this for initialization
	void Start () {
		reloadTime = 0;
	}
	
	// Update is called once per frame
	protected virtual void Update () {
	
	}
	void findNozzleTurret()
	{
		transforms = gameObject.GetComponentsInChildren<Transform> ();
		foreach (Transform t in transforms)
		{
			if(t.gameObject.name == "turret")
			{
				turret = t;
			}
			if (t.gameObject.name == "nozzel")
			{
				nozzel = t;
			}
	}
	void aimTurret()
	{
		turret.LookAt ( targetPos );	
	}
	void reloadTimer()
	{
		reloadTime += Time.deltaTime;
		if (reloadTime >= timeToReload) 
		{
			CheckForPlayer();
		}
	}

	protected void fireBullet()
	{
		Instantiate(bulletPrefab, nozzel.position, nozzel.rotation);
	}
}
