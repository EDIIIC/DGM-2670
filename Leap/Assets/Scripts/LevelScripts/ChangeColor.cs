using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
     {
         if (col.gameObject.name == "Player")
         {
             new Color(Random.value, Random.value, Random.value);
            // renderer.material.color = col;   
             print ("change color");
         }
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