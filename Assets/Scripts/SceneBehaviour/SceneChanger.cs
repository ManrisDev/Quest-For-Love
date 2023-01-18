using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    Animator fadeAnimator;

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
            SceneManager.LoadScene(2);
        }
        if (SceneManager.GetActiveScene().name.Equals("Cafe"))
        {
            SceneManager.LoadScene(1);
        }
    }
}
