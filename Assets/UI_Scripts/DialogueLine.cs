using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace DialogueSystem
{
    public class DialogueLine : DialogBaseClass
    {
        private TMP_Text textHolder;
        [SerializeField] private string input;

        [Header("Time parameters")]
        [SerializeField] private float delay;

        private void Awake()
        {
            textHolder = GetComponent<TMP_Text>();

            input = textHolder.text;
            textHolder.text = null;

            StartCoroutine(WriteText(input, textHolder, delay));
        }
    }
}

