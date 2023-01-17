using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
            Destroy(this.gameObject);
        }
    }

}
