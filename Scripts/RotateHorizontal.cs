using UnityEngine;

public class RotateHorizontal : MonoBehaviour
{
  public float speed = 1;
  public float rotation_speed = 90;

  void Update()
  {
    if (Input.GetKey(KeyCode.LeftArrow))
    {
      transform.Rotate(0, -rotation_speed * Time.deltaTime, 0);
    }
    else if (Input.GetKey(KeyCode.RightArrow))
    {
      transform.Rotate(0, rotation_speed * Time.deltaTime, 0);
    }

    transform.Translate(Vector3.forward * speed * Time.deltaTime);
  }
}
