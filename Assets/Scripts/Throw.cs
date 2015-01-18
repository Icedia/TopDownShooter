using UnityEngine;
using System.Collections;

public class Throw : MonoBehaviour {
	public GameObject bulletPrefab;
	private GameObject nozzel;
	private GameObject turret;
	// Use this for initialization
	void Start () {
		Transform[] transforms = GetComponentsInChildren<Transform> ();
		foreach (Transform t in transforms)
		{
			if(t.gameObject.name == "turret")
			{
				turret = t.gameObject;
			}
			if (t.gameObject.name == "nozzel")
			{
				nozzel = t.gameObject;
			}
			
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire1"))
		{
			Instantiate(bulletPrefab, nozzel.transform.position, turret.transform.rotation);

		}
	
	}
}
