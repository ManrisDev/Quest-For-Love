using UnityEngine;

public class FrameSwitch : MonoBehaviour
{
    [SerializeField] GameObject activeFrame;
    [SerializeField] Cat catPosition;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            activeFrame.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            //if (activeFrame.name.Equals("StartFrame"))
                //catPosition.transform.position = new Vector3(-41.33f, -2.09f, 0f); 
            activeFrame.SetActive(false);
        }
    }
}
