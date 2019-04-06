using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForcingBlock : MonoBehaviour {
    public Rigidbody2D Forcingrb;


    public float vel = -1;
    public float mass1 = 1;
    public float mass2 = 1;
    public float vel2 = 0;


    void Start () {
        Forcingrb =Forcingrb.GetComponent<Rigidbody2D>();
        Forcingrb.velocity = new Vector3(vel, 0, 0);
    }
	
	// Update is called once per frame
	void Update () {


    }
    void OnCollisionEnter2D(Collision2D hit)
    {
        //Debug.Log(hit);
        vel = ((2 * mass1) / mass1 + mass2) * vel + ((mass2 - mass1)/(mass1+ mass2)) * vel2;
    }
}
