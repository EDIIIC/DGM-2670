﻿using UnityEngine;

public class PurchasableObjectGenerator : MonoBehaviour
{
	public PurchasableObject Purchased;
	
	
	void Start ()
	{
		for (var i = 0; i < Purchased.ObjectList.Count; i++)
		{
			var obj = Purchased.ObjectList[i];
			obj.CreateItem();
			if (!obj.Perpetual)
			{
				Purchased.ObjectList.Remove(obj);
			}
		}
	}
}
