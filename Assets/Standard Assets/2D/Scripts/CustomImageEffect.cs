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
			RenderTexture tmp2 = RenderTexture.GetTemporary (tmp.width, tmp.height);
			DrawLine (ray.x, ray.y, ray.z);
			Graphics.Blit (tmp, tmp2, EffectMaterial);
			RenderTexture.ReleaseTemporary (tmp);
			tmp = tmp2;
		}
		Graphics.Blit (tmp, dst);
		RenderTexture.ReleaseTemporary (tmp);
		lasers.Clear ();
	}

	public void Start ()
	{
		lasers = new List<Vector3> ();
		myCamera = gameObject.