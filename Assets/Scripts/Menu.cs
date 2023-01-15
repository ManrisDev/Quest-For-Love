using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField] UnityEvent OpenSettings;

    public void StartGame()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void OpenSettingsPanel()
    {
        OpenSettings.Invoke();
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
