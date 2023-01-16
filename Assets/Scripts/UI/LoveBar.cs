using UnityEngine;
using UnityEngine.UI;

public class LoveBar : MonoBehaviour
{
    Cat cat;

    [SerializeField] private Image lovebar;
    
    private float fill;
    private bool stopDecrease = false;

    private void Awake() =>  cat = GetComponent<Cat>();

    void Start() => fill = cat.GetHeaalth() / 100;

    void Update()
    {
        if (stopDecrease == false) 
            DecreaseLove();
    }

    public void IncreaseLove()
    {
        //fill += 0.3f;
    }

    public void DecreaseLove()
    {
        lovebar.fillAmount = fill;
        fill -= 0.03f * Time.deltaTime;
    }

    public void StopDecrease()
    {
        stopDecrease = true;
    }

    public void ContinueDecrease()
    {
        stopDecrease = false;
    }
}
