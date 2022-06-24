using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Person : MonoBehaviour
{
    protected GameObject home;
    protected GameObject workPlace;
    protected Role role = Role.Labourer;
    protected Dictionary<Need, int> stats = new Dictionary<Need, int>();
    protected ItemBase carriedItem;

    protected float carryWeightCap = 10;
    protected float curCarryWeight;


    protected abstract void work();

    protected virtual void collect()
    {
        //Currently set up for taking based on needs.
        //Need to set up to allow for house or job requirements
        //Develop jobs first, and return later


            //ItemCategory itemNeeded;
            //foreach (KeyValuePair<Need, int> stat in stats)
            //{
            //    if (stat.Value <= 20)
            //    {
            //        print($"Need: {stat.Key} || {stat.Value}");
            //        itemNeeded = (ItemCategory)stat.Key;
            //        break;
            //    }
            //}
            //carriedItem = home.GetComponent<HouseDisplay>().ItemCollect(itemNeeded);
    }

    protected void Deliver()
    {
        home.GetComponent<HouseDisplay>().addToStockPile(carriedItem);
        carriedItem = null;
    }

}
