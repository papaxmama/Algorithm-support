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

		priva