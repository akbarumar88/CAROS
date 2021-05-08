using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Dropdown : MonoBehaviour{
    public RectTransform container;
    public bool isOpen;

    void Start () {
        container = transform.Find("Container").GetComponent<RectTransform>();
        isOpen = false;
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 scale = container.localScale;
        scale.y = Mathf.Lerp(scale.y, isOpen ? 1 : 0, Time.deltaTime * 12);
        container.localScale = scale;
	}
}
