using System;
using UnityEngine;

namespace UnityStandardAssets.Utility
{
    public class CameraRefocus
    {
        public Camera Camera;
        public Vector3 Lookatpoint;
        public Transform Parent;

        private Vector3 m_OrigCameraPos;
        private bool m_Refocus;


        public CameraRefocus(Camera camera, Transform parent, Vector3 origCameraPos)
        {
            m_OrigCameraPos = origCameraPos;
            Camera = camera;
            Parent = parent;
        }


        public void ChangeCamera(Camera camera)
        {
            Camera = camera;
        }


        public void ChangeParent(Transform parent)
        {
            