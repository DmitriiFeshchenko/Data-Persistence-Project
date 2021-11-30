using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuUIHandler : MonoBehaviour
{
    [SerializeField]
    private Text inputNameText;

    public void StartGameButtonClicked() {
        if (string.IsNullOrEmpty(inputNameText.text)) {
            Debug.Log("User Name cannot be empty");
            return;
        }
        DataManager.Instance.userName = inputNameText.text;
        SceneManager.LoadScene(1);
    }

    public void QuitButtonClicked() {
        #if UNITY_EDITOR
            EditorApplication.ExitPlaymode();
        #else
            Application.Quit();
        #endif
    }
}