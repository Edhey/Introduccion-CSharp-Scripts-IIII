/**
 * Selecciona tres posiciones en tu escena a través de un objeto invisible 
 * (marcador) que incluya 3 vectores numéricos para configurar posiciones en las 
 * que quieres ubicar los objetos en respuesta a pulsar la barra espaciadora.
 * Estos vectores representan un desplazamiento respecto a la posición original 
 * de cada objeto. Crea un script que ubique en las posiciones configuradas cuando 
 * el usuario pulse la barra espaciadora. 
 */

using UnityEngine;

public class DisplaceFromVector : MonoBehaviour {
  [SerializeField] private Vector3 displacement1;
  [SerializeField] private Vector3 displacement2;
  [SerializeField] private Vector3 displacement3;

  [SerializeField] private Transform markerTransform1;
  [SerializeField] private Transform markerTransform2;
  [SerializeField] private Transform markerTransform3;

  void Update() {
    if (Input.GetAxis("Jump") > 0) {
      markerTransform1.position = markerTransform1.position + displacement1;
      markerTransform2.position = markerTransform2.position + displacement2;
      markerTransform3.position = markerTransform3.position + displacement3;
    }
  }
}
