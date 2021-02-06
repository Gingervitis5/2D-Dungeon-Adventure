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

    public void SetGeneratedCharacter(Ally character)
    {
        generatedCharacter = character;
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
    }

    public void DisplayWildlander()
    {
        if (generatedCharacter == null)
        {
            int randBrawn = Random.Range(12, 21),
            randAgility = Random.Range(12, 17),
            randLuck = Random.Range(0, 21),
            randReason = Random.Range(3, 9),
            randWit = Random.Range(5, 13),
            randGlamour = Random.Range(8, 12);

            Brawn.text = "Brawn: " + randBrawn;
            Agility.text = "Agility: " + randAgility;
            Luck.text = "Luck: " + randLuck;
            Reason.text = "Reason: " + randReason;
            Wit.text = "Wit: " + randWit;
            Glamour.text = "Glamour: " + randGlamour;

            generatedCharacter = characterFactory.CreateNewWildlander(randBrawn, randAgility, randLuck, randReason, randWit, randGlamour);
            generatedCharacter.CharacterImage = DisplayGraphic;
        }
        else
        {
            Brawn.text = "Brawn: " + generatedCharacter.GetBrawn();
            Agility.text = "Agility: " + generatedCharacter.GetAgility();
            Luck.text = "Luck: " + generatedCharacter.GetLuck();
            Reason.text = "Reason: " + generatedCharacter.GetReason();
            Wit.text = "Wit: " + generatedCharacter.GetWit();
            Glamour.text = "Glamour: " + generatedCharacter.GetGlamour();
        }
        Class.text = "Class: Wildlander";
        TargetGraphic.sprite = DisplayGraphic;
        TargetGraphic.color = new Color(255, 255, 255, 255);

        RecruitCharacter.SetCharacter(generatedCharacter, this.gameObject);
;
    }

    public void DisplayTechnician()
    {
        if (generatedCharacter == null)
        {
            int randBrawn = Random.Range(5, 11),
            randAgility = Random.Range(8, 13),
            randLuck = Random.Range(0, 21),
            randReason = Random.Range(11, 17),
            randWit = Random.Range(14, 21),
            randGlamour = Random.Range(8, 13);

            Brawn.text = "Brawn: " + randBrawn;
            Agility.text = "Agility: " + randAgility;
            Luck.text = "Luck: " + randLuck;
            Reason.text = "Reason: " + randReason;
            Wit.text = "Wit: " + randWit;
            Glamour.text = "Glamour: " + randGlamour;

            generatedCharacter = characterFactory.CreateNewTechnician(randBrawn, randAgility, randLuck, randReason, randWit, randGlamour);
            generatedCharacter.CharacterImage = DisplayGraphic;
        }
        else
        {
            Brawn.text = "Brawn: " + generatedCharacter.GetBrawn();
            Agility.text = "Agility: " + generatedCharacter.GetAgility();
            Luck.text = "Luck: " + generatedCharacter.GetLuck();
            Reason.text = "Reason: " + generatedCharacter.GetReason();
            Wit.text = "Wit: " + generatedCharacter.GetWit();
            Glamour.text = "Glamour: " + generatedCharacter.GetGlamour();
        }
        Class.text = "Class: Technician";
        TargetGraphic.sprite = DisplayGraphic;
        TargetGraphic.color = new Color(255, 255, 255, 255);

        RecruitCharacter.SetCharacter(generatedCharacter, this.gameObject);
    }

    public void DisplayScholar()
    {
        if (generatedCharacter == null)
        {
            int randBrawn = Random.Range(5, 11),
            randAgility = Random.Range(8, 13),
            randLuck = Random.Range(0, 21),
            randReason = Random.Range(14, 21),
            randWit = Random.Range(14, 21),
            randGlamour = Random.Range(9, 14);

            Brawn.text = "Brawn: " + randBrawn;
            Agility.text = "Agility: " + randAgility;
            Luck.text = "Luck: " + randLuck;
            Reason.text = "Reason: " + randReason;
            Wit.text = "Wit: " + randWit;
            Glamour.text = "Glamour: " + randGlamour;

            generatedCharacter = characterFactory.CreateNewScholar(randBrawn, randAgility, randLuck, randReason, randWit, randGlamour);
            generatedCharacter.CharacterImage = DisplayGraphic;
        }
        else
        {
            Brawn.text = "Brawn: " + generatedCharacter.GetBrawn();
            Agility.text = "Agility: " + generatedCharacter.GetAgility();
            Luck.text = "Luck: " + generatedCharacter.GetLuck();
            Reason.text = "Reason: " + generatedCharacter.GetReason();
            Wit.text = "Wit: " + generatedCharacter.GetWit();
            Glamour.text = "Glamour: " + generatedCharacter.GetGlamour();
        }
        Class.text = "Class: Scholar";
        TargetGraphic.sprite = DisplayGraphic;
        TargetGraphic.color = new Color(255, 255, 255, 255);

        RecruitCharacter.SetCharacter(generatedCharacter, this.gameObject);
    }
}
