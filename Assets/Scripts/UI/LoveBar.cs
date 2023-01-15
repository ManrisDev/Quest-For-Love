using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class LoveBar : MonoBehaviour
{
    [SerializeField] private Image lovebar;
    [SerializeField] private float fill;
    [SerializeField] UnityEvent Pause;
    [SerializeField] UnityEvent Play;

    public bool onPause = false;
    void Start()
    {
        fill = 1f;
    }


    void Update()
    {
        if (onPause == false)
        {
            DecreaseLove();
        }

    }

    public void IncreaseLove()
    {
            fill += 0.3f;
    }

    public void DecreaseLove()
    {
        lovebar.fillAmount = fill;
        fill -= 0.05f * Time.deltaTime;
    }

    public void StopDecrease()
    {
        onPause = true;
    }

    public void ContinueDecrease()
    {
        onPause = false;
    }
}
