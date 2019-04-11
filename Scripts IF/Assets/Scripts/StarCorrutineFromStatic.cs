using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class StarCorrutineFromStatic : MonoBehaviour {

	public VideoClip[] videoClips;
	private int videoClipIndex = 0;
	public VideoPlayer videoPlayer;
	public static StarCorrutineFromStatic instancia;

	public void Start()
	{
		StartCoroutine(NextAnimation());
	}

	public void Awake()
	{
		instancia = this;
	}

	IEnumerator NextAnimation() {
		Debug.Log("Entro a corrutina");
		videoClipIndex++;

		if (videoClipIndex >= videoClips.Length)
		{
			videoClipIndex = videoClipIndex % videoClips.Length;
		}

		videoPlayer.clip = videoClips[videoClipIndex];
		videoPlayer.Play();
		yield return null;
	}

	public static void ejemplo()
	{
		instancia.StartCoroutine(instancia.NextAnimation());
		Debug.Log("Entro a ejemplo");
	}

}

