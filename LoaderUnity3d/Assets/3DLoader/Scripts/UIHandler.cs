using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIHandler : MonoBehaviour {

    
    public GameObject circle3dLoader;
    public GameObject ciclle2dLoader;
   
    public Text switchBtnText;
    public Text loadingText;

    private bool is3dState = true;
    private float progressCounter;

    private void Start()
    {
        StartCoroutine(StartProgressCoroutine());
    }

    public void OnSwitchClick() {
        is3dState = !is3dState;
        circle3dLoader.SetActive(is3dState);
        ciclle2dLoader.SetActive(!is3dState);
        if (is3dState) {
            switchBtnText.text = "3D";
        }
        else {
            switchBtnText.text = "2D";
        }
    }

    public void StartProgress() {
        StartCoroutine(StartProgressCoroutine());
    }

    public IEnumerator StartProgressCoroutine() {
        while (progressCounter < 100) {
            progressCounter = progressCounter + 1f ;
            loadingText.text = "LOADING " + progressCounter + "%";
            yield return new WaitForSeconds(0.1f);
        }
        SceneManager.LoadScene("Welcome", LoadSceneMode.Single);
    }

    
}
