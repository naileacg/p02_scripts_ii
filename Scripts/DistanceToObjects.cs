using UnityEngine;

public class DistanceToObjects : MonoBehaviour
{
  private Transform cube_transform;
  private Transform cylinder_transform;
  void Start()
  {
    GameObject cube = GameObject.FindWithTag("ColoredCube");
    GameObject cylinder = GameObject.FindWithTag("Cylinder");

    cube_transform = cube.GetComponent<Transform>();
    cylinder_transform = cylinder.GetComponent<Transform>();

    float distance_to_cube = Vector3.Distance(transform.position, cube_transform.position);
    float distance_to_cylinder = Vector3.Distance(transform.position, cylinder_transform.position);
    Debug.Log("Distancia a cubo: " + distance_to_cube);
    Debug.Log("Distancia a cilindro: " + distance_to_cylinder);  
  }
}
