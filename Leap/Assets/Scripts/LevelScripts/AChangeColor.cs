using UnityEngine;

public class AChangeColor : MonoBehaviour
{
    public void Change()
    {
        //Color col = new Color(Random.value, Random.value, Random.value);
        Color col = new Color(64, 221, 159);
        gameObject.GetComponent<Renderer>().material.color = col;   
        print("change color");
    }

}