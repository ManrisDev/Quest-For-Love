using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField] GameObject menuPanel;
    [SerializeField] GameObject settingsPanel;

    public void StartGame()
    {
        Debug.Log("Старт");
        SceneManager.LoadScene("MainScene");
    }

    public void Settings()
    {
        Debug.Log("Настройки");
        menuPanel.SetActive(false);
        settingsPanel.SetActive(true);
    }

    public void Quit()
    {
        Debug.Log("Выход");
        Application.Quit();
    }

    public void Back()
    {
        menuPanel.SetActive(true);
        settingsPanel.SetActive(false);
    }
}
