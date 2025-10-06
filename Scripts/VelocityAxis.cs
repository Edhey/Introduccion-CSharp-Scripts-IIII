/** Agrega un campo velocidad a un cubo y asígnale un valor que se pueda cambiar
 * en el inspector de objetos. Muestra la consola el resultado de multiplicar la
 * velocidad por el valor del eje vertical y por el valor del eje horizontal
 * cada vez que se pulsan las teclas flecha arriba-abajo ó flecha
 * izquierda-derecha. El mensaje debe comenzar por el nombre de la 
 * flecha pulsada.
 */
using UnityEngine;

public class VelocityAxis : MonoBehaviour {
  [SerializeField] private float velocity = 5f;

  void Update() {
    float verticalInput = Input.GetAxis("Vertical");
    float horizontalInput = Input.GetAxis("Horizontal");

    if (verticalInput != 0) {
      float verticalVelocity = velocity * verticalInput;
      if (verticalInput > 0) {
        Debug.Log("Up Arrow Pressed: Vertical Velocity = " + verticalVelocity);
      } else {
        Debug.Log("Down Arrow Pressed: Vertical Velocity = " + verticalVelocity);
      }
    }

    if (horizontalInput != 0) {
      float horizontalVelocity = velocity * horizontalInput;
      if (horizontalInput > 0) {
        Debug.Log("Right Arrow Pressed: Horizontal Velocity = " + horizontalVelocity);
      } else {
        Debug.Log("Left Arrow Pressed: Horizontal Velocity = " + horizontalVelocity);
      }
    }
  }
}
