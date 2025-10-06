/** Adapta el movimiento en el ejercicio 10 para que el cubo se mueva hacia la 
  * posición de la esfera. Debes considerar que el avance no debe estar 
  * influenciado por cuánto de lejos o cerca estén los dos objetos. 
  * Ayuda: La dirección del movimiento debe ser el vector que une al cubo con la
  * esfera. Se debe tener en cuenta que el cubo no debe modificar su altura. 
  * Ayuda: El vector que marca el movimiento aporta la información de la
  * dirección. Es recomendable utilizar vectores de magnitud 1, para que el
  * avance no dependa de dicha magnitud. La clase Vector3 tiene la utilidad de
  * normalizar vectores.
  */
using UnityEngine;

public class MovingToSphere : MonoBehaviour {
  private Transform sphereTransform;
  [SerializeField] private float speed = 2f;

  void Start() {
    sphereTransform = GameObject.FindWithTag("Sphere").transform;
  }

  void Update() {
    AlwaysMoveToSphere();
    // MoveToSphereWithInput();
  }

  void AlwaysMoveToSphere() {
    Vector3 directionToSphere = sphereTransform.position - transform.position;
    directionToSphere.y = 0; // Mantener la altura constante
    transform.Translate(directionToSphere.normalized * speed * Time.deltaTime, Space.World);
  }

  void MoveToSphereWithInput() {
    float verticalInput = 0f;
    float horizontalInput = 0f;

    if (Input.GetKey(KeyCode.UpArrow))
      verticalInput = 1f;
    if (Input.GetKey(KeyCode.DownArrow))
      verticalInput = -1f;
    if (Input.GetKey(KeyCode.RightArrow))
      horizontalInput = 1f;
    if (Input.GetKey(KeyCode.LeftArrow))
      horizontalInput = -1f;

    Vector3 directionToSphere = sphereTransform.position - transform.position;
    directionToSphere.x *= horizontalInput;
    directionToSphere.y *= verticalInput;
    transform.Translate(directionToSphere.normalized * speed * Time.deltaTime, Space.World);
  }
}
