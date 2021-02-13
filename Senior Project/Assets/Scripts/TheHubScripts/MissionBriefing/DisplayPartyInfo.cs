using AssemblyCSharp.Assets.Scripts.Classes;
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

    public void Awake()
    {
        PartySelect = GameObject.FindGameObjectWithTag("Party Select");
        Debug.Log(PartySelect);
        Level = PartySelect.transform.Find("Level").GetComponent<TextMeshProUGUI>();
        Brawn = PartySelect.transform.Find("Brawn").GetComponent<TextMeshProUGUI>();
        Agility = PartySelect.transform.Find("Agility").GetComponent<TextMeshProUGUI>();
        Luck = PartySelect.transform.Find("Luck").GetComponent<TextMeshProUGUI>();
        Reason = PartySelect.transform.Find("Reason").GetComponent<TextMeshProUGUI>();
        Wit = PartySelect.transform.Find("Wit").GetComponent<TextMeshProUGUI>();
        Glamour = PartySelect.transform.Find("Glamour").GetComponent<TextMeshProUGUI>();
        Class = PartySelect.transform.Find("Class").GetComponent<TextMeshProUGUI>();

        /*WeaponName = PartySelect.transform.Find("WeaponTab").Find("WeaponName").GetComponent<TextMeshProUGUI>();
        Damage = PartySelect.transform.Find("WeaponTab").Find("Damage").GetComponent<TextMeshProUGUI>();
        Handling = PartySelect.transform.Find("WeaponTab").Find("Handling").GetComponent<TextMeshProUGUI>();
        Type = PartySelect.transform.Find("WeaponTab").Find("Type").GetComponent<TextMeshProUGUI>();
        */
        TargetGraphic = PartySelect.transform.Find("CharacterImage").GetComponent<Image>();
        //WeaponTargetGraphic = PartySelect.transform.Find("WeaponTab").Find("WeaponImage").GetComponent<Image>();
    }

    public void SetCharacter(Ally a)
    {
        character = a;
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

        /*Weapon charWeapon = character.GetWeapon();
        WeaponName.text = "Name: " + charWeapon.ItemName;
        Damage.text = "Damage: " + charWeapon.getMinDamage() + "-" + charWeapon.getMaxDamage();
        Handling.text = "Handling: " + charWeapon.getHandling();
        Type.text = "Type: " + charWeapon.GetWeaponType();*/
        Debug.Log("Target Graphic: " + TargetGraphic.name);
        //Debug.Log("Display Graphic: " + DisplayGraphic.name);
        TargetGraphic.sprite = DisplayGraphic;
        TargetGraphic.color = new Color(255, 255, 255, 255);
        /*WeaponTargetGraphic.sprite = charWeapon.ItemImage;
        WeaponTargetGraphic.color = new Color(255, 255, 255, 255);*/
    }
}
