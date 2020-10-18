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
		