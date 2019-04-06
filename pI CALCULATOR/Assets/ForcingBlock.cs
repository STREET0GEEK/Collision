using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForcingBlock : MonoBehaviour {
    public Rigidbody2D Forcingrb;
    public CounterBlock counterscript;

    public float vel = 0;
    public float mass1 = 1;
    public float mass2 = 1;
    public float vel2 = -1;


    public float debugfloat;


    void Start () {

        debugfloat = (((2 * 1) / (1 + 1)) * 0) + (((1 - 1) / (1 + 1)) * -1);
        Debug.Log(debugfloat);
        Forcingrb =Forcingrb.GetComponent<Rigidbody2D>();
        Forcingrb.velocity = new Vector3(vel2, 0, 0);
    }

    void Update () {

        vel = counterscript.vel;

    }
    void OnCollisionEnter2D(Collision2D hit)
    {

        //Debug.Log(hit);
        mass1 = hit.collider.attachedRigidbody.mass;
        //vel = hit.collider.attachedRigidbody.velocity.magnitude;

        Debug.Log(new Vector4(mass1, mass2, vel, vel2));

        vel2 = (((2*mass1)/(mass1+mass2))*vel) + (((mass2-mass1)/(mass1+mass2))*vel2);

        Forcingrb.velocity = new Vector3(vel2, 0, 0);
        // Forcingrb.velocity = new Vector3(vel, 0, 0);
    }
}
