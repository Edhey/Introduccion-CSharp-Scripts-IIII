/** Utilizar el eje “Horizontal” para girar el objetivo y que avance siempre en 
  * la dirección hacia adelante.
  * Ayuda: La dirección hacia adelante (eje Z positivo) se puede obtener con la
  * propiedad forward del Transform. No confundir con Vector3.forward.
  * Ayuda: Puedes usar la función Debug.DrawRay para depuració
  */

using UnityEngine;
public class AlwaysMovingForward : MonoBehaviour {
  [SerializeField] private float speed = 4f;
  [SerializeField] private float rotationSpeed = 100f;

  void Update() {
    float horizontalInput = Input.GetAxis("Horizontal");
    transform.Rotate(Vector3.up, horizontalInput * rotationSpeed * Time.deltaTime);
    transform.Translate(transform.forward * speed * Time.deltaTime, Space.World);
  }
}
