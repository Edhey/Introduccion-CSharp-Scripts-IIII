/** Crea un script asociado a un objeto en la escena que inicialice un vector de
 * 3 posiciones con valores entre 0.0 y 1.0, para tomarlo como un vector de 
 * color (Color). Cada 120 frames se debe cambiar el valor de una posición 
 * aleatoria y asignar el nuevo color al objeto. Parametrizar la cantidad de 
 * frames de espera para poderlo cambiar desde el inspector.
 */

using UnityEngine;

public class ChangePositionAndColor : MonoBehaviour {
  [SerializeField] private int framesToWait = 120;
  private Renderer objectRenderer;

  void Start() {
    objectRenderer = GetComponent<Renderer>();
  }

  void Update() {
    if (Time.frameCount % framesToWait == 0) {
      ChangeToRandomPosition();
      ChangeToRandomColor();
    }
  }

  void ChangeToRandomPosition() {
    Vector3 newPosition = new Vector3(UnityEngine.Random.Range(0.0f, 1.0f),
                                      UnityEngine.Random.Range(0.0f, 1.0f),
                                      UnityEngine.Random.Range(0.0f, 1.0f));
    gameObject.transform.position = newPosition;
  }
  void ChangeToRandomColor() {
    Color newColor = new Color(UnityEngine.Random.Range(0.0f, 1.0f),
                               UnityEngine.Random.Range(0.0f, 1.0f),
                               UnityEngine.Random.Range(0.0f, 1.0f));
    objectRenderer.material.color = newColor;
  }
}
