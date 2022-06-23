using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectDisplayInfo : MonoBehaviour
{
    Image img;
    int count { get; set; }
    string type { get; set; }
    string id { get; set; }


    Text typeField;
    Text countField;


    public string getset_Type
    {
        set
        {
            type = value;
            typeField.text = type;
        }
    }
    public string getset_ID
    {
        set
        {
            id = value;
            print(id);

            img.sprite = Resources.Load<Sprite>($"Images/ItemSprites/{id}");
        }
    }
    public int getset_Count
    {
        set
        {
            count = value;
            countField.text = count.ToString();
        }
    }


    private void Awake()
    {
        img = GetComponentInChildren<Image>();
        foreach (Text txt in gameObject.transform.GetComponentsInChildren<Text>())
        {
            if (txt.name.Contains("Name"))
                typeField = txt;
            else
                countField = txt;
        }
    }


}
