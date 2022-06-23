using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Food : Item
{
    public Food(string type, string id, float restore, int quantity)
    {
        this.type = type;
        this.id = id;
        this.restore = restore;
        this.quantity = quantity;
    }
}
