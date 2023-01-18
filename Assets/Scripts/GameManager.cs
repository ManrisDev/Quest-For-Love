using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [Header("Events")]
    [SerializeField] UnityEvent Pause;
    [SerializeField] UnityEvent Play;
    [SerializeField] UnityEvent OpenInventory;
    [SerializeField] UnityEvent CloseInventory;

    bool pause = false;
    bool inventory = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !pause && !inventory)
            PauseGame();

        if (Input.GetKeyDown(KeyCode.I) && !pause && !inventory)
            Inventory();
    }

    public void PlayGame()
    {
        pause = false;
        Play.Invoke();
    }
    public void PauseGame()
    {
        pause = true;
        Pause.Invoke();
    }
    
    public void Inventory()
    {
        inventory = true;
        OpenInventory.Invoke();
    }

    public void BackFromInventory()
    {
        inventory = false;
        CloseInventory.Invoke();
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
