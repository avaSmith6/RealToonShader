using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EndScreenManager : MonoBehaviour
{
    [SerializeField]    private Slider ratingSlider;
    [SerializeField] private TextMeshProUGUI ratingText;

    void Update()
    {
        ratingText.text = "RATING: " + ratingSlider.value;
    }
}
