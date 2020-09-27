using UnityEngine;
using System.Collections.Generic;

[ExecuteInEditMode]
public class CustomImageEffect : MonoBehaviour
{
	public Material EffectMaterial;
	public List<Vector3> lasers;
	private Camera myCamera;

	void OnRenderImage (RenderTexture src, RenderTexture dst)
	{
		RenderTexture tmp = RenderTexture.GetTemporary (src.width, src.height);
		Graphics.Blit (src, tmp);
		foreach (Vector3 ray in lasers) {
			RenderTexture tmp2 = RenderTexture.GetTemporary (tmp.width,