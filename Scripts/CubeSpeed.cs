using UnityEngine;

public class CubeSpeed : MonoBehaviour
{
  public float speed = 5;
  void Update()
  {
    // Eje horizontal
    float horizontal = Input.GetAxis("Horizontal");
    if (horizontal > 0)
    {
      Debug.Log("Flecha Derecha: " + (speed * horizontal));
    }
    else if (horizontal < 0)
    {
      Debug.Log("Flecha Izquierda: " + (speed * horizontal));
    }

    // Eje vertical
    float vertical = Input.GetAxis("Vertical");
    if (vertical > 0)
    {
      Debug.Log("Flecha Arriba: " + (speed * vertical));
    }
    else if (vertical < 0)
    {
      Debug.Log("Flecha Abajo: " + (speed * vertical));
    }
  }
}
