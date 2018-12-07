using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public void Change()
    {
        Color col = new Color(Random.value, Random.value, Random.value);
        gameObject.GetComponent<Renderer>().material.color = col;   
        print("change color");
    }

}


/*
    private void OnEnable()
    {
        NewEvent.OnLand += TurnColor();
    }
    
    private void OnDisable()
    {
        NewEvent.OnLand -= TurnColor();
    }

    private void TurnColor()
    {
        Color col = new Color(0,225,198);
        renderer.material.color = col;
    }
*/    

/*
    public ColorData Color;
 
         public void Call(SpriteRenderer spriteRenderer)
         {
             spriteRenderer.color = Color.Value;
         }
 
         private void Call(Material material)
         {
             material.color = Color.Value;
         }
*/