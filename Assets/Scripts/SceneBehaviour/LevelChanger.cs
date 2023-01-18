using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour
{
    Animator fadeAnimator;
    [SerializeField] VectorValue playerPosition;

    [SerializeField] StartPositions startPositions;

    private void Start()
    {
        fadeAnimator = GetComponent<Animator>();
    }

    public void FadeToLevel()
    {
        fadeAnimator.SetTrigger("fade");
    }

    public void OnFadeComplete()
    {
        if (SceneManager.GetActiveScene().name.Equals("MainScene"))
        {
            playerPosition.SetInitialValue(startPositions.Cafe);
            SceneManager.LoadScene(2);
        }
        if (SceneManager.GetActiveScene().name.Equals("Cafe"))
        {
            playerPosition.SetInitialValue(startPositions.MainScene);
            SceneManager.LoadScene(1);
        }
    }
}
