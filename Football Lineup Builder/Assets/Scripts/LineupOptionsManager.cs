using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LineupOptionsManager : MonoBehaviour
{
    [SerializeField] private TMP_Dropdown fieldColorDropDown;
    [SerializeField] private TMP_Dropdown formationDropDown;
    [SerializeField] private Image fieldImage;
    [SerializeField] private Transform[] playerIcons = new Transform[11];
    private void Awake()
    {
        fieldColorDropDown.onValueChanged.AddListener(delegate {
            FieldDropDown(fieldColorDropDown);
        });
        formationDropDown.onValueChanged.AddListener(delegate
        {
            FormationDropDown(formationDropDown);
        });
    }
    private void Start()
    {
        fieldImage.color = Color.white;
    }
    private void FieldDropDown(TMP_Dropdown dropdown)
    {
        int dropDownOption = dropdown.value;

        switch (dropDownOption)
        {
            case 0:
                Debug.Log("Green");
                fieldImage.color = Color.white;
                break;
            case 1:
                Debug.Log("Red");
                fieldImage.color = Color.red;
                break;
            case 2:
                Debug.Log("Yellow");
                fieldImage.color = Color.yellow;
                break;
            case 3:
                Debug.Log("Blue");
                fieldImage.color = Color.blue;
                break;
        }
    }
    private void FormationDropDown(TMP_Dropdown dropdown)
    {
        int dropDownOption = dropdown.value;
        switch (dropDownOption)
        {
            case 0:
                Debug.Log("4-4-2");
                //Defenders Positons
                playerIcons[0].localPosition = new Vector2(215, -200);
                playerIcons[1].localPosition = new Vector2(85, -200);
                playerIcons[2].localPosition = new Vector2(-85, -200);
                playerIcons[3].localPosition = new Vector2(-215, -200);

                //MidFielders Positions
                playerIcons[4].localPosition = new Vector2(-190, 0);
                playerIcons[5].localPosition = new Vector2(-60, 0);
                playerIcons[6].localPosition = new Vector2(60, 0);

                //Attackers Positions
                playerIcons[7].localPosition = new Vector2(190, 0);
                playerIcons[8].localPosition = new Vector2(-100,200);
                playerIcons[9].localPosition = new Vector2(100,200);
                break;
            case 1:
                Debug.Log("4-3-3");
                //Defenders Positons
                playerIcons[0].localPosition = new Vector2(215, -200);
                playerIcons[1].localPosition = new Vector2(85, -200);
                playerIcons[2].localPosition = new Vector2(-85, -200);
                playerIcons[3].localPosition = new Vector2(-215, -200);

                //MidFielders Positions
                playerIcons[4].localPosition = new Vector2(-190, 0);
                playerIcons[5].localPosition = new Vector2(0, 0);
                playerIcons[6].localPosition = new Vector2(190, 0);

                //Attackers Positions
                playerIcons[7].localPosition = new Vector2(-190,200);
                playerIcons[8].localPosition = new Vector2(-0, 200);
                playerIcons[9].localPosition = new Vector2(190, 200);
                break;
            case 2:
                Debug.Log("Yellow");
                fieldImage.color = Color.yellow;
                break;
            case 3:
                Debug.Log("Blue");
                fieldImage.color = Color.blue;
                break;
        }
    }
}

