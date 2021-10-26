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
      