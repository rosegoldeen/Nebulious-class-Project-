using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class menuManager : MonoBehaviour

{
	public Canvas mainCanvas;
	public Canvas settingsCanvas;
	public Canvas creditsCanvas;

	void Awake()
	{
		settingsCanvas.enabled = false;
		creditsCanvas.enabled = false;
	}

	public void OptionsOn()
	{
		settingsCanvas.enabled = true;
		mainCanvas.enabled = false;
	}

	public void ReturnOn()
	{
		settingsCanvas.enabled = false;
		creditsCanvas.enabled = false;
		mainCanvas.enabled = true;
	}

	public void CreditsOn()
	{	
		creditsCanvas.enabled = true;
		mainCanvas.enabled = false;
	}
}

