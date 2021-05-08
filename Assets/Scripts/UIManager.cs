using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour {
    public Toggle bgmToggle;

    public void muteAudio(AudioSource audio)
    {
        if (bgmToggle.isOn)
        {
            audio.Pause();
        }
        else
        {
            audio.Play();
        }
    }

    public void disableBoolInAnimator(Animator anim)
    {
        anim.SetBool("isDisplayed", false);
    }

    public void enableBoolInAnimator(Animator anim)
    {
        anim.SetBool("isDisplayed", true);
    }

    public void navigateTo(string scene)
    {
        SceneManager.LoadScene(scene);
    }

    public void quitGame()
    {
        Debug.Log("Quit !");
        Application.Quit();
    }

    //Delay Functions
    IEnumerator delaySceneLoad(string scene)
    {
        yield return new WaitForSeconds(0.3f);
        SceneManager.LoadScene(scene);
    }

    public void navigateToWithDelay(string scene)
    {
        StartCoroutine(delaySceneLoad(scene));
    }

    IEnumerator delayDisableCanvasGroup(CanvasGroup cg)
    {
        yield return new WaitForSeconds(0.3f);
        cg.gameObject.SetActive(false);
    }

    public void disableCanvasGroup(CanvasGroup cg)
    {
        StartCoroutine(delayDisableCanvasGroup(cg));
    }

    IEnumerator delayEnableCanvasGroup(CanvasGroup cg)
    {
        yield return new WaitForSeconds(0.3f);
        cg.gameObject.SetActive(true);
    }

    public void enableCanvasGroup(CanvasGroup cg)
    {
        StartCoroutine(delayEnableCanvasGroup(cg));
    }

    IEnumerator delayResetScrollbarValue(Scrollbar scr)
    {
        yield return new WaitForSeconds(0.3f);
        scr.value = 0;
    }

    public void resetScrollbarValue(Scrollbar scr)
    {
        StartCoroutine(delayResetScrollbarValue(scr));
    }

}
