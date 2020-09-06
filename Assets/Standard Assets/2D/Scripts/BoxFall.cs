using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FallingBoxes
{
	public class BoxFall : MonoBehaviour
	{

		private Vector2 baseVelocity = new Vector2 (0f, -4f);
		private Vector2 playerVelocity = new Vector2 (0f, -2.5f);

		public void Start ()
		{
			this.gameObject.GetComponent<Rigidbody