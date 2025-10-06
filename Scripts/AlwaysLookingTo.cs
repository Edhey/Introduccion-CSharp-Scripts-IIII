/**
  * Adapta el movimiento en el ejercicio 11 de forma que el cubo avance mirando
  * siempre hacia la esfera, independientemente de la orientación de su sistema 
  * de referencia. Para ello, el cubo debe girar de forma que el eje Z positivo 
  * apunte hacia la esfera . Realiza pruebas cambiando la posición de la esfera 
  * mediante las teclas awsd
  * Ayuda: La clase Transform tiene el método LookAt(Transform target), que rota
  * al objetivo para hacer que el vector hacia delante apunte al objetivo 
  * (target). Se debe tener en cuenta que puede ser necesario especificar que el 
  * movimiento sea relativo al espacio del mundo.
  */
using UnityEngine;

public class AlwaysLookingTo : MonoBehaviour {
  [SerializeField] private Transform lookingToTransform;
  [SerializeField] private float speed = 4f;

  void Start() {
    lookingToTransform = GameObject.FindWithTag("Sphere").transform;
  }

  void Update() {
    LookAtObject();
    MovingWithArrows();
  }

  void LookAtObject() {
    transform.LookAt(lookingToTransform);
  }

  void MovingWithArrows() {
    float verticalInput = 0f;
    float horizontalInput = 0f;

    if (Input.GetKey(KeyCode.UpArrow)) verticalInput = 1f;
    if (Input.GetKey(KeyCode.DownArrow)) verticalInput = -1f;
    if (Input.GetKey(KeyCode.RightArrow)) horizontalInput = 1f;
    if (Input.GetKey(KeyCode.LeftArrow)) horizontalInput = -1f;

    Vector3 movement = new Vector3(horizontalInput, verticalInput, 0) * speed * Time.deltaTime; // Adapted for frame rate independence
    transform.Translate(movement, Space.World);
  }
}
