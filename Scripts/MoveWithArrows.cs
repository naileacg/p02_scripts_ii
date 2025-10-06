using UnityEngine;

public class MoveWithArrows : MonoBehaviour
{
  public float speed = 5;

  void Update()
  {
    Vector3 move_direction = new Vector3(0, 0, 0);

    if (Input.GetKey(KeyCode.RightArrow))
      move_direction.x = 1;
    if (Input.GetKey(KeyCode.LeftArrow))
      move_direction.x = -1;

    if (Input.GetKey(KeyCode.UpArrow))
      move_direction.z = 1;
    if (Input.GetKey(KeyCode.DownArrow))
      move_direction.z = -1;

    // transform.Translate(move_direction * speed, Space.World);
    // Modificado
    transform.Translate(move_direction * speed * Time.deltaTime, Space.World);
  }
}
