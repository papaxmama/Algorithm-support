using System.Collections;
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
		//laserSound = GameObject.Find ("LaserHolder").GetComponent<AudioSource> ();
		laserBoxSound = GameObject.Find ("LaserBoxHolder").GetComponent<AudioSource> ();
		laserKillSound = GameObject.Find ("LaserKillHolder").GetComponent<AudioSource> ();

		//laserSound.clip.LoadAudioData ();
		laserBoxSound.clip.LoadAudioData ();
		laserKillSound.clip.LoadAudioData ();
		laserBoxSound.loop = true;
//		laserSound.loop = true;
//		laserSound.Play ();
	}
	 
	// Update is called once per frame
	void Update () {
		RaycastHit2D[] collisions = new RaycastHit2D[1];
		int numCollisions = c.Raycast (leftOrRight, collisions, Ma