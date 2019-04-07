using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Textscript : MonoBehaviour {

    public CounterBlock counterscript;
	void Start () {
		
	}

	void Update () {
        GetComponent<Text>().text = "" + counterscript.numberofhits;
	}
}
