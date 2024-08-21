using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using TMPro;
using Microsoft.Unity.VisualStudio.Editor;
using Image = UnityEngine.UI.Image;

public class CharacterSelect : MonoBehaviour
{
    //this is in our project folder
    [Header ("In Project Folder")]
    public Character currentCharacter; //refer to the scriptable objs


    [Header("In the heirarchy")] // this is in our heirarchy
    public GameObject visuals;
    public TextMeshProUGUI characterDescription;
    public TextMeshProUGUI characterName;
    public Image characterImage;//refer to the image in editor


    // Update is called once per frame
    public void UpdateCharacter(Character character)
    {

        visuals.SetActive(true);
        currentCharacter = character;
        characterImage.sprite = currentCharacter.characterSprite;
        characterDescription.text = currentCharacter.characterDescription;
        characterName.text = currentCharacter.characterName;
    }

    public void HideCharacter()
    {
        visuals.SetActive(false);
    }
}
