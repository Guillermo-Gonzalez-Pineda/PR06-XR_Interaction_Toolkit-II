using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class MensajeAlAgarrar : MonoBehaviour
{
    private XRGrabInteractable grab;

    private void Awake()
    {
        // Obtener componente interactuable
        grab = GetComponent<XRGrabInteractable>();

        // Registrar evento
        grab.selectEntered.AddListener(OnGrab);
    }

    private void OnGrab(SelectEnterEventArgs args)
    {
        Debug.Log("Has agarrado el cubo cercano con un Direct Interactor");
    }
}
