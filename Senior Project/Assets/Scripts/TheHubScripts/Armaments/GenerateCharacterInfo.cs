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
    private CharacterFactory characterFactory = new CharacterFactory();
    private GameObject RecruitmentPage;
    int randBrawn,
    randAgility,
    randLuck,
    randReason,
    randWit,
    randGlamour;
    public int characterToGenerate;

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

        switch (characterToGenerate)
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
            randBrawn = Random.Range(14, 21);
            randAgility = Random.Range(14, 19);
            randLuck = Random.Range(2, 21);
            randReason = Random.Range(8, 13);
            randWit = Random.Range(8, 15);
            randGlamour = Random.Range(8, 15);
            generatedCharacter = characterFactory.CreateNewWildlander(randBrawn, randAgility, randLuck, randReason, randWit, randGlamour);
            generatedCharacter.CharacterImage = DisplayGraphic;
            generatedCharacter.SetClass("Wildlander");
            Debug.Log(RecruitCharacter.GetCharacter().CharacterName);
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
            randBrawn = Random.Range(8, 13);
            randAgility = Random.Range(10, 15);
            randLuck = Random.Range(0, 21);
            randReason = Random.Range(12, 19);
            randWit = Random.Range(14, 21);
            randGlamour = Random.Range(10, 15);
            generatedCharacter = characterFactory.CreateNewTechnician(randBrawn, randAgility, randLuck, randReason, randWit, randGlamour);
            generatedCharacter.CharacterImage = DisplayGraphic;
            generatedCharacter.SetClass("Technician");
            Debug.Log(RecruitCharacter.GetCharacter().CharacterName);
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
            randBrawn = Random.Range(8, 15);
            randAgility = Random.Range(8, 13);
            randLuck = Random.Range(2, 21);
            randReason = Random.Range(12, 21);
            randWit = Random.Range(14, 21);
            randGlamour = Random.Range(12, 17);
            generatedCharacter = characterFactory.CreateNewScholar(randBrawn, randAgility, randLuck, randReason, randWit, randGlamour);
            generatedCharacter.CharacterImage = DisplayGraphic;
            generatedCharacter.SetClass("Scholar");
            Debug.Log(RecruitCharacter.GetCharacter().CharacterName);
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
            randBrawn = Random.Range(10, 16);
            randAgility = Random.Range(10, 13);
            randLuck = Random.Range(0, 21);
            randReason = Random.Range(12, 17);
            randWit = Random.Range(10, 17);
            randGlamour = Random.Range(12, 19);
            Brawn.text = "Brawn: " + randBrawn;
            Agility.text = "Agility: " + randAgility;
            Luck.text = "Luck: " + randLuck;
            Reason.text = "Reason: " + randReason;
            Wit.text = "Wit: " + randWit;
            Glamour.text = "Glamour: " + randGlamour;

            generatedCharacter = characterFactory.CreateNewPsionic(randBrawn, randAgility, randLuck, randReason, randWit, randGlamour);
            generatedCharacter.CharacterImage = DisplayGraphic;
            generatedCharacter.SetClass("Psionic");
        }
    }
}
