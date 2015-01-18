using UnityEngine;
using System.Collections;

public class BaseRotateTurret : MonoBehaviour {

	private Transform[] transforms;
	protected Transform turret;
	protected Transform nozzel;
	protected Vector3 targetPos;
	// Use this for initialization
	protected virtual void Start () {
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
	}
	// Update is called once per frame
	protected virtual void Update () {
		turret.LookAt ( targetPos );
	}
}
