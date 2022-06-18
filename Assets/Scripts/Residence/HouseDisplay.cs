using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HouseDisplay : MonoBehaviour
{
    public Dictionary<int, Food> foodStore = new Dictionary<int, Food>();
    int foodItems;

    // Start is called before the first frame update
    void Start()
    {
        foodStore.Add(0, new Food("apple", "0x0001", 0.25f, 8));
        foreach(KeyValuePair<int, Food> kvp in foodStore)
        {
            //foodItems++;
            //print($"Key:{kvp.Key}       item:{kvp.Value.getset_Type}");
        }
    }

    public void addFood(Food item)
    {
        bool detected = false;
        for (int i = 0; i < foodStore.Count; i++)
        {
            foodStore.TryGetValue(i, out Food value);
            {
                print(value.getset_Type);
                if(value.getTypeHash == item.getTypeHash)
                {
                    value.getset_Quantity += item.getset_Quantity;
                    print(value.getset_Quantity);
                    detected = true;
                }
            }
        }
        if (!detected)
        {
            //print($"{item.getset_Type}      {item.getset_Id}        {item.getset_Quantity}");
            foodStore.Add(++foodItems, item);
        }
        for(int i = 0; i < foodStore.Count; i++){
            print($"Key:{i}       item:{foodStore.GetValueOrDefault(i).getset_Type}");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Food banana = new Food("banana", "0x0002", 0.4f, 13);
            addFood(banana);
        }
    }
}
