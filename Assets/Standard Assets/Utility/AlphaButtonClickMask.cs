using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AlphaButtonClickMask : MonoBehaviour, ICanvasRaycastFilter 
{
    protected Image _image;

    public void Start()
    {
        _image = GetComponent<Image>();

        Texture2D tex = _image.sprite.texture as Texture2D;

        bool isInvalid = false;
        if (tex != null)
        {
            try
            {
                tex.GetPixels32();
            }
            catch (UnityException e)
            {
                Debug.LogError(e.Message);
                isInvalid = true;
            }
        }
        else
        {
            isInvalid = true;
        }

        if (isInvalid)
        {
            Debug.LogError("This script need an Image with a readbale Texture2D to work.");
        }
    }

    public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera)
    {
        Vector2 localPoint;
        RectTransformUtility.ScreenPointTo