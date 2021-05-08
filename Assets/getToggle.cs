using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class getToggle : MonoBehaviour {

    public Toggle toggle;
	// Use this for initialization

    public void showDropdownContent(RectTransform wrapper)
    {
        if (toggle.isOn)
        {
            wrapper.gameObject.SetActive(true);
        }
        else
        {
            wrapper.gameObject.SetActive(false);
        }
    }

}
