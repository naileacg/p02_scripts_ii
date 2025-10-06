using UnityEngine;

public class FollowSphere : MonoBehaviour
{
  public Transform sphere;
  public float speed = 1;

  void Update()
  {
    Vector3 direction = sphere.position - transform.position;
    direction.y = 0;
    direction = direction.normalized;
    transform.Translate(direction * speed * Time.deltaTime, Space.World); 
  }
}
