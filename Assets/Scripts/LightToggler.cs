using UnityEngine;
using System.Collections;

public class LightToggler : MonoBehaviour {

	public Light light;
	public Material	skyboxMaterial;
	public Material	currentSky;

	void OnTriggerEnter(){
		light.enabled = false;
		RenderSettings.skybox = skyboxMaterial;
	}

	void OnTriggerExit(){
		light.enabled = true;
		RenderSettings.skybox = currentSky;
	}

}
