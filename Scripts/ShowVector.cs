/**
 * Muestra en pantalla el vector con la posición de la esfera.
 */
using UnityEngine;

public class ShowVector : MonoBehaviour {
  void Update() {
    Debug.Log("Position Vector: " + transform.position);
    Debug.Log("Position Vector (GetComponent): " + GetComponent<Transform>().position); // Alternativa
  }
}
