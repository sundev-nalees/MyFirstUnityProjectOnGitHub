using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChange : MonoBehaviour
{
    public Button button;
    public string newScene;
    private void Start()
    {
        button.onClick.AddListener(onButtonClick);
    }
    private void onButtonClick() 
    {
        SceneManager.LoadScene(newScene);
    }
}
