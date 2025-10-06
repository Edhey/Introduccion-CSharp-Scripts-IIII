/**
 * Crea un script para la esfera que muestre en consola la distancia a la que están el cubo y el cilindro.
 */

using UnityEngine;

public class DistanceToCubeAndCylinder : MonoBehaviour {
  [SerializeField] private Transform cubeTransform;
	[SerializeField] private Transform cylinderTransform;

	void Start() {
		cubeTransform = GameObject.FindWithTag("Cube").transform;
		cylinderTransform = GameObject.FindWithTag("Cylinder").transform;
	}

	void Update() {
		float distanceToCube = Vector3.Distance(transform.position, cubeTransform.position);
		float distanceToCylinder = Vector3.Distance(transform.position, cylinderTransform.position);

		Debug.Log("Distance to Cube: " + distanceToCube);
		Debug.Log("Distance to Cylinder: " + distanceToCylinder);
	}
}
