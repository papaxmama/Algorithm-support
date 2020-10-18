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
		private