using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace DialogueSystem
{
    public class DialogBaseClass : MonoBehaviour
    {
        protected IEnumerator WriteText(string input, TMP_Text textHolder, float delay)
        {

            for (int i = 0; i < input.Length; i++)
            {
                textHolder.text += input[i];
                yield return new WaitForSeconds(delay);
            }
        }
    }

}