using UnityEngine;
using TMPro;

public class AbacusValue : MonoBehaviour
{
    public Bead[] beads;
    public TextMeshProUGUI valueDisplay;

    void Update()
    {
        int total = 0;
        foreach (Bead bead in beads)
        {
            if (bead.isActive)
                total += bead.value;
        }
        valueDisplay.text = $"Total: {total}";
    }
}