using System;
using UnityEngine;


namespace UnityStandardAssets._2D
{
    public class CameraFollow : MonoBehaviour
    {
        public float xMargin = 1f; // Distance in the x axis the player can move before the camera follows.
        public float yMargin = 1f; // Distance in the y axis the player can move before the camera follows.
        public float xSmooth = 8f; // How smoothly the camera catches up with it's target movement in the x axis.
        public float ySmooth = 8f; // How smoothly the camera catches up with it's target movement in the y axis.
        public Vector2 maxXAndY; // The maximum x and y coordinates the camera can have.
        public Vector2 minXAndY; // The minimum x and y coordinates the camera can have.

        private Transform m_Player; // Reference to the player's transform.


        private void Awake()
        {
            // Setting up the reference.
            m_Player = GameObject.FindGameObjectWithTag("Play