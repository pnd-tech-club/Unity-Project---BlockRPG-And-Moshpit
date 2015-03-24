using UnityEngine;
using System.Collections;

public class HitMarkerOverflowScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


		Destroy(gameObject, 1); // 1sec
	}
}
