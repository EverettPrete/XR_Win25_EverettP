using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactors;
using System;

[RequireComponent(typeof(XRGrabInteractable))]
public class Blade : MonoBehaviour
{
    public XRGrabInteractable m_grabInteractable;
    public ControllerDataReader m_controllerDataReader;
    XRBaseInteractor m_interactor;

    private void Awake()
    {
        m_grabInteractable = GetComponent<XRGrabInteractable>();
    }
    private void OnEnable()
    {
        if (m_grabInteractable == null)
            return;

        m_grabInteractable.selectEntered.AddListener(OnSelectEnter);
        m_grabInteractable.selectEntered.AddListener(ResetControllerDataReader);
    }

    private void ResetControllerDataReader(SelectEnterEventArgs arg0)
    {
        m_controllerDataReader = null;
    }

    private void OnSelectEnter(SelectEnterEventArgs arg0)
    {

        m_interactor = arg0.interactorObject as XRBaseInteractor;


        m_controllerDataReader = m_interactor.gameObject.GetComponent<ControllerDataReader>();
    }

    private void OnDisable()
    {
        if (m_grabInteractable == null)
            return;

        m_grabInteractable.selectEntered.AddListener(OnSelectEnter);
        m_grabInteractable.selectEntered.AddListener(ResetControllerDataReader);
    }
}
