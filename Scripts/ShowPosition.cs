using UnityEngine;

public class ShowPosition : MonoBehaviour
{
  private Transform my_transform;
  void Start()
  {
    my_transform = GetComponent<Transform>();
    Vector3 position = my_transform.position;
    Debug.Log("Posición de la esfera: " + position);   
  }
}
