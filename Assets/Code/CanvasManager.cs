using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CanvasManager : MonoBehaviour
{
    public TMP_Text currentHealth;
    public TMP_Text healthPercentage;
    

    public playerMovement playerMovement;

    void Update()
    {
        currentHealth.text = "Health: " + playerMovement.currentHealth;
    }
}
