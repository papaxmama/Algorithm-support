﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LaserRayCast : MonoBehaviour {

	// Use this for initialization
	private Collider2D c;
	public CustomImageEffect cam;
	private Vector2 source;
	private Vector2 leftOrRight;
	private int prevNumCollisions = 0;
	//public AudioSource laserSound;
	public AudioSource laserBoxSound;
	public AudioSource laserKillSound;
	public GameObject deathParticles;
	public GameObject miniLasers;

	void Start () {
		c = GetComponent<Collider2D> ();
		cam = GameObject.Find ("Main Camera").GetComponent<CustomImageEffect> ();
		source = new Vector2(transform.position.x, transform.position.y);
		bool pointLeft = gameObject.transform.position.x > 0;
		leftOrRight = pointLeft ? Vector2.left : Vector2.right; 
		//laserSound = GameObject.F