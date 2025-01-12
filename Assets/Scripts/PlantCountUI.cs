using UnityEngine;
using TMPro;

public class PlantCountUI : MonoBehaviour
{
    [SerializeField] private TMP_Text _plantedText;
    [SerializeField] private TMP_Text _remainingText;

    public void UpdateSeeds (int seedsLeft, int seedsPlanted)
    {
        _plantedText.SetText(seedsPlanted.ToString());
        _remainingText.SetText(seedsLeft.ToString());
    }
}