using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderMenu : MonoBehaviour {
    public Scrollbar myScrollBar;
    public List<Image> LevelThumbanils;
	
	// Update is called once per frame
	void Update () {
        if (Input.touchCount == 0)
        {
            if (myScrollBar.GetComponent<Scrollbar>().value < 0.025f)
            {
                myScrollBar.GetComponent<Scrollbar>().value = Mathf.Lerp(myScrollBar.GetComponent<Scrollbar>().value,  0.025f, 0.1f);
            }
            else if (myScrollBar.GetComponent<Scrollbar>().value > 0.103f && myScrollBar.GetComponent<Scrollbar>().value < 0.155f)
            {
                myScrollBar.GetComponent<Scrollbar>().value = Mathf.Lerp(myScrollBar.GetComponent<Scrollbar>().value,  0.155f, 0.1f);
            }
            else if(myScrollBar.GetComponent<Scrollbar>().value > 0.205f && myScrollBar.GetComponent<Scrollbar>().value < 0.288f)
            {
                myScrollBar.GetComponent<Scrollbar>().value = Mathf.Lerp(myScrollBar.GetComponent<Scrollbar>().value, 0.288f, 0.1f);
            }
            else if(myScrollBar.GetComponent<Scrollbar>().value > 0.355f && myScrollBar.GetComponent<Scrollbar>().value < 0.422f)
            {
                myScrollBar.GetComponent<Scrollbar>().value = Mathf.Lerp(myScrollBar.GetComponent<Scrollbar>().value, 0.422f, 0.1f);
            }
            else if (myScrollBar.GetComponent<Scrollbar>().value > 0.483f && myScrollBar.GetComponent<Scrollbar>().value < 0.55f)
            {
                myScrollBar.GetComponent<Scrollbar>().value = Mathf.Lerp(myScrollBar.GetComponent<Scrollbar>().value, 0.55f, 0.1f);
            }
            else if (myScrollBar.GetComponent<Scrollbar>().value > 0.617f && myScrollBar.GetComponent<Scrollbar>().value < 0.684f)
            {
                myScrollBar.GetComponent<Scrollbar>().value = Mathf.Lerp(myScrollBar.GetComponent<Scrollbar>().value, 0.684f, 0.1f);
            }
            else if (myScrollBar.GetComponent<Scrollbar>().value > 0.745f && myScrollBar.GetComponent<Scrollbar>().value < 0.812f)
            {
                myScrollBar.GetComponent<Scrollbar>().value = Mathf.Lerp(myScrollBar.GetComponent<Scrollbar>().value, 0.812f, 0.1f);
            }
            else if (myScrollBar.GetComponent<Scrollbar>().value > 0.884f && myScrollBar.GetComponent<Scrollbar>().value < 0.946f)
            {
                myScrollBar.GetComponent<Scrollbar>().value = Mathf.Lerp(myScrollBar.GetComponent<Scrollbar>().value, 0.946f, 0.1f);
            }
            else if (myScrollBar.GetComponent<Scrollbar>().value > 0.946f)
            {
                myScrollBar.GetComponent<Scrollbar>().value = Mathf.Lerp(myScrollBar.GetComponent<Scrollbar>().value, 0.946f, 0.1f);
            }
        }

        if (myScrollBar.GetComponent<Scrollbar>().value < 0.025f)
        {
            LevelThumbanils[0].transform.localScale = Vector2.Lerp(LevelThumbanils[0].transform.localScale, new Vector2(1.2f, 1.2f), 0.1f);

            LevelThumbanils[1].transform.localScale = Vector2.Lerp(LevelThumbanils[1].transform.localScale, new Vector2(1, 1), 0.1f);
            LevelThumbanils[2].transform.localScale = Vector2.Lerp(LevelThumbanils[2].transform.localScale, new Vector2(1, 1), 0.1f);
            LevelThumbanils[3].transform.localScale = Vector2.Lerp(LevelThumbanils[3].transform.localScale, new Vector2(1, 1), 0.1f);
            LevelThumbanils[4].transform.localScale = Vector2.Lerp(LevelThumbanils[4].transform.localScale, new Vector2(1, 1), 0.1f);
            LevelThumbanils[5].transform.localScale = Vector2.Lerp(LevelThumbanils[5].transform.localScale, new Vector2(1, 1), 0.1f);
            LevelThumbanils[6].transform.localScale = Vector2.Lerp(LevelThumbanils[6].transform.localScale, new Vector2(1, 1), 0.1f);
            LevelThumbanils[7].transform.localScale = Vector2.Lerp(LevelThumbanils[7].transform.localScale, new Vector2(1, 1), 0.1f);
        }
        else if (myScrollBar.GetComponent<Scrollbar>().value > 0.103f && myScrollBar.GetComponent<Scrollbar>().value < 0.155f)
        {
            LevelThumbanils[1].transform.localScale = Vector2.Lerp(LevelThumbanils[1].transform.localScale, new Vector2(1.2f, 1.2f), 0.1f);

            LevelThumbanils[0].transform.localScale = Vector2.Lerp(LevelThumbanils[0].transform.localScale, new Vector2(1, 1), 0.1f);
            LevelThumbanils[2].transform.localScale = Vector2.Lerp(LevelThumbanils[2].transform.localScale, new Vector2(1, 1), 0.1f);
            LevelThumbanils[3].transform.localScale = Vector2.Lerp(LevelThumbanils[3].transform.localScale, new Vector2(1, 1), 0.1f);
            LevelThumbanils[4].transform.localScale = Vector2.Lerp(LevelThumbanils[4].transform.localScale, new Vector2(1, 1), 0.1f);
            LevelThumbanils[5].transform.localScale = Vector2.Lerp(LevelThumbanils[5].transform.localScale, new Vector2(1, 1), 0.1f);
            LevelThumbanils[6].transform.localScale = Vector2.Lerp(LevelThumbanils[6].transform.localScale, new Vector2(1, 1), 0.1f);
            LevelThumbanils[7].transform.localScale = Vector2.Lerp(LevelThumbanils[7].transform.localScale, new Vector2(1, 1), 0.1f);
        }
        else if (myScrollBar.GetComponent<Scrollbar>().value > 0.205f && myScrollBar.GetComponent<Scrollbar>().value < 0.288f)
        {
            LevelThumbanils[2].transform.localScale = Vector2.Lerp(LevelThumbanils[2].transform.localScale, new Vector2(1.2f, 1.2f), 0.1f);

            LevelThumbanils[0].transform.localScale = Vector2.Lerp(LevelThumbanils[0].transform.localScale, new Vector2(1, 1), 0.1f);
            LevelThumbanils[1].transform.localScale = Vector2.Lerp(LevelThumbanils[1].transform.localScale, new Vector2(1, 1), 0.1f);
            LevelThumbanils[3].transform.localScale = Vector2.Lerp(LevelThumbanils[3].transform.localScale, new Vector2(1, 1), 0.1f);
            LevelThumbanils[4].transform.localScale = Vector2.Lerp(LevelThumbanils[4].transform.localScale, new Vector2(1, 1), 0.1f);
            LevelThumbanils[5].transform.localScale = Vector2.Lerp(LevelThumbanils[5].transform.localScale, new Vector2(1, 1), 0.1f);
            LevelThumbanils[6].transform.localScale = Vector2.Lerp(LevelThumbanils[6].transform.localScale, new Vector2(1, 1), 0.1f);
            LevelThumbanils[7].transform.localScale = Vector2.Lerp(LevelThumbanils[7].transform.localScale, new Vector2(1, 1), 0.1f);
        }
        else if (myScrollBar.GetComponent<Scrollbar>().value > 0.355f && myScrollBar.GetComponent<Scrollbar>().value < 0.422f)
        {
            LevelThumbanils[3].transform.localScale = Vector2.Lerp(LevelThumbanils[3].transform.localScale, new Vector2(1.2f, 1.2f), 0.1f);

            LevelThumbanils[0].transform.localScale = Vector2.Lerp(LevelThumbanils[0].transform.localScale, new Vector2(1, 1), 0.1f);
            LevelThumbanils[1].transform.localScale = Vector2.Lerp(LevelThumbanils[1].transform.localScale, new Vector2(1, 1), 0.1f);
            LevelThumbanils[2].transform.localScale = Vector2.Lerp(LevelThumbanils[2].transform.localScale, new Vector2(1, 1), 0.1f);
            LevelThumbanils[4].transform.localScale = Vector2.Lerp(LevelThumbanils[4].transform.localScale, new Vector2(1, 1), 0.1f);
            LevelThumbanils[5].transform.localScale = Vector2.Lerp(LevelThumbanils[5].transform.localScale, new Vector2(1, 1), 0.1f);
            LevelThumbanils[6].transform.localScale = Vector2.Lerp(LevelThumbanils[6].transform.localScale, new Vector2(1, 1), 0.1f);
            LevelThumbanils[7].transform.localScale = Vector2.Lerp(LevelThumbanils[7].transform.localScale, new Vector2(1, 1), 0.1f);
        }
        else if (myScrollBar.GetComponent<Scrollbar>().value > 0.483f && myScrollBar.GetComponent<Scrollbar>().value < 0.55f)
        {
            LevelThumbanils[4].transform.localScale = Vector2.Lerp(LevelThumbanils[4].transform.localScale, new Vector2(1.2f, 1.2f), 0.1f);

            LevelThumbanils[0].transform.localScale = Vector2.Lerp(LevelThumbanils[0].transform.localScale, new Vector2(1, 1), 0.1f);
            LevelThumbanils[1].transform.localScale = Vector2.Lerp(LevelThumbanils[1].transform.localScale, new Vector2(1, 1), 0.1f);
            LevelThumbanils[2].transform.localScale = Vector2.Lerp(LevelThumbanils[2].transform.localScale, new Vector2(1, 1), 0.1f);
            LevelThumbanils[3].transform.localScale = Vector2.Lerp(LevelThumbanils[3].transform.localScale, new Vector2(1, 1), 0.1f);
            LevelThumbanils[5].transform.localScale = Vector2.Lerp(LevelThumbanils[5].transform.localScale, new Vector2(1, 1), 0.1f);
            LevelThumbanils[6].transform.localScale = Vector2.Lerp(LevelThumbanils[6].transform.localScale, new Vector2(1, 1), 0.1f);
            LevelThumbanils[7].transform.localScale = Vector2.Lerp(LevelThumbanils[7].transform.localScale, new Vector2(1, 1), 0.1f);
        }
        else if (myScrollBar.GetComponent<Scrollbar>().value > 0.617f && myScrollBar.GetComponent<Scrollbar>().value < 0.684f)
        {
            LevelThumbanils[5].transform.localScale = Vector2.Lerp(LevelThumbanils[5].transform.localScale, new Vector2(1.2f, 1.2f), 0.1f);

            LevelThumbanils[0].transform.localScale = Vector2.Lerp(LevelThumbanils[0].transform.localScale, new Vector2(1, 1), 0.1f);
            LevelThumbanils[1].transform.localScale = Vector2.Lerp(LevelThumbanils[1].transform.localScale, new Vector2(1, 1), 0.1f);
            LevelThumbanils[2].transform.localScale = Vector2.Lerp(LevelThumbanils[2].transform.localScale, new Vector2(1, 1), 0.1f);
            LevelThumbanils[4].transform.localScale = Vector2.Lerp(LevelThumbanils[4].transform.localScale, new Vector2(1, 1), 0.1f);
            LevelThumbanils[3].transform.localScale = Vector2.Lerp(LevelThumbanils[3].transform.localScale, new Vector2(1, 1), 0.1f);
            LevelThumbanils[6].transform.localScale = Vector2.Lerp(LevelThumbanils[6].transform.localScale, new Vector2(1, 1), 0.1f);
            LevelThumbanils[7].transform.localScale = Vector2.Lerp(LevelThumbanils[7].transform.localScale, new Vector2(1, 1), 0.1f);
        }
        else if (myScrollBar.GetComponent<Scrollbar>().value > 0.745f && myScrollBar.GetComponent<Scrollbar>().value < 0.812f)
        {
            LevelThumbanils[6].transform.localScale = Vector2.Lerp(LevelThumbanils[6].transform.localScale, new Vector2(1.2f, 1.2f), 0.1f);

            LevelThumbanils[0].transform.localScale = Vector2.Lerp(LevelThumbanils[0].transform.localScale, new Vector2(1, 1), 0.1f);
            LevelThumbanils[1].transform.localScale = Vector2.Lerp(LevelThumbanils[1].transform.localScale, new Vector2(1, 1), 0.1f);
            LevelThumbanils[2].transform.localScale = Vector2.Lerp(LevelThumbanils[2].transform.localScale, new Vector2(1, 1), 0.1f);
            LevelThumbanils[4].transform.localScale = Vector2.Lerp(LevelThumbanils[4].transform.localScale, new Vector2(1, 1), 0.1f);
            LevelThumbanils[5].transform.localScale = Vector2.Lerp(LevelThumbanils[5].transform.localScale, new Vector2(1, 1), 0.1f);
            LevelThumbanils[3].transform.localScale = Vector2.Lerp(LevelThumbanils[3].transform.localScale, new Vector2(1, 1), 0.1f);
            LevelThumbanils[7].transform.localScale = Vector2.Lerp(LevelThumbanils[7].transform.localScale, new Vector2(1, 1), 0.1f);
        }
        else if (myScrollBar.GetComponent<Scrollbar>().value > 0.884f && myScrollBar.GetComponent<Scrollbar>().value < 0.946f)
        {
            LevelThumbanils[7].transform.localScale = Vector2.Lerp(LevelThumbanils[7].transform.localScale, new Vector2(1.2f, 1.2f), 0.1f);

            LevelThumbanils[0].transform.localScale = Vector2.Lerp(LevelThumbanils[0].transform.localScale, new Vector2(1, 1), 0.1f);
            LevelThumbanils[1].transform.localScale = Vector2.Lerp(LevelThumbanils[1].transform.localScale, new Vector2(1, 1), 0.1f);
            LevelThumbanils[2].transform.localScale = Vector2.Lerp(LevelThumbanils[2].transform.localScale, new Vector2(1, 1), 0.1f);
            LevelThumbanils[4].transform.localScale = Vector2.Lerp(LevelThumbanils[4].transform.localScale, new Vector2(1, 1), 0.1f);
            LevelThumbanils[5].transform.localScale = Vector2.Lerp(LevelThumbanils[5].transform.localScale, new Vector2(1, 1), 0.1f);
            LevelThumbanils[3].transform.localScale = Vector2.Lerp(LevelThumbanils[3].transform.localScale, new Vector2(1, 1), 0.1f);
            LevelThumbanils[6].transform.localScale = Vector2.Lerp(LevelThumbanils[6].transform.localScale, new Vector2(1, 1), 0.1f);
        }
        else if (myScrollBar.GetComponent<Scrollbar>().value > 0.946f)
        {
            LevelThumbanils[7].transform.localScale = Vector2.Lerp(LevelThumbanils[7].transform.localScale, new Vector2(1.2f, 1.2f), 0.1f);

            LevelThumbanils[0].transform.localScale = Vector2.Lerp(LevelThumbanils[0].transform.localScale, new Vector2(1, 1), 0.1f);
            LevelThumbanils[1].transform.localScale = Vector2.Lerp(LevelThumbanils[1].transform.localScale, new Vector2(1, 1), 0.1f);
            LevelThumbanils[2].transform.localScale = Vector2.Lerp(LevelThumbanils[2].transform.localScale, new Vector2(1, 1), 0.1f);
            LevelThumbanils[4].transform.localScale = Vector2.Lerp(LevelThumbanils[4].transform.localScale, new Vector2(1, 1), 0.1f);
            LevelThumbanils[5].transform.localScale = Vector2.Lerp(LevelThumbanils[5].transform.localScale, new Vector2(1, 1), 0.1f);
            LevelThumbanils[3].transform.localScale = Vector2.Lerp(LevelThumbanils[3].transform.localScale, new Vector2(1, 1), 0.1f);
            LevelThumbanils[6].transform.localScale = Vector2.Lerp(LevelThumbanils[6].transform.localScale, new Vector2(1, 1), 0.1f);
        }
    }
}
