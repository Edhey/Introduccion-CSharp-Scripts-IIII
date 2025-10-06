/**Crea un script asociado al cubo que en cada iteración traslade al cubo una 
 * cantidad proporcional un vector que indica la dirección del movimiento: 
 * moveDirection que debe poder modificarse en el inspector.  La velocidad a la 
 * que se produce el movimiento también se especifica en el inspector, con la 
 * propiedad speed. Inicialmente la velocidad debe ser mayor que 1 y el cubo 
 * estar en una posición y=0. En el informe de la práctica comenta los  
 * resultados que obtienes en cada una de las siguientes situaciones:
 *      a. duplicas las coordenadas de la dirección del movimiento.
 *        Al duplicar las coordenadas de la dirección del movimiento, el cubo se mueve el doble de rápido en la dirección especificada.
 *      b. duplicas la velocidad manteniendo la dirección del movimiento.
 *        Al duplicar la velocidad manteniendo la dirección del movimiento, el cubo se mueve el doble de rápido en la misma dirección.
 *      c. la velocidad que usas es menor que 1
 *        Cuando la velocidad es menor que 1, el cubo se mueve en la dirección opuesta al vector de movimiento.
 *      d. la posición del cubo tiene y>0
 *        Cuando la posición del cubo tiene y>0, el cubo se mueve en la dirección especificada por el vector de movimiento, pero su altura (y) no afecta su movimiento horizontal.
 *      e. intercambiar movimiento relativo al sistema de referencia local y el mundial.
 *        Al intercambiar entre movimiento relativo al sistema de referencia local y mundial, el cubo se mueve en la dirección del vector de movimiento en el sistema mundial, mientras que en el sistema local, el movimiento depende de la orientación actual del cubo. De manera que si este está rotado, el movimiento será en una dirección "diferente a la del vector de movimiento".
 */
using UnityEngine;

public class TranslateWithVelocity : MonoBehaviour {
  [SerializeField] private Vector3 moveDirection = new Vector3(1, 0, 0);
  [SerializeField] private float speed = 2f;

  void Update() {
    // Movimiento relativo al sistema de referencia mundial
    transform.Translate(moveDirection * speed * Time.deltaTime, Space.World);
    // transform.Translate(moveDirection.x * speed * Time.deltaTime, moveDirection.y * speed * Time.deltaTime, moveDirection.z * speed * Time.deltaTime, Space.World);
    // transform.position += moveDirection * speed * Time.deltaTime;

    // Movimiento relativo al sistema de referencia local
    // transform.Translate(moveDirection * speed * Time.deltaTime, Space.Self);
    // transform.position += transform.TransformDirection(moveDirection) * speed * Time.deltaTime;
  }
}
