using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

namespace FallingBoxes
{
	[RequireComponent (typeof(MainCharacter))]
	public class Inputer : MonoBehaviour
	{

		private MainCharacter m_Character;
		private bool m_Jump;

		private void Awake ()
		{
			m_Character = GetComponent<MainCharacter> ();
		}


		private void Update ()
		{
			if (!m_Jump) {
				// Read the jump input in Update so button presses aren't missed.
				m_Jump = CrossPlatformInputManager.GetButtonDown ("Jump");
			}

			if (CrossPlatformInputManager.GetButto