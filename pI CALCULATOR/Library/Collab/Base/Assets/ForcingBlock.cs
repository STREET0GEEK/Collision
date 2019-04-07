using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForcingBlock : MonoBehaviour {
    public Rigidbody2D Forcingrb;
	// Use this for initialization
	void Start () {
        Forcingrb =Forcingrb.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        Forcingrb.velocity = new Vector3(-3, 0, 0);
	}
}
