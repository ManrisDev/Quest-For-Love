using UnityEngine;
using UnityEngine.UI;

public class LoveBar : MonoBehaviour
{
    [SerializeField] private Image lovebar;
    [SerializeField] private float fill;

    void Start()
    {
        fill = 1f;
    }


    void Update()
    {
        lovebar.fillAmount = fill;
        fill -= 0.05f * Time.deltaTime;
    }

    public void IncreaseLove()
    {
        fill += 0.3f;
    }
}
