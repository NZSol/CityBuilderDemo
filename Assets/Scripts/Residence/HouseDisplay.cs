using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HouseDisplay : MonoBehaviour
{
    //UI
    [SerializeField] GameObject itemDisplay;
    [SerializeField] GameObject line;

    //Dictionary<int, Food> itemStockpile = new Dictionary<int, Food>();
    Dictionary<int, ItemBase> itemStockpile = new Dictionary<int, ItemBase>();
    int foodCount = 0;
    int itemCount = 0;

    public List<string> stockDisplay = new List<string>();
    List<GameObject> lineList = new List<GameObject>();



    //Overloaded functions to add to different stockpile dictionaries
    public void addToStockPile(ItemBase item)
    {
        //Determinant for new or existing item in stockpile
        bool detected = false;
        for (int i = 0; i < itemStockpile.Count; i++)
        {
            //Get reference for item at key of value i
            itemStockpile.TryGetValue(i, out ItemBase value);

            //Determine if hashed name of value parm is same as hashed name of item parm
            //If same, add incoming quantity to existing quantity and set detected true
            if (value.getTypeHash == item.getTypeHash)
            {
                value.getset_Quantity += item.getset_Quantity;
                UpdateGrid(i, value.getset_Quantity);
                detected = true;
            }
        }
        //if item doesnt match anything in dictionary, add to collection
        if (!detected)
        {
            itemStockpile.Add(foodCount++, item);
            stockDisplay.Add(item.getset_Type);  //Adding to list for dev purpose
            EditGrid(item.getset_Type, item.getset_Id, item.getset_Quantity);
        }
    }

    void UpdateGrid(int key, int quantity)
    {
        itemDisplay.transform.GetChild(key).gameObject.GetComponent<ObjectDisplayInfo>().getset_Count = quantity;
    }

    void EditGrid(string name, string id, int quantity)
    {
        var myLine = Instantiate(line, itemDisplay.transform).GetComponent<ObjectDisplayInfo>();
        myLine.getset_Count = quantity;
        myLine.getset_ID = id;
        myLine.getset_Type = name;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            int rand = UnityEngine.Random.Range(0,3);
            switch (rand)
            {
                case 0:
                    addToStockPile(new Food("banana", "0x0002", 0.4f, 13));
                    break;
                case 1:
                    addToStockPile(new Resource("Tools", "0x0003", 0f, 4));
                    break;
                case 2:
                    addToStockPile(new Food("apple", "0x0001", 0.25f, 8));
                    break;
            }
        }
    }
}
