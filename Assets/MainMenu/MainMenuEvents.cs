using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
// using U

public class MainMenuEvents : MonoBehaviour
{

    private UIDocument _document;

    private Button StartButton;
    private Button QuitButton;
    private void Awake()
    {
        _document = GetComponent<UIDocument>();
        StartButton = _document.rootVisualElement.Q("StartGameButton") as Button;  
        StartButton.RegisterCallback<ClickEvent>(OnPlayGameClick);

        QuitButton = _document.rootVisualElement.Q("QuitGameButton") as Button;  
        QuitButton.RegisterCallback<ClickEvent>(OnQuitGameClick);

    }

    private void OnDisable()
    {
        StartButton.UnregisterCallback<ClickEvent>(OnPlayGameClick);
    }

    private void OnPlayGameClick(ClickEvent evt)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    private void OnQuitGameClick(ClickEvent evt)
    {
        Application.Quit();
    }
}
