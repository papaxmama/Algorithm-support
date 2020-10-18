using UnityEngine;
using UnityEngine.UI;

namespace FallingBoxes
{

	public class GameManager : MonoBehaviour
	{

		public GameObject box;
		public GameObject platformPiece;
		public GameObject character;
		public GameObject laser;
		public GameObject motivationArrow;
		private Transform gameManager;
		private int boxSpawnPeriodicity = 400;
		private int laserSpawnPeriodicity = 50;
		private static float maxHeightReached = 0f;
		private int boxSpawnOffset = 40;
		private int boxSpawnVariance = 0;
		// public float minGravity = 0.75f;
		// public float maxGravity = 1.25f;
		private int difficulty = 1;
		private int highestDifficulty = 1;
		private int numLasers = 0;
		private int boxDeltaX = 10;
		private int laserDeltaX = 14;
		public int maxTotalLasers = 5;
		private int minArea = 2;

		void Awake ()
		{
			InitGame ();
		}

		// Update is called once per frame
		void Update ()
		{
			difficulty = ((int)Mathf.Abs (character.trans