using System.Collections;
using System.Collections.Generic;
using AssemblyCSharp.Assets.Scripts.Classes;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GenerateCharacterInfo : MonoBehaviour
{
    private Image TargetGraphic;
    public Sprite DisplayGraphic;
    private TextMeshProUGUI Brawn, Agility, Luck, Reason, Wit, Glamour, Class;
    private Ally GeneratedCharacter;
    private CharacterFactory CharacterFactory = new CharacterFactory();
    private GameObject RecruitmentPage;
    int RandBrawn,
    RandAgility,
    RandLuck,
    RandReason,
    RandWit,
    RandGlamour;
    public int CharacterToGenerate;

    public void SetGeneratedCharacter(Ally character)
    {
        GeneratedCharacter = character;
    }

    public Ally GetGeneratedCharacter()
    {
        return GeneratedCharacter;
    }

    private void Awake()
    {
        RecruitmentPage = GameObject.FindGameObjectWithTag("Recruitment Page");
        Brawn = RecruitmentPage.transform.Find("Brawn").GetComponent<TextMeshProUGUI>();
        Agility = RecruitmentPage.transform.Find("Agility").GetComponent<TextMeshProUGUI>();
        Luck = RecruitmentPage.transform.Find("Luck").GetComponent<TextMeshProUGUI>();
        Reason = RecruitmentPage.transform.Find("Reason").GetComponent<TextMeshProUGUI>();
        Wit = RecruitmentPage.transform.Find("Wit").GetComponent<TextMeshProUGUI>();
        Glamour = RecruitmentPage.transform.Find("Glamour").GetComponent<TextMeshProUGUI>();
        Class = RecruitmentPage.transform.Find("Class").GetComponent<TextMeshProUGUI>();
        TargetGraphic = RecruitmentPage.transform.Find("CharacterImage").GetComponent<Image>();

        switch (CharacterToGenerate)
        {
            case 1: //Wildlander
                GenerateWildlander();
                break;
            case 2: //Technician
                GenerateTechnician();
                break;
            case 3: //Scholar
                GenerateScholar();
                break;
            case 4: //Psionic
                GeneratePsionic();
                break;
        }
    }

    public void DisplayWildlander()
    {
        Brawn.text = "Brawn: " + GeneratedCharacter.GetBrawn();
        Agility.text = "Agility: " + GeneratedCharacter.GetAgility();
        Luck.text = "Luck: " + GeneratedCharacter.GetLuck();
        Reason.text = "Reason: " + GeneratedCharacter.GetReason();
        Wit.text = "Wit: " + GeneratedCharacter.GetWit();
        Glamour.text = "Glamour: " + GeneratedCharacter.GetGlamour();
        Class.text = "Class: Wildlander";
        TargetGraphic.sprite = DisplayGraphic;
        TargetGraphic.color = new Color(255, 255, 255, 255);
        RecruitCharacter.SetCharacter(GeneratedCharacter, this.gameObject);
    }

    private void GenerateWildlander()
    {
        if (GeneratedCharacter == null)
        {
            RandBrawn = Random.Range(14, 21);
            RandAgility = Random.Range(14, 19);
            RandLuck = Random.Range(2, 21);
            RandReason = Random.Range(8, 13);
            RandWit = Random.Range(8, 15);
            RandGlamour = Random.Range(8, 15);
            GeneratedCharacter = CharacterFactory.CreateNewWildlander(RandBrawn, RandAgility, RandLuck, RandReason, RandWit, RandGlamour);
            GeneratedCharacter.CharacterImage = DisplayGraphic;
            GeneratedCharacter.SetClass("Wildlander");
        }
        
    }

    public void DisplayTechnician()
    {
        Brawn.text = "Brawn: " + GeneratedCharacter.GetBrawn();
        Agility.text = "Agility: " + GeneratedCharacter.GetAgility();
        Luck.text = "Luck: " + GeneratedCharacter.GetLuck();
        Reason.text = "Reason: " + GeneratedCharacter.GetReason();
        Wit.text = "Wit: " + GeneratedCharacter.GetWit();
        Glamour.text = "Glamour: " + GeneratedCharacter.GetGlamour();
        Class.text = "Class: Technician";
        TargetGraphic.sprite = DisplayGraphic;
        TargetGraphic.color = new Color(255, 255, 255, 255);
        RecruitCharacter.SetCharacter(GeneratedCharacter, this.gameObject);
    }

    private void GenerateTechnician()
    {
        if (GeneratedCharacter == null)
        {
            RandBrawn = Random.Range(8, 13);
            RandAgility = Random.Range(10, 15);
            RandLuck = Random.Range(0, 21);
            RandReason = Random.Range(12, 19);
            RandWit = Random.Range(14, 21);
            RandGlamour = Random.Range(10, 15);
            GeneratedCharacter = CharacterFactory.CreateNewTechnician(RandBrawn, RandAgility, RandLuck, RandReason, RandWit, RandGlamour);
            GeneratedCharacter.CharacterImage = DisplayGraphic;
            GeneratedCharacter.SetClass("Technician");
        }
    }

    public void DisplayScholar()
    {
        Brawn.text = "Brawn: " + GeneratedCharacter.GetBrawn();
        Agility.text = "Agility: " + GeneratedCharacter.GetAgility();
        Luck.text = "Luck: " + GeneratedCharacter.GetLuck();
        Reason.text = "Reason: " + GeneratedCharacter.GetReason();
        Wit.text = "Wit: " + GeneratedCharacter.GetWit();
        Glamour.text = "Glamour: " + GeneratedCharacter.GetGlamour();
        Class.text = "Class: Scholar";
        TargetGraphic.sprite = DisplayGraphic;
        TargetGraphic.color = new Color(255, 255, 255, 255);
        RecruitCharacter.SetCharacter(GeneratedCharacter, this.gameObject);
    }

    private void GenerateScholar()
    {
        if (GeneratedCharacter == null)
        {
            RandBrawn = Random.Range(8, 15);
            RandAgility = Random.Range(8, 13);
            RandLuck = Random.Range(2, 21);
            RandReason = Random.Range(12, 21);
            RandWit = Random.Range(14, 21);
            RandGlamour = Random.Range(12, 17);

            GeneratedCharacter = CharacterFactory.CreateNewScholar(RandBrawn, RandAgility, RandLuck, RandReason, RandWit, RandGlamour);
            GeneratedCharacter.CharacterImage = DisplayGraphic;
            GeneratedCharacter.SetClass("Scholar");
        }
    }

    public void DisplayPsionic()
    {
        Brawn.text = "Brawn: " + GeneratedCharacter.GetBrawn();
        Agility.text = "Agility: " + GeneratedCharacter.GetAgility();
        Luck.text = "Luck: " + GeneratedCharacter.GetLuck();
        Reason.text = "Reason: " + GeneratedCharacter.GetReason();
        Wit.text = "Wit: " + GeneratedCharacter.GetWit();
        Glamour.text = "Glamour: " + GeneratedCharacter.GetGlamour();
        Class.text = "Class: Psionic";
        TargetGraphic.sprite = DisplayGraphic;
        TargetGraphic.color = new Color(255, 255, 255, 255);
        RecruitCharacter.SetCharacter(GeneratedCharacter, this.gameObject);
    }

    private void GeneratePsionic()
    {
        if (GeneratedCharacter == null)
        {
            RandBrawn = Random.Range(10, 16);
            RandAgility = Random.Range(10, 13);
            RandLuck = Random.Range(0, 21);
            RandReason = Random.Range(12, 17);
            RandWit = Random.Range(10, 17);
            RandGlamour = Random.Range(12, 19);

            GeneratedCharacter = CharacterFactory.CreateNewPsionic(RandBrawn, RandAgility, RandLuck, RandReason, RandWit, RandGlamour);
            GeneratedCharacter.CharacterImage = DisplayGraphic;
            GeneratedCharacter.SetClass("Psionic");
        }
    }
}
