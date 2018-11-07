using UnityEngine;

public class ChangeColor : MonoBehaviour
{
  public ColorData Color;

  public void Call(SpriteRenderer spriteRenderer)
  {
    spriteRenderer.color = Color.Value;
  }

  private void Call(Material material)
  {
    material.color = Color.Value;
  }
}


/*
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
  public ColorData SpriteColor;

  private SpriteRenderer sRenderer;

    private void Start()
  {
    sRenderer = GetComponent<SpriteRenderer>();
    sRenderer.color = SpriteColor.Value;
  }

  public void OnTriggerEnter(Collider obj)
  {
    obj.GetComponent<SpriteRenderer>().color =
      SpriteColor.Value;
  }
}
*/