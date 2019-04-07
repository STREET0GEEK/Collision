using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForcingBlock : MonoBehaviour {
    public Rigidbody2D Forcingrb;
    public CounterBlock counterscript;
    public float repeats = 10;

    public float vel = 0;
    public float mass1 = 1;
    public float mass2 = 100000;
    public float vel2 = -1;



    public float debugfloat;


    void Start () {
        //vel2 = vel2 / repeats;
        //debugfloat = (((2 * 1) / (1 + 1)) * 0) + (((1 - 1) / (1 + 1)) * -1);
        //Debug.Log(debugfloat);
        Forcingrb = Forcingrb.GetComponent<Rigidbody2D>();
        Forcingrb.velocity = new Vector3(vel2, 0, 0);
        Forcingrb.mass = mass2;

    }

    void Update () {
            vel = counterscript.vel;
            mass1 = counterscript.mass1;

    }
    void OnCollisionEnter2D(Collision2D hit)
    {
       // for (int i = 10; i <= 10; i++)
       // {
            mass1 = hit.collider.attachedRigidbody.mass;
            vel2 = (((2 * mass1) / (mass1 + mass2)) * vel) + (((mass2 - mass1) / (mass1 + mass2)) * vel2);
            Forcingrb.velocity = new Vector3(vel2, 0, 0);
       // }
    }
}
