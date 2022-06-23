using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selection : MonoBehaviour
{
    Camera cam;
    Canvas active;
    // Start is called before the first frame update
    void Awake()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray, out hit) && hit.transform != null){
                if(hit.transform.tag == "Selectable")
                {
                    if(active != null)
                    {
                        active.enabled = false;
                    }
                    active = hit.transform.GetComponentInChildren<Canvas>();
                    active.enabled = true;
                }
                else
                {
                    active.enabled = false;
                }
            }
        }
    }
}
