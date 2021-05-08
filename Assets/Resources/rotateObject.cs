using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

public class rotateObject : MonoBehaviour
{

    public GameObject camera, microscope, glasses, joglo, saron, indonesian_army, voc_army;

    public float rotateSpeed = 50f;
    bool rotateStatus = false;
    public Toggle rotateBtn;

    public void Rotation()
    {
        if (rotateStatus)
        {
            rotateStatus = false;
        }
        else
        {
            rotateStatus = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        StateManager sm = TrackerManager.Instance.GetStateManager();
        IEnumerable<TrackableBehaviour> tbs = sm.GetActiveTrackableBehaviours();

        foreach (TrackableBehaviour tb in tbs)
        {
            string name = tb.TrackableName;
            ImageTarget it = tb.Trackable as ImageTarget;
            Vector2 size = it.GetSize();

            Debug.Log("Active image target:" + name + "  -size: " + size.x + ", " + size.y);
            if (name == "SLR")
            {
                rotateBtn.gameObject.SetActive(true);
                if (rotateStatus)
                {
                    camera.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
                }
            }
            else if (name == "Microscope")
            {
                rotateBtn.gameObject.SetActive(true);
                if (rotateStatus)
                {
                    microscope.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
                }
            }
            else if (name == "Indonesian_Army")
            {
                rotateBtn.gameObject.SetActive(true);
                if (rotateStatus)
                {
                    indonesian_army.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
                }
            }
            else if (name == "Voc_Army")
            {
                rotateBtn.gameObject.SetActive(true);
                if (rotateStatus)
                {
                    voc_army.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
                }
            }
            else if (name == "Glasses")
            {
                rotateBtn.gameObject.SetActive(true);
                if (rotateStatus)
                {
                    glasses.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
                }
            }
            else if (name == "Joglo")
            {
                rotateBtn.gameObject.SetActive(true);
                if (rotateStatus)
                {
                    joglo.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
                }
            }
            else if (name == "Saron")
            {
                rotateBtn.gameObject.SetActive(true);
                if (rotateStatus)
                {
                    saron.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
                }
            }
            else
            {
                rotateBtn.gameObject.SetActive(false);
            }
        }
    }
}
