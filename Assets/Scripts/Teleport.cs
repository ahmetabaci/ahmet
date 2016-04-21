using UnityEngine;
using System.Collections;

public class Teleport : MonoBehaviour {
	public int code;
	float disableTimer = 0;
	public Material	skyboxMaterial;

	void Update(){
		if (disableTimer > 0)
			disableTimer -= Time.deltaTime;
	}

	void OnTriggerEnter(Collider collider){
		if (collider.gameObject.name == "ThirdPersonController" && disableTimer <=0) {

			RenderSettings.skybox = skyboxMaterial;

			foreach (Teleport tp in FindObjectsOfType<Teleport>()) {
				
				if (tp.code == code && tp != this) {
					tp.disableTimer = 2;
					Vector3 position = tp.gameObject.transform.position;
					//position.z += 2;
					collider.gameObject.transform.position = position;
				}

			
			}
		}
	}

}
