﻿using UnityEngine;

[CreateAssetMenu(fileName = "Purchase", menuName = "Store/Purchasable")]
public class PurchasableObject : ScriptableObject
{
    public Object Item;
    public int Value;
    
//    public bool Upgrade;
    public float UsageCount;
    public PurchasableObject UpgradeFrom;
//    public GameAction GetInstanceLocation;
    private Transform location;
//    public bool Perpetual;
    public bool Instanciatable;
//    public UnityEvent OnCreate;

    public void CreateItems()
    {
        for (var i = 0; i < UsageCount; i++)
        {
            if (Instanciatable && Item is GameObject)
            {
                Instantiate(Item);
            }
        }
    }
    
    
    
    
    
    /*
    public void CreateItemsOnParent()
    {
        for (var i = 0; i < UsageCount; i++)
        {
            if (Instanciatable && Item is GameObject)
            {
                Instantiate(Item, location);
            }
        }
    }
    
    public void CreateItemsAt()
    {
        for (var i = 0; i < UsageCount; i++)
        {
            if (Instanciatable && Item is GameObject)
            {
                Instantiate(Item, location.position, Quaternion.identity);
            }
        }
    }

    public void Used()
    {
        if (!UnlimitedUse && UsageCount > 0)
        {
            UsageCount--;
        }
    }

    private void OnEnable()
    {
        if (GetInstanceLocation != null) GetInstanceLocation.Raise += RaiseHandler;
    }

    private void RaiseHandler (object obj)
    {
        location = obj as Transform;
    }
    */
}