/** Mueve el cubo con las teclas de flecha arriba-abajo, izquierda-derecha a la 
 * velocidad speed. Cada uno de estos ejes implican desplazamientos en el eje
 * vertical y horizontal respectivamente. Mueve la esfera con las teclas w-s
 * (movimiento vertical) a-d (movimiento horizontal).
 * Ayuda: Utiliza lo aprendido en los ejercicios anteriores sobre la clase Input
 * y la clase Translate. 
 */

using UnityEngine;

public class MovingWithASWD : MonoBehaviour {
  [SerializeField] private float speed = 5f;

  void Update() {
    float verticalInput = 0f;
    float horizontalInput = 0f;

    if (Input.GetKey(KeyCode.W)) verticalInput = 1f;
    if (Input.GetKey(KeyCode.S)) verticalInput = -1f;
    if (Input.GetKey(KeyCode.D)) horizontalInput = 1f;
    if (Input.GetKey(KeyCode.A)) horizontalInput = -1f;

    // Vector3 movement = new Vector3(horizontalInput, verticalInput, 0) * speed;
    Vector3 movement = new Vector3(horizontalInput, verticalInput, 0) * speed * Time.deltaTime; // Adapted for frame rate independence
    transform.Translate(movement, Space.World);
  }
}