using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Store/Store")]
public class AStore : ScriptableObject
{
    public Object Item;
    public List<Object> Purchased;
    public int ItemValue;
    public AIntData Cash;
    
    public void Purchase()
    {
        if (Cash.Value < ItemValue) return;
        Purchased.Add(Item);
        Cash.Value -= ItemValue;
    }

    public void AddObjectToGame()
    {
       // if (Purchased.Contains(Item))
        if (Purchased.Count <= 0) return;
        Instantiate(Purchased[0]);
        Purchased.RemoveAt(0);
    }
}