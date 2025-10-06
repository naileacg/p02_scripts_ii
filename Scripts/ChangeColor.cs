using UnityEngine;

public class ChangeColor : MonoBehaviour
{
  public int frames_to_wait = 120;
    
  private int frame_count = 0;
  private Color current_color;
  private Renderer object_renderer;

  void Start()
  {
    // Obtenemos el Renderer del objeto y le ponemos un color de inicio
    object_renderer = GetComponent<Renderer>();
    current_color = new Color(Random.value, Random.value, Random.value);
    object_renderer.material.color = current_color;
  }

  void Update()
  {
    frame_count++;
    // Cambiamos el color a uno aleatorio (solo uno de los canales)
    if (frame_count >= frames_to_wait)
    {
      int channel = Random.Range(0, 3);
      if (channel == 0) current_color.r = Random.value;
      else if (channel == 1) current_color.g = Random.value;
      else current_color.b = Random.value;

      object_renderer.material.color = current_color;
      frame_count = 0;
    }
        
  }
}
