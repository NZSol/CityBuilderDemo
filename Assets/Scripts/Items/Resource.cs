using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resource : ItemBase
{
    public Resource(string type, string id, float restore, int quantity)
    {
        this.type = type;
        this.id = id;
        this.restore = restore;
        this.quantity = quantity;
    }
}
