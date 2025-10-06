using UnityEngine;

public class MoveWithWASD : MonoBehaviour
{
  public float speed = 5;

  void Update()
  {
    Vector3 move_direction = new Vector3(0, 0, 0);

    if (Input.GetKey(KeyCode.W))
      move_direction.z = 1;
    if (Input.GetKey(KeyCode.S))
      move_direction.z = -1;

    if (Input.GetKey(KeyCode.D))
      move_direction.x = 1;
    if (Input.GetKey(KeyCode.A))
      move_direction.x = -1;

    // transform.Translate(move_direction * speed, Space.World);
    // Modificado
    transform.Translate(move_direction * speed * Time.deltaTime, Space.World);
  }
}
