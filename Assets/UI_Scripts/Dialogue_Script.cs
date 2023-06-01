using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Dialogue_Script : MonoBehaviour
{
    public GameObject NarratorBox;
    public GameObject AnswerBoxA;
    public GameObject AnswerBoxB;
    public GameObject ImageChoice00;
    public GameObject ImageChoiceA;
    public GameObject ImageChoiceB;
    public int ChoiceMade;

    public void ChoiceOption1 ()
    {
        NarratorBox.GetComponent<TextMeshProUGUI>().text = "A";
        AnswerBoxA.GetComponent<TextMeshProUGUI>().text = "Ala ma kota";
        AnswerBoxB.GetComponent<TextMeshProUGUI>().text = "Ala ma psa";
        ChoiceMade = 1;
    }

    public void ChoiceOption2()
    {
        NarratorBox.GetComponent<TextMeshProUGUI>().text = "Baaaka lol u hehe";
        AnswerBoxA.GetComponent<TextMeshProUGUI>().text = "Bla";
        AnswerBoxB.GetComponent<TextMeshProUGUI>().text = "bla bla";
        ChoiceMade = 2;
    }

    void Update()
    {
        if (ChoiceMade >= 1)
        {
            ImageChoice00.SetActive(false);
        }
    }
}
