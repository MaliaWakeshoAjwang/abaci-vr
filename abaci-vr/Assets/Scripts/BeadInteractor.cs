using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class BeadInteractor : MonoBehaviour
{
    public XRController controller;
    public LineRenderer lineRenderer;
    public float maxDistance = 10f;

    void Update()
    {
        lineRenderer.SetPosition(0, controller.transform.position);
        lineRenderer.SetPosition(1, controller.transform.position + controller.transform.forward * maxDistance);

        if (controller.inputDevice.TryGetFeatureValue(UnityEngine.XR.CommonUsages.triggerButton, out bool isPressed) && isPressed)
        {
            Ray ray = new Ray(controller.transform.position, controller.transform.forward);
            if (Physics.Raycast(ray, out RaycastHit hit, maxDistance))
            {
                Bead bead = hit.collider.GetComponent<Bead>();
                if (bead != null)
                {
                    bead.ToggleBead();
                }
            }
        }
    }
}