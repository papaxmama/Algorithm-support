
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif

namespace UnityStandardAssets.Utility
{
    public class TimedObjectActivator : MonoBehaviour
    {
        public enum Action
        {
            Activate,
            Deactivate,
            Destroy,
            ReloadLevel,
            Call,
        }


        [Serializable]
        public class Entry
        {
            public GameObject target;
            public Action action;
            public float delay;
        }


        [Serializable]
        public class Entries
        {
            public Entry[] entries;
        }
        
        
        public Entries entries = new Entries();

        
        private void Awake()
        {
            foreach (Entry entry in entries.entries)
            {
                switch (entry.action)
                {
                    case Action.Activate:
                        StartCoroutine(Activate(entry));
                        break;
                    case Action.Deactivate:
                        StartCoroutine(Deactivate(entry));
                        break;
                    case Action.Destroy:
                        Destroy(entry.target, entry.delay);
                        break;

                    case Action.ReloadLevel:
                        StartCoroutine(ReloadLevel(entry));
                        break;
                }
            }
        }


        private IEnumerator Activate(Entry entry)
        {
            yield return new WaitForSeconds(entry.delay);
            entry.target.SetActive(true);
        }


        private IEnumerator Deactivate(Entry entry)
        {
            yield return new WaitForSeconds(entry.delay);
            entry.target.SetActive(false);
        }


        private IEnumerator ReloadLevel(Entry entry)
        {
            yield return new WaitForSeconds(entry.delay);
            SceneManager.LoadScene(SceneManager.GetSceneAt(0).name);
        }
    }
}


namespace UnityStandardAssets.Utility.Inspector
{
#if UNITY_EDITOR
    [CustomPropertyDrawer(typeof (TimedObjectActivator.Entries))]
    public class EntriesDrawer : PropertyDrawer
    {
        private const float k_LineHeight = 18;
        private const float k_Spacing = 4;


        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            EditorGUI.BeginProperty(position, label, property);

            float x = position.x;
            float y = position.y;
            float width = position.width;

            // Draw label
            EditorGUI.PrefixLabel(position, GUIUtility.GetControlID(FocusType.Passive), label);

            // Don't make child fields be indented
            var indent = EditorGUI.indentLevel;
            EditorGUI.indentLevel = 0;

            var entries = property.FindPropertyRelative("entries");

            if (entries.arraySize > 0)
            {
                float actionWidth = .25f*width;
                float targetWidth = .6f*width;
                float delayWidth = .1f*width;
                float buttonWidth = .05f*width;

                for (int i = 0; i < entries.arraySize; ++i)
                {
                    y += k_LineHeight + k_Spacing;

                    var entry = entries.GetArrayElementAtIndex(i);

                    float rowX = x;