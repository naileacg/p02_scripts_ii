using UnityEngine;

public class VectorInspector : MonoBehaviour
{
  // Vectores públicos para configurar en el inspector
  public Vector3 vectorA = new Vector3(1, 0, 0);
  public Vector3 vectorB = new Vector3(0, 1, 0);

  // Resultados a imprimir
  public float magnitudeA;
  public float magnitudeB;
  public float angleAB;
  public float distanceAB;
  public string higher_vector;

  void Start()
  {
    magnitudeA = vectorA.magnitude;
    magnitudeB = vectorB.magnitude;
    angleAB = Vector3.Angle(vectorA, vectorB);
    distanceAB = Vector3.Distance(vectorA, vectorB);

    if (vectorA.y > vectorB.y) higher_vector = "Vector A está a una altura mayor";
    else if (vectorA.y < vectorB.y) higher_vector = "Vector B está a una altura mayor";
    else higher_vector = "Ambos vectores están a la misma altura";
    
    Debug.Log("Vector A: " + vectorA + ", Magnitud: " + magnitudeA);
    Debug.Log("Vector B: " + vectorB + ", Magnitud: " + magnitudeB);
    Debug.Log("Ángulo entre A y B: " + angleAB + "°");
    Debug.Log("Distancia entre A y B: " + distanceAB);
    Debug.Log(higher_vector);
  }
}
