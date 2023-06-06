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
    public GameObject ImageChoiceAA;
    public GameObject ImageChoiceAB;
    public GameObject ImageChoiceBA;
    public GameObject ImageChoiceBB;
    public GameObject ImageChoiceAAA;
    public GameObject ImageChoiceAAB;
    public GameObject ImageChoiceABA;
    public GameObject ImageChoiceABB;
    public GameObject ImageChoiceBAA;
    public GameObject ImageChoiceBAB;
    public GameObject ImageChoiceBBA;
    public GameObject ImageChoiceBBB;
    
    public int ChoiceMade;

    public void ChoiceOption1()
    {
        if (ChoiceMade == 0)
        {
            NarratorBox.GetComponent<TextMeshProUGUI>().text = "Amidst the spectrum of shades, where do you find solace?\r\nIn the depths of darkness or light's radiant embrace?\r\nDoes your heart resonate with the mysterious allure,\r\nOr does the brightness of light bring your spirit to endure?";
            AnswerBoxA.GetComponent<TextMeshProUGUI>().text = "Within darkness, whispers echo, secrets softly unfurl,\r\nIts cloak of shadows beckons, a canvas for the hidden world.\r\nA realm of introspection, where depths of thought reside,\r\nIt holds the power to soothe, to let imagination glide.";
            AnswerBoxB.GetComponent<TextMeshProUGUI>().text = "Light reveals the world, unveiling its grand design,\r\nIlluminating the path ahead, making clarity align.\r\nIts radiance brings warmth, a gentle touch of grace,\r\nInviting us to embrace life, to see each vibrant trace.";
            ImageChoiceA.SetActive(true);
            ChoiceMade = 1;
        }
        else if (ChoiceMade == 1)
        {
            NarratorBox.GetComponent<TextMeshProUGUI>().text = "In the vast tapestry of existence, our souls, shaping our perceptions and urge.\r\nSo, share your preference, let it be heard,\r\nFor in the dialogue of tones, our perspectives are stirred.";
            AnswerBoxA.GetComponent<TextMeshProUGUI>().text = "In this vast tapestry of existence, where our souls intertwine,\r\nOur preferences, like brushstrokes, define the hues that align.\r\nAs for me, I find solace in the interplay of both,\r\nEmbracing the duality, cherishing their growth.";
            AnswerBoxB.GetComponent<TextMeshProUGUI>().text = "My preference leans towards the depths of darkness' embrace,\r\nWhere introspection thrives, unveiling mysteries in its trace.\r\nYet, light's radiance also holds a special place in my heart,\r\nIlluminating the path, igniting hope, a vibrant start.";
            ImageChoiceA.SetActive(false);
            ImageChoiceAA.SetActive(true);
            ChoiceMade = 3;
        }
        else if (ChoiceMade == 2)
        {
            NarratorBox.GetComponent<TextMeshProUGUI>().text = "In the vast tapestry of existence, our souls, shaping our perceptions and urge.\r\nSo, share your preference, let it be heard,\r\nFor in the dialogue of tones, our perspectives are stirred.";
            AnswerBoxA.GetComponent<TextMeshProUGUI>().text = "In this vast tapestry of existence, where our souls intertwine,\r\nOur preferences, like brushstrokes, define the hues that align.\r\nAs for me, I find solace in the interplay of both,\r\nEmbracing the duality, cherishing their growth.";
            AnswerBoxB.GetComponent<TextMeshProUGUI>().text = "My preference leans towards the depths of darkness' embrace,\r\nWhere introspection thrives, unveiling mysteries in its trace.\r\nYet, light's radiance also holds a special place in my heart,\r\nIlluminating the path, igniting hope, a vibrant start.";
            ImageChoiceB.SetActive(false);
            ImageChoiceBA.SetActive(true);
            ChoiceMade = 5;
        }
        else if (ChoiceMade == 3) //4 wyniki - razem 8
        {
            NarratorBox.GetComponent<TextMeshProUGUI>().text = "In the tapestry of life, a soul so mature,\r\nAn outgoing spirit, radiating allure.\r\nWith wisdom as their guide, they navigate the fray,\r\nEmbracing the world, in their own unique way.";
            AnswerBoxA.GetComponent<TextMeshProUGUI>().text = "Yet, in every ending, there's a glimmer of rebirth,\r\nA chance to start anew, to reshape our own worth.\r\nFor as one door closes, another one unfolds,\r\nUnveiling opportunities, yet to be untold.";
            AnswerBoxB.GetComponent<TextMeshProUGUI>().text = "In the tapestry of life, where stories unfold,\r\nWe reach the final chapter, where destinies are told.\r\nAn ending, bittersweet, like the setting sun's glow,\r\nA moment of closure, as new paths we'll sow.";
            ImageChoiceA.SetActive(false);
            ImageChoiceAA.SetActive(false);
            ImageChoiceAAA.SetActive(true);
            ChoiceMade = 7;
        }
        else if (ChoiceMade == 4)
        {
            NarratorBox.GetComponent<TextMeshProUGUI>().text = "In the tapestry of life, a soul so mature,\r\nAn outgoing spirit, radiating allure.\r\nWith wisdom as their guide, they navigate the fray,\r\nEmbracing the world, in their own unique way.";
            AnswerBoxA.GetComponent<TextMeshProUGUI>().text = "Yet, in every ending, there's a glimmer of rebirth,\r\nA chance to start anew, to reshape our own worth.\r\nFor as one door closes, another one unfolds,\r\nUnveiling opportunities, yet to be untold.";
            AnswerBoxB.GetComponent<TextMeshProUGUI>().text = "In the tapestry of life, where stories unfold,\r\nWe reach the final chapter, where destinies are told.\r\nAn ending, bittersweet, like the setting sun's glow,\r\nA moment of closure, as new paths we'll sow.";
            ImageChoiceA.SetActive(false);
            ImageChoiceAB.SetActive(false);
            ImageChoiceABA.SetActive(true);
            ChoiceMade = 9;
        }
        else if (ChoiceMade == 5)
        {
            NarratorBox.GetComponent<TextMeshProUGUI>().text = "In the tapestry of life, a soul so mature,\r\nAn outgoing spirit, radiating allure.\r\nWith wisdom as their guide, they navigate the fray,\r\nEmbracing the world, in their own unique way.";
            AnswerBoxA.GetComponent<TextMeshProUGUI>().text = "Yet, in every ending, there's a glimmer of rebirth,\r\nA chance to start anew, to reshape our own worth.\r\nFor as one door closes, another one unfolds,\r\nUnveiling opportunities, yet to be untold.";
            AnswerBoxB.GetComponent<TextMeshProUGUI>().text = "In the tapestry of life, where stories unfold,\r\nWe reach the final chapter, where destinies are told.\r\nAn ending, bittersweet, like the setting sun's glow,\r\nA moment of closure, as new paths we'll sow.";
            ImageChoiceB.SetActive(false);
            ImageChoiceBA.SetActive(false);
            ImageChoiceBAA.SetActive(true);
            ChoiceMade = 11;
        }
        else if (ChoiceMade == 6)
        {
            NarratorBox.GetComponent<TextMeshProUGUI>().text = "In the tapestry of life, a soul so mature,\r\nAn outgoing spirit, radiating allure.\r\nWith wisdom as their guide, they navigate the fray,\r\nEmbracing the world, in their own unique way.";
            AnswerBoxA.GetComponent<TextMeshProUGUI>().text = "Yet, in every ending, there's a glimmer of rebirth,\r\nA chance to start anew, to reshape our own worth.\r\nFor as one door closes, another one unfolds,\r\nUnveiling opportunities, yet to be untold.";
            AnswerBoxB.GetComponent<TextMeshProUGUI>().text = "In the tapestry of life, where stories unfold,\r\nWe reach the final chapter, where destinies are told.\r\nAn ending, bittersweet, like the setting sun's glow,\r\nA moment of closure, as new paths we'll sow.";
            ImageChoiceB.SetActive(false);
            ImageChoiceBB.SetActive(false);
            ImageChoiceBBA.SetActive(true);
            ChoiceMade = 13;
        }

    }

    public void ChoiceOption2()
    {
        if (ChoiceMade == 0)
        {
            NarratorBox.GetComponent<TextMeshProUGUI>().text = "Amidst the spectrum of shades, where do you find solace?\r\nIn the depths of darkness or light's radiant embrace?\r\nDoes your heart resonate with the mysterious allure,\r\nOr does the brightness of light bring your spirit to endure?";
            AnswerBoxA.GetComponent<TextMeshProUGUI>().text = "Within darkness, whispers echo, secrets softly unfurl,\r\nIts cloak of shadows beckons, a canvas for the hidden world.\r\nA realm of introspection, where depths of thought reside,\r\nIt holds the power to soothe, to let imagination glide.";
            AnswerBoxB.GetComponent<TextMeshProUGUI>().text = "Light reveals the world, unveiling its grand design,\r\nIlluminating the path ahead, making clarity align.\r\nIts radiance brings warmth, a gentle touch of grace,\r\nInviting us to embrace life, to see each vibrant trace.";
            ImageChoiceB.SetActive(true);
            ChoiceMade = 2;
        }
        else if (ChoiceMade == 1)
        {
            NarratorBox.GetComponent<TextMeshProUGUI>().text = "In the vast tapestry of existence, our souls, shaping our perceptions and urge.\r\nSo, share your preference, let it be heard,\r\nFor in the dialogue of tones, our perspectives are stirred.";
            AnswerBoxA.GetComponent<TextMeshProUGUI>().text = "In this vast tapestry of existence, where our souls intertwine,\r\nOur preferences, like brushstrokes, define the hues that align.\r\nAs for me, I find solace in the interplay of both,\r\nEmbracing the duality, cherishing their growth.";
            AnswerBoxB.GetComponent<TextMeshProUGUI>().text = "My preference leans towards the depths of darkness' embrace,\r\nWhere introspection thrives, unveiling mysteries in its trace.\r\nYet, light's radiance also holds a special place in my heart,\r\nIlluminating the path, igniting hope, a vibrant start.";
            ImageChoiceA.SetActive(false);
            ImageChoiceAB.SetActive(true);
            ChoiceMade = 4;
        }
        else if (ChoiceMade == 2)
        {
            NarratorBox.GetComponent<TextMeshProUGUI>().text = "In the vast tapestry of existence, our souls, shaping our perceptions and urge.\r\nSo, share your preference, let it be heard,\r\nFor in the dialogue of tones, our perspectives are stirred.";
            AnswerBoxA.GetComponent<TextMeshProUGUI>().text = "In this vast tapestry of existence, where our souls intertwine,\r\nOur preferences, like brushstrokes, define the hues that align.\r\nAs for me, I find solace in the interplay of both,\r\nEmbracing the duality, cherishing their growth.";
            AnswerBoxB.GetComponent<TextMeshProUGUI>().text = "My preference leans towards the depths of darkness' embrace,\r\nWhere introspection thrives, unveiling mysteries in its trace.\r\nYet, light's radiance also holds a special place in my heart,\r\nIlluminating the path, igniting hope, a vibrant start.";
            ImageChoiceB.SetActive(false);
            ImageChoiceBB.SetActive(true);
            ChoiceMade = 6;
        }
        else if (ChoiceMade == 3) //4 wyniki - razem 8
        {
            NarratorBox.GetComponent<TextMeshProUGUI>().text = "Amidst nature's embrace, where serenity blooms,\r\nA dialogue unfolds, between quiet souls in secluded rooms.\r\nThe introvert's heart finds solace in its gentle sway,\r\nA refuge of peace, where thoughts can freely play.";
            AnswerBoxA.GetComponent<TextMeshProUGUI>().text = "Yet, in every ending, there's a glimmer of rebirth,\r\nA chance to start anew, to reshape our own worth.\r\nFor as one door closes, another one unfolds,\r\nUnveiling opportunities, yet to be untold.";
            AnswerBoxB.GetComponent<TextMeshProUGUI>().text = "In the tapestry of life, where stories unfold,\r\nWe reach the final chapter, where destinies are told.\r\nAn ending, bittersweet, like the setting sun's glow,\r\nA moment of closure, as new paths we'll sow.";
            ImageChoiceA.SetActive(false);
            ImageChoiceAA.SetActive(false);
            ImageChoiceAAB.SetActive(true);
            ChoiceMade = 8;
        }
        else if (ChoiceMade == 4)
        {
            NarratorBox.GetComponent<TextMeshProUGUI>().text = "Amidst nature's embrace, where serenity blooms,\r\nA dialogue unfolds, between quiet souls in secluded rooms.\r\nThe introvert's heart finds solace in its gentle sway,\r\nA refuge of peace, where thoughts can freely play.";
            AnswerBoxA.GetComponent<TextMeshProUGUI>().text = "Yet, in every ending, there's a glimmer of rebirth,\r\nA chance to start anew, to reshape our own worth.\r\nFor as one door closes, another one unfolds,\r\nUnveiling opportunities, yet to be untold.";
            AnswerBoxB.GetComponent<TextMeshProUGUI>().text = "In the tapestry of life, where stories unfold,\r\nWe reach the final chapter, where destinies are told.\r\nAn ending, bittersweet, like the setting sun's glow,\r\nA moment of closure, as new paths we'll sow.";
            ImageChoiceA.SetActive(false);
            ImageChoiceAB.SetActive(false);
            ImageChoiceABB.SetActive(true);
            ChoiceMade = 10;
        }
        else if (ChoiceMade == 5)
        {
            NarratorBox.GetComponent<TextMeshProUGUI>().text = "The West, a vast canvas painted in hues,\r\nWhere fiery sunsets ignite the skies' muse,\r\nMountains reach for heavens, proud and tall,\r\nWhispering tales of courage, heard by all.";
            AnswerBoxA.GetComponent<TextMeshProUGUI>().text = "Yet, in every ending, there's a glimmer of rebirth,\r\nA chance to start anew, to reshape our own worth.\r\nFor as one door closes, another one unfolds,\r\nUnveiling opportunities, yet to be untold.";
            AnswerBoxB.GetComponent<TextMeshProUGUI>().text = "In the tapestry of life, where stories unfold,\r\nWe reach the final chapter, where destinies are told.\r\nAn ending, bittersweet, like the setting sun's glow,\r\nA moment of closure, as new paths we'll sow.";
            ImageChoiceB.SetActive(false);
            ImageChoiceBB.SetActive(false);
            ImageChoiceBBA.SetActive(true);
            ChoiceMade = 12;
        }
        else if (ChoiceMade == 6)
        {
            NarratorBox.GetComponent<TextMeshProUGUI>().text = "The West, a vast canvas painted in hues,\r\nWhere fiery sunsets ignite the skies' muse,\r\nMountains reach for heavens, proud and tall,\r\nWhispering tales of courage, heard by all.";
            AnswerBoxA.GetComponent<TextMeshProUGUI>().text = "Yet, in every ending, there's a glimmer of rebirth,\r\nA chance to start anew, to reshape our own worth.\r\nFor as one door closes, another one unfolds,\r\nUnveiling opportunities, yet to be untold.";
            AnswerBoxB.GetComponent<TextMeshProUGUI>().text = "In the tapestry of life, where stories unfold,\r\nWe reach the final chapter, where destinies are told.\r\nAn ending, bittersweet, like the setting sun's glow,\r\nA moment of closure, as new paths we'll sow.";
            ImageChoiceB.SetActive(false);
            ImageChoiceBB.SetActive(false);
            ImageChoiceBBB.SetActive(true);
            ChoiceMade = 14;
        }
    }

    void Update()
    {
        if (ChoiceMade >= 1)
        {
            ImageChoice00.SetActive(false);
        }
    }
}
