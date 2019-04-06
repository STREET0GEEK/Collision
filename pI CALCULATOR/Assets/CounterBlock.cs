using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CounterBlock : MonoBehaviour {
    public Rigidbody2D Countingrb;

    public float vel = 0;
    public float mass1 = 1;
    public float mass2 = 1;
    public float vel2 = -1;

    void Start () {
        Countingrb = Countingrb.GetComponent<Rigidbody2D>();
    }
	
	void Update () {
        //Debug.Log(Countingrb.velocity);
	}
    void OnCollisionEnter2D(Collision2D hit)
    {
        vel = ((mass1 - mass2) / (mass1 + mass2)) * vel + ((2*mass2)/mass1 + mass2) * vel2;
        Countingrb.velocity = new Vector3(vel, 0, 0);
        Debug.Log(tag);
        //print("hellothere");
    }
}
