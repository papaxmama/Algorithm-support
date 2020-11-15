using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomColor : MonoBehaviour {

    Material material;

    // Use this for initialization
    void Start () {
	material = GetComponent<Renderer>().material;
	// setRandomRGB();
	setRGB(.5f, .5f, .5f);
    }

    private void setRandomRGB(){
	setRGB(UnityEngine.Random.value,
	       UnityEngine.Random.value,
	       UnityEngine.Random.value);
    }
    private void setRGB(float r, fl