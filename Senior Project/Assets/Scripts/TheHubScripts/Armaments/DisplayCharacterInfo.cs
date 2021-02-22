using AssemblyCSharp.Assets.Scripts.Classes;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DisplayCharacterInfo : MonoBehaviour
{
    private Ally character;
    private Image TargetGraphic, WeaponTargetGraphic;
    public Sprite DisplayGraphic;
    private TextMeshProUGUI Level, Brawn, Agility, Luck, Reason, Wit, Glamour;
    private TextMeshProUGUI WeaponName, Damage, Handling, Type;
    private GameObject PartyMemberPage;

    public void Awake()
    {
        PartyMemberPage = GameObject.FindGameObjectWithTag("Party Member Page");
        Level = PartyMemberPage.transform.Find("Level").GetComponent<TextMeshProUGUI>();
        Brawn = PartyMemberPage.transform.Find("Brawn").GetComponent<TextMeshProUGUI>();
        Agility = PartyMemberPage.transform.Find("Agility").GetComponent<TextMeshProUGUI>();
        Luck = PartyMemberPage.transform.Find("Luck").GetComponent<TextMeshProUGUI>();
        Reason = PartyMemberPage.transform.Find("Reason").GetComponent<TextMeshProUGUI>();
        Wit = PartyMemberPage.transform.Find("Wit").GetComponent<TextMeshProUGUI>();
        Glamour = PartyMemberPage.transform.Find("Glamour").GetComponent<TextMeshProUGUI>();

        WeaponName = PartyMemberPage.transform.Find("WeaponTab").Find("WeaponName").GetComponent<TextMeshProUGUI>();
        Damage = PartyMemberPage.transform.Find("WeaponTab").Find("Damage").GetComponent<TextMeshProUGUI>();
        Handling = PartyMemberPage.transform.Find("WeaponTab").Find("Handling").GetComponent<TextMeshProUGUI>();
        Type = PartyMemberPage.transform.Find("WeaponTab").Find("Type").GetComponent<TextMeshProUGUI>();

        TargetGraphic = PartyMemberPage.transform.Find("CharacterImage").GetComponent<Image>();
        WeaponTargetGraphic = PartyMemberPage.transform.Find("WeaponTab").Find("WeaponImage").GetComponent<Image>();
    }

    public void SetCharacter(Ally a)
    {
        character = a;
    }

    public void DisplayCharacter()
    {
        Level.text = "Level: " + character.GetLevel();
        Brawn.text = "Brawn: " + character.GetBrawn();
        Agility.text = "Agility: " + character.GetAgility();
        Luck.text = "Luck: " + character.GetLuck();
        Reason.text = "Reason: " + character.GetReason();
        Wit.text = "Wit: " + character.GetWit();
        Glamour.text = "Glamour: " + character.GetGlamour();

        Weapon charWeapon = character.GetWeapon();
        WeaponName.text = "Name: " + charWeapon.ItemName;
        Damage.text = "Damage: " + charWeapon.getMinDamage() + "-" + charWeapon.getMaxDamage();
        Handling.text = "Handling: " + charWeapon.getHandling();
        Type.text = "Type: " + charWeapon.GetWeaponType();
        Debug.Log("Target Graphic: " + TargetGraphic.name);
        Debug.Log("Display Graphic: " + DisplayGraphic.name);
        TargetGraphic.sprite = DisplayGraphic;
        TargetGraphic.color = new Color(255, 255, 255, 255);
        WeaponTargetGraphic.sprite = charWeapon.ItemImage;
        WeaponTargetGraphic.color = new Color(255, 255, 255, 255);
    }
}
