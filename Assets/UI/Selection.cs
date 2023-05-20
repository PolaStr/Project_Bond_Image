using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Selection : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI myTextElement;

   public void SelectionMouse()
    {
        myTextElement.color = Color.white;    }
}
