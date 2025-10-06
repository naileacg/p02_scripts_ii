using UnityEngine;

public class MoveCube : MonoBehaviour
{
  public Vector3 move_direction = new Vector3(1, 0, 0);
  public float speed = 2;
  public bool use_local_space = true;

  void Start()
  {
    Vector3 position = transform.position;
    position.y = 0;
    transform.position = position;
  }

  void Update()
  {
    Vector3 displacement = move_direction * speed * Time.deltaTime;

    if (use_local_space)
      transform.Translate(displacement, Space.Self);
    else
      transform.Translate(displacement, Space.World);
        
  }
}
