using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemBase
{
    protected string type { get; set; }
    protected int typeHash { get; }

    protected string id { get; set; }
    protected int idHash { get; }

    protected float restore { get; set; }
    protected int quantity { get; set; }

    protected Image icon { get; set; }


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
