using UnityEngine;

public class MoveOnSpace : MonoBehaviour
{
  public MarkerPositions marker;
  public int index = 0;
  private Vector3 displacement;
  private Vector3 original_position;

  void Start()
  {
    original_position = transform.position;
    if (marker != null)
    {
      if (index == 0) displacement = marker.position1;
      else if (index == 1) displacement = marker.position2;
      else if (index == 2) displacement = marker.position3;
      else displacement = Vector3.zero;
    }
  }

  void Update()
  {
    if (Input.GetAxis("Jump") > 0)
    {
      transform.position = displacement + original_position;
      Debug.Log(name + " movido a: " + transform.position);
    }
  }
}
