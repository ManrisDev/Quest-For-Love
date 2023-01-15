using UnityEngine;
using UnityEngine.UI;

public class LoveBar : MonoBehaviour
{
    [SerializeField] private Image lovebar;
    [SerializeField] private float fill;

    private bool onPause = true;
    private float fillStop;

    void Start()
    {
        fill = 1f;
    }


    void Update()
    {
        if (!onPause)
        {
            lovebar.fillAmount = fill;
            fill -= 0.05f * Time.deltaTime;

            if (Input.GetButtonDown("Jump"))
            {
                IncreaseLove();
            }
        }
        
        if (onPause)
        {

        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            onPause = false;
        }

    }

    public void IncreaseLove()
    {
            fill += 0.3f;
    }
}
