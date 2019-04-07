using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CounterBlock : MonoBehaviour {
    public Rigidbody2D Countingrb;
    public ForcingBlock forcingscript;

    public float numberofhits;


    public float vel = 0;
    public float mass1 = 1;
    public float mass2 = 1;
    public float vel2 = -1;

    public float repeats = 50;


    void Start () {
        repeats = forcingscript.repeats;
        Countingrb = Countingrb.GetComponent<Rigidbody2D>();
        Countingrb.mass = mass1;
    }
	
	void Update () {
            vel2 = forcingscript.vel2;
            mass2 = forcingscript.mass2;
	}

    void OnCollisionEnter2D(Collision2D hit)
    {

        mass2 = hit.collider.attachedRigidbody.mass;

        if (hit.collider.tag != "Wall")
        {
            vel = ((mass1 - mass2) / (mass1 + mass2)) * vel + ((2 * mass2) / (mass1 + mass2)) * vel2;
            Countingrb.velocity = new Vector3(vel, 0, 0);
        }
        else
        {

            //Vector3 velo = new Vector3(vel * -1, 0, 0);
            vel *= -1;
            Countingrb.velocity = new Vector2(vel, 0);
        }
        numberofhits++;
    }

}
