using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CrosshairHideWhenScoped : MonoBehaviour
{
    public Image CrossHairParts;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(1)) {
            CrossHairParts.enabled = false;
        }
        else if(Input.GetMouseButtonUp(1)) {
            CrossHairParts.enabled = true;
        }
    }
}
