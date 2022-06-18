using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Food
{
    string type { get; set; }
    int typeHash { get; }

    string id { get; set; }
    int idHash { get; }

    float restore { get; set; }
    int quantity { get; set; }

    Image icon { get; set; }


    public Food(string type, string id, float restore, int quantity)
    {
        this.type = type;
        this.id = id;
        this.restore = restore;
        this.quantity = quantity;
    }

  
    public string getset_Type
    {
        get { return type; }
        set { type = value; }
    }
    public int getTypeHash
    {
        get { return type.GetHashCode(); }
    }

    public string getset_Id
    {
        get { return id; }
        set { id = value; }
    }
    public int getIdHash
    {
       get { return id.GetHashCode(); }
    }

    public float getset_Value
    {
        get { return restore; }
        set { restore = value; }
    }

    public int getset_Quantity
    {
        get { return quantity; }
        set { quantity = value; }
    }

    public Image getset_Icon
    {
        get { return icon; }
        set { icon = value; }
    }

}
