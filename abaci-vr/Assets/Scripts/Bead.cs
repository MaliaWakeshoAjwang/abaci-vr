using UnityEngine;

public class Bead : MonoBehaviour
{
    public bool isUpperBead;
    public int value;
    public bool isActive = false;

    private Vector3 initialPos;
    private Vector3 activePos;

    private void Start()
    {
        initialPos = transform.position;
        activePos = initialPos + (isUpperBead ? Vector3.down * 0.15f : Vector3.up * 0.15f);
    }

    public void ToggleBead()
    {
        isActive = !isActive;
        transform.position = isActive ? activePos : initialPos;
    }
}