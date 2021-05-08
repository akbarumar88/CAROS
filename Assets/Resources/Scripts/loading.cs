using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor.SceneManagement;
#endif


public class loading : MonoBehaviour {

    public Transform LoadingBar;
    [SerializeField]
    private float currentAmount;
    [SerializeField]
    private float speed;

    //Update is called once per frame
    void Update()
    {
        if (currentAmount < 100)
        {
            currentAmount += speed * Time.deltaTime;
            Debug.Log((int)currentAmount);
        }
        else
        {
            #if UNITY_EDITOR
            EditorSceneManager.LoadScene("main_menu2");
            #endif
        }
        LoadingBar.GetComponent<Image>().fillAmount = currentAmount / 100;
    }

}
