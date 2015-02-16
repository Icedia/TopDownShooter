using UnityEngine;
using System.Collections;

public class Explosion : TempObject {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		FadeExplosion ();
	}
	void FadeExplosion()
	{
		light.intensity -= lightFade;
	}
}
