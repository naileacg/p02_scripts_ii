using UnityEngine;

public class AdvanceWithSphere : MonoBehaviour
{
  public Transform sphere;
  public float speed = 1;

  void Update()
  {
    Vector3 target = new Vector3(sphere.position.x, transform.position.y, sphere.position.z);
    transform.LookAt(target);
    transform.Translate(Vector3.forward * speed * Time.deltaTime);
  }
}
