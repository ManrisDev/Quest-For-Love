using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField] GameObject menuPanel;
    [SerializeField] GameObject settingsPanel;

    public void StartGame()
    {
        Debug.Log("�����");
        SceneManager.LoadScene("MainScene");
    }

    public void Settings()
    {
        Debug.Log("���������");
        menuPanel.SetActive(false);
        settingsPanel.SetActive(true);
    }

    public void Quit()
    {
        Debug.Log("�����");
        Application.Quit();
    }

    public void Back()
    {
        menuPanel.SetActive(true);
        settingsPanel.SetActive(false);
    }
}
