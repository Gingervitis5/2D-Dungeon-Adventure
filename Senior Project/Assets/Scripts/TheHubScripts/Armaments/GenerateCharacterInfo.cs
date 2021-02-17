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
    private Ally generatedCharacter;
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
        generatedCharacter = character;
    }
    public Ally GetGeneratedCharacter()
    {
        return generatedCharacter;
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
            case 5: //Soldier
                GenerateSoldier();
                break;
            case 6: //Operative
                GenerateOperative();
                break;
            case 7: //Delegate
                GenerateDelegate();
                break;
        }
    }

    public void DisplayWildlander()
    {
        Brawn.text = "Brawn: " + generatedCharacter.GetBrawn();
        Agility.text = "Agility: " + generatedCharacter.GetAgility();
        Luck.text = "Luck: " + generatedCharacter.GetLuck();
        Reason.text = "Reason: " + generatedCharacter.GetReason();
        Wit.text = "Wit: " + generatedCharacter.GetWit();
        Glamour.text = "Glamour: " + generatedCharacter.GetGlamour();
        Class.text = "Class: Wildlander";
        TargetGraphic.sprite = DisplayGraphic;
        TargetGraphic.color = new Color(255, 255, 255, 255);
        RecruitCharacter.SetCharacter(generatedCharacter, this.gameObject);
    }
    private void GenerateWildlander()
    {
        if (generatedCharacter == null)
        {
            RandBrawn = Random.Range(14, 21);
            RandAgility = Random.Range(14, 19);
            RandLuck = Random.Range(2, 21);
            RandReason = Random.Range(8, 13);
            RandWit = Random.Range(8, 15);
            RandGlamour = Random.Range(8, 15);
            generatedCharacter = CharacterFactory.CreateNewWildlander(RandBrawn, RandAgility, RandLuck, RandReason, RandWit, RandGlamour);
            generatedCharacter.characterImage = DisplayGraphic;
            generatedCharacter.SetClass("Wildlander");
        }

    }


    public void DisplayTechnician()
    {
        Brawn.text = "Brawn: " + generatedCharacter.GetBrawn();
        Agility.text = "Agility: " + generatedCharacter.GetAgility();
        Luck.text = "Luck: " + generatedCharacter.GetLuck();
        Reason.text = "Reason: " + generatedCharacter.GetReason();
        Wit.text = "Wit: " + generatedCharacter.GetWit();
        Glamour.text = "Glamour: " + generatedCharacter.GetGlamour();
        Class.text = "Class: Technician";
        TargetGraphic.sprite = DisplayGraphic;
        TargetGraphic.color = new Color(255, 255, 255, 255);
        RecruitCharacter.SetCharacter(generatedCharacter, this.gameObject);
    }
    private void GenerateTechnician()
    {
        if (generatedCharacter == null)
        {
            RandBrawn = Random.Range(8, 13);
            RandAgility = Random.Range(10, 15);
            RandLuck = Random.Range(0, 21);
            RandReason = Random.Range(12, 19);
            RandWit = Random.Range(14, 21);
            RandGlamour = Random.Range(10, 15);
            generatedCharacter = CharacterFactory.CreateNewTechnician(RandBrawn, RandAgility, RandLuck, RandReason, RandWit, RandGlamour);
            generatedCharacter.characterImage = DisplayGraphic;
            generatedCharacter.SetClass("Technician");
        }
    }

    public void DisplayScholar()
    {
        Brawn.text = "Brawn: " + generatedCharacter.GetBrawn();
        Agility.text = "Agility: " + generatedCharacter.GetAgility();
        Luck.text = "Luck: " + generatedCharacter.GetLuck();
        Reason.text = "Reason: " + generatedCharacter.GetReason();
        Wit.text = "Wit: " + generatedCharacter.GetWit();
        Glamour.text = "Glamour: " + generatedCharacter.GetGlamour();

        Class.text = "Class: Scholar";
        TargetGraphic.sprite = DisplayGraphic;
        TargetGraphic.color = new Color(255, 255, 255, 255);

        RecruitCharacter.SetCharacter(generatedCharacter, this.gameObject);
    }
    private void GenerateScholar()
    {
        if (generatedCharacter == null)
        {
            RandBrawn = Random.Range(8, 15);
            RandAgility = Random.Range(8, 13);
            RandLuck = Random.Range(2, 21);
            RandReason = Random.Range(12, 21);
            RandWit = Random.Range(14, 21);
            RandGlamour = Random.Range(12, 17);
            generatedCharacter = CharacterFactory.CreateNewScholar(RandBrawn, RandAgility, RandLuck, RandReason, RandWit, RandGlamour);
            generatedCharacter.characterImage = DisplayGraphic;
            generatedCharacter.SetClass("Scholar");
        }
    }
    public void DisplayPsionic()
    {
        Brawn.text = "Brawn: " + generatedCharacter.GetBrawn();
        Agility.text = "Agility: " + generatedCharacter.GetAgility();
        Luck.text = "Luck: " + generatedCharacter.GetLuck();
        Reason.text = "Reason: " + generatedCharacter.GetReason();
        Wit.text = "Wit: " + generatedCharacter.GetWit();
        Glamour.text = "Glamour: " + generatedCharacter.GetGlamour();
        Class.text = "Class: Psionic";
        TargetGraphic.sprite = DisplayGraphic;
        TargetGraphic.color = new Color(255, 255, 255, 255);
        RecruitCharacter.SetCharacter(generatedCharacter, this.gameObject);
    }

    private void GeneratePsionic()
    {
        if (generatedCharacter == null)
        {
            RandBrawn = Random.Range(10, 16);
            RandAgility = Random.Range(10, 13);
            RandLuck = Random.Range(0, 21);
            RandReason = Random.Range(12, 17);
            RandWit = Random.Range(10, 17);
            RandGlamour = Random.Range(12, 19);

            generatedCharacter = CharacterFactory.CreateNewPsionic(RandBrawn, RandAgility, RandLuck, RandReason, RandWit, RandGlamour);
            generatedCharacter.characterImage = DisplayGraphic;
            generatedCharacter.SetClass("Psionic");
        }
    }
    public void DisplaySoldier()
    {
        Brawn.text = "Brawn: " + generatedCharacter.GetBrawn();
        Agility.text = "Agility: " + generatedCharacter.GetAgility();
        Luck.text = "Luck: " + generatedCharacter.GetLuck();
        Reason.text = "Reason: " + generatedCharacter.GetReason();
        Wit.text = "Wit: " + generatedCharacter.GetWit();
        Glamour.text = "Glamour: " + generatedCharacter.GetGlamour();
        Class.text = "Class: Soldier";
        TargetGraphic.sprite = DisplayGraphic;
        TargetGraphic.color = new Color(255, 255, 255, 255);
        RecruitCharacter.SetCharacter(generatedCharacter, this.gameObject);
    }
    private void GenerateSoldier()
    {
        if (generatedCharacter == null)
        {
            int randBrawn = Random.Range(15, 21),
            randAgility = Random.Range(11, 16),
            randLuck = Random.Range(0, 19),
            randReason = Random.Range(9, 14),
            randWit = Random.Range(13, 21),
            randGlamour = Random.Range(11, 15);
            generatedCharacter = CharacterFactory.CreateNewSoldier(randBrawn, randAgility, randLuck, randReason, randWit, randGlamour);
            generatedCharacter.characterImage = DisplayGraphic;
            generatedCharacter.SetClass("Soldier");
        }
    }

    public void DisplayOperative()
    {
        Brawn.text = "Brawn: " + generatedCharacter.GetBrawn();
        Agility.text = "Agility: " + generatedCharacter.GetAgility();
        Luck.text = "Luck: " + generatedCharacter.GetLuck();
        Reason.text = "Reason: " + generatedCharacter.GetReason();
        Wit.text = "Wit: " + generatedCharacter.GetWit();
        Glamour.text = "Glamour: " + generatedCharacter.GetGlamour();
        Class.text = "Class: Operative";
        TargetGraphic.sprite = DisplayGraphic;
        TargetGraphic.color = new Color(255, 255, 255, 255);
        RecruitCharacter.SetCharacter(generatedCharacter, this.gameObject);
    }
    private void GenerateOperative()
    {
        if (generatedCharacter == null)
        {
            int randBrawn = Random.Range(9, 13),
            randAgility = Random.Range(15, 21),
            randLuck = Random.Range(7, 23),
            randReason = Random.Range(9, 15),
            randWit = Random.Range(11, 27),
            randGlamour = Random.Range(9, 15);
            generatedCharacter = CharacterFactory.CreateNewOperative(randBrawn, randAgility, randLuck, randReason, randWit, randGlamour);
            generatedCharacter.characterImage = DisplayGraphic;
            generatedCharacter.SetClass("Operative");
        }
    }

    public void DisplayDelegate()
    {
        Brawn.text = "Brawn: " + generatedCharacter.GetBrawn();
        Agility.text = "Agility: " + generatedCharacter.GetAgility();
        Luck.text = "Luck: " + generatedCharacter.GetLuck();
        Reason.text = "Reason: " + generatedCharacter.GetReason();
        Wit.text = "Wit: " + generatedCharacter.GetWit();
        Glamour.text = "Glamour: " + generatedCharacter.GetGlamour();
        Class.text = "Class: Delegate";
        TargetGraphic.sprite = DisplayGraphic;
        TargetGraphic.color = new Color(255, 255, 255, 255);
        RecruitCharacter.SetCharacter(generatedCharacter, this.gameObject);
    }
    private void GenerateDelegate()
    {
        if (generatedCharacter == null)
        {
            int randBrawn = Random.Range(11, 14),
            randAgility = Random.Range(11, 17),
            randLuck = Random.Range(0, 21),
            randReason = Random.Range(11, 14),
            randWit = Random.Range(11, 17),
            randGlamour = Random.Range(15, 21);
            generatedCharacter = CharacterFactory.CreateNewDelegate(randBrawn, randAgility, randLuck, randReason, randWit, randGlamour);
            generatedCharacter.characterImage = DisplayGraphic;
            generatedCharacter.SetClass("Delegate");
        }
    }
}
