using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityStandardAssets.Utility
{
    public class ObjectResetter : MonoBehaviour
    {
        private Vector3 originalPosition;
        private Quaternion originalRotation;
        private List<Transform> originalStructure;

        private Rigidbody Rigidbody;

        // Use this for initialization
        private void Start()
        {
            originalStructure = new List<Transform>(GetComponentsInChildren<Transform>());
            originalPosition = transform.position;
           