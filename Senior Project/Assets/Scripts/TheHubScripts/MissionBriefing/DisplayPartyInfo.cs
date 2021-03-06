﻿using AssemblyCSharp.Assets.Scripts.Classes;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DisplayPartyInfo : MonoBehaviour
{
    private Ally character;
    private Image TargetGraphic;
    public Sprite DisplayGraphic;
    private TextMeshProUGUI Level, Brawn, Agility, Luck, Reason, Wit, Glamour, Class;
    private TextMeshProUGUI WeaponName, Damage, Handling, Type;
    private GameObject PartySelect;
    private Canvas MBCanvas;

    public void Awake()
    {
        MBCanvas = GameObject.Find("MissionBriefingCanvas").GetComponent<Canvas>();
        PartySelect = MBCanvas.transform.Find("Party Select").gameObject;
        Debug.Log(PartySelect);
        Level = PartySelect.transform.Find("Level").GetComponent<TextMeshProUGUI>();
        Brawn = PartySelect.transform.Find("Brawn").GetComponent<TextMeshProUGUI>();
        Agility = PartySelect.transform.Find("Agility").GetComponent<TextMeshProUGUI>();
        Luck = PartySelect.transform.Find("Luck").GetComponent<TextMeshProUGUI>();
        Reason = PartySelect.transform.Find("Reason").GetComponent<TextMeshProUGUI>();
        Wit = PartySelect.transform.Find("Wit").GetComponent<TextMeshProUGUI>();
        Glamour = PartySelect.transform.Find("Glamour").GetComponent<TextMeshProUGUI>();
        Class = PartySelect.transform.Find("Class").GetComponent<TextMeshProUGUI>();
        TargetGraphic = PartySelect.transform.Find("CharacterImage").GetComponent<Image>();
    }

    public void SetCharacter(Ally a)
    {
        character = a;
    }

    public Ally GetCharacter()
    {
        return character;
    }

    public void DisplayCharacter()
    {
        Debug.Log(character);
        Level.text = "Level: " + character.GetLevel();
        Brawn.text = "Brawn: " + character.GetBrawn();
        Agility.text = "Agility: " + character.GetAgility();
        Luck.text = "Luck: " + character.GetLuck();
        Reason.text = "Reason: " + character.GetReason();
        Wit.text = "Wit: " + character.GetWit();
        Glamour.text = "Glamour: " + character.GetGlamour();
        Class.text = "Class: " + character.GetClass();

        TargetGraphic.sprite = DisplayGraphic;
        TargetGraphic.color = new Color(255, 255, 255, 255);

    }
}
