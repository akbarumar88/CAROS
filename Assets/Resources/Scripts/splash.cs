using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor.SceneManagement;
#endif

public class splash : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine(Example());
	}
	
	IEnumerator Example()
    {
        yield return new WaitForSeconds(2);
#if UNITY_EDITOR
        EditorSceneManager.LoadScene("loading");
#endif
    }
}
