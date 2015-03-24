using UnityEngine;
using System.Collections;

public class HitmarkerHealthScript : MonoBehaviour {

	public int hp = 0;
	

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (hp <= 0)
		{
			Destroy(gameObject,1);
			
		}
	}
}
