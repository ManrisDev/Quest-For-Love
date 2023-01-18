using UnityEngine;

public class LightBehaviour : MonoBehaviour
{
    [SerializeField] GameObject[] lights;

    [SerializeField] bool turnLight;

    private void Update()
    {
        foreach(GameObject light in lights)
            light.SetActive(turnLight);
    }
}
