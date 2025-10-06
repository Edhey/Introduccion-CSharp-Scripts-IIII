/** Crea un script asociado a la esfera con dos variables Vector3 públicas. Dale valor a cada componente de los vectores desde el inspector. Muestra en la consola:
 * La magnitud de cada uno de ellos. 
 * El ángulo que forman
 * La distancia entre ambos.
 * Un mensaje indicando qué vector está a una altura mayor.
 * Muestra en el inspector cada uno de esos valores.
 */
using UnityEngine;

public class VectorDisplay : MonoBehaviour {
  public Vector3 vectorA;
  public Vector3 vectorB;

  public float magnitudeA;
  public float magnitudeB;
  public float angleBetween;
  public float distanceBetween;
  public string higherVectorMessage;

  void Update() {
    magnitudeA = vectorA.magnitude;
    magnitudeB = vectorB.magnitude;
    angleBetween = Vector3.Angle(vectorA, vectorB);
    distanceBetween = Vector3.Distance(vectorA, vectorB);
    if (vectorA.y > vectorB.y) {
      higherVectorMessage = "Vector A is higher than Vector B";
    }
    else if (vectorA.y < vectorB.y) {
      higherVectorMessage = "Vector B is higher than Vector A";
    }
    else {
      higherVectorMessage = "Both vectors are at the same height";
    }
    Debug.Log("Magnitude of Vector A: " + magnitudeA);
    Debug.Log("Magnitude of Vector B: " + magnitudeB);
    Debug.Log("Angle between Vector A and Vector B: " + angleBetween);
    Debug.Log("Distance between Vector A and Vector B: " + distanceBetween);
    Debug.Log(higherVectorMessage);
  }
}
