using UnityEngine;

public class SeatDes : MonoBehaviour
{

   public float lifetime;

   void Update()
   {
      lifetime -= Time.deltaTime;
      if (lifetime <= 0)
      {
         Destroy(this.gameObject);
      }
   }
}
