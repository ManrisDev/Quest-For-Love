using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Settings : MonoBehaviour
{
    [SerializeField] UnityEvent CloseSettings;
    public void Back()
    {
        CloseSettings.Invoke();
    }
}
