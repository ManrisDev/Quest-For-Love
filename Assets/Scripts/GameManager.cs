using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] UnityEvent Pause;
    [SerializeField] UnityEvent Play;

    bool pause = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !pause)
        {
            pause = true;
            PauseGame();
        }
    }
    public void PlayGame()
    {
        pause = false;
        Play.Invoke();
    }
    public void PauseGame()
    {
        Pause.Invoke();
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
