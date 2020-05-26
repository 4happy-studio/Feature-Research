using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class InteractableObject : MonoBehaviour
{
    public GameObject textUI;
    public UnityEvent m_MyEvent;

    private void Start()
    {
        if (m_MyEvent == null)
            m_MyEvent = new UnityEvent();

    }
    private void OnTriggerEnter(Collider other)
    {
        textUI.SetActive(true);
    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E) && m_MyEvent != null)
        {
            m_MyEvent.Invoke();
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && m_MyEvent != null)
        {
            m_MyEvent.Invoke();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        textUI.SetActive(false);
    }
}
