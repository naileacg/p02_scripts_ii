using UnityEngine;

public class Shooting : MonoBehaviour
{
  void Update()
  {
    if (Input.GetButtonDown("Disparo"))
    {
      Debug.Log("Disparo activado con la tecla H");
    }
  }
}
