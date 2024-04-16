using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LineupOptionsManager : MonoBehaviour
{
    [SerializeField] private TMP_Dropdown fieldColorDropDown;
    [SerializeField] private TMP_Dropdown formationDropDown;
    [SerializeField] private TMP_Dropdown playerCountDownDropDown;
    [SerializeField] private TMP_Dropdown changeJerseyColorDropDown;
    [SerializeField] private Image fieldImage;
    [SerializeField] private Transform[] playerIcons = new Transform[11];
    [SerializeField] private Transform[] allPlayers = new Transform[12];
    [SerializeField] private Color[] colors;
    
    private void Awake()
    {
        fieldColorDropDown.onValueChanged.AddListener(delegate {
            FieldDropDown(fieldColorDropDown);
        });
        formationDropDown.onValueChanged.AddListener(delegate
        {
            FormationDropDown(formationDropDown);
        });
        playerCountDownDropDown.onValueChanged.AddListener(delegate
        {
            PlayerCountDropDown(playerCountDownDropDown);
        });
        changeJerseyColorDropDown.onValueChanged.AddListener(delegate
        {
            ChangeJerseyColorDropDown(changeJerseyColorDropDown);
        });
    }
    private void Start()
    {
        formationDropDown.value = 0;
        fieldImage.color = Color.white;
        FormationDropDown(formationDropDown);
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
                Debug.Log("4-3-3 Defence");
                //Defenders Positons
                playerIcons[0].localPosition = new Vector2(215, -200);
                playerIcons[1].localPosition = new Vector2(85, -200);
                playerIcons[2].localPosition = new Vector2(-85, -200);
                playerIcons[3].localPosition = new Vector2(-215, -200);

                //MidFielders Positions
                playerIcons[4].localPosition = new Vector2(-190, 0);
                playerIcons[5].localPosition = new Vector2(0,-100);
                playerIcons[6].localPosition = new Vector2(190, 0);

                //Attackers Positions
                playerIcons[7].localPosition = new Vector2(-190, 200);
                playerIcons[8].localPosition = new Vector2(-0, 200);
                playerIcons[9].localPosition = new Vector2(190, 200);
                break;
            default:
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
                playerIcons[8].localPosition = new Vector2(-100, 200);
                playerIcons[9].localPosition = new Vector2(100, 200);
                break;
        }
    }

    private void PlayerCountDropDown(TMP_Dropdown dropdown)
    {
        int dropDownOption = dropdown.value;
        switch (dropDownOption)
        {
            case 0:
                for (int i = 0; i < allPlayers.Length; i++)
                {
                    if (i == 0)
                    {
                        allPlayers[i].gameObject.SetActive(true);
                    }
                    else
                    {
                        allPlayers[i].gameObject.SetActive(false);
                    }
                }
                break;
            case 1:
                
                for (int i = 0; i < allPlayers.Length; i++)
                {
                    if (i < 2)
                    {
                        allPlayers[i].gameObject.SetActive(true);
                    }
                    else
                    {
                        allPlayers[i].gameObject.SetActive(false);
                    }
                }
                break;
            case 2:
              
                for (int i = 0; i < allPlayers.Length; i++)
                {
                    if (i < 3)
                    {
                        allPlayers[i].gameObject.SetActive(true);
                    }
                    else
                    {
                        allPlayers[i].gameObject.SetActive(false);
                    }
                }
                break;
        
          case 3:

            for (int i = 0; i < allPlayers.Length; i++)
            {
                if (i < 4)
                {
                    allPlayers[i].gameObject.SetActive(true);
                }
                else
                {
                    allPlayers[i].gameObject.SetActive(false);
                }
            }
            break;
            case 4:

                for (int i = 0; i < allPlayers.Length; i++)
                {
                    if (i < 5)
                    {
                        allPlayers[i].gameObject.SetActive(true);
                    }
                    else
                    {
                        allPlayers[i].gameObject.SetActive(false);
                    }
                }
                break;
            case 5:

                for (int i = 0; i < allPlayers.Length; i++)
                {
                    if (i < 6)
                    {
                        allPlayers[i].gameObject.SetActive(true);
                    }
                    else
                    {
                        allPlayers[i].gameObject.SetActive(false);
                    }
                }
                break;
            case 6:

                for (int i = 0; i < allPlayers.Length; i++)
                {
                    if (i < 7)
                    {
                        allPlayers[i].gameObject.SetActive(true);
                    }
                    else
                    {
                        allPlayers[i].gameObject.SetActive(false);
                    }
                }
                break;
            case 7:

                for (int i = 0; i < allPlayers.Length; i++)
                {
                    if (i < 8)
                    {
                        allPlayers[i].gameObject.SetActive(true);
                    }
                    else
                    {
                        allPlayers[i].gameObject.SetActive(false);
                    }
                }
                break;
            case 8:

                for (int i = 0; i < allPlayers.Length; i++)
                {
                    if (i < 9)
                    {
                        allPlayers[i].gameObject.SetActive(true);
                    }
                    else
                    {
                        allPlayers[i].gameObject.SetActive(false);
                    }
                }
                break;
            case 9:

                for (int i = 0; i < allPlayers.Length; i++)
                {
                    if (i < 10)
                    {
                        allPlayers[i].gameObject.SetActive(true);
                    }
                    else
                    {
                        allPlayers[i].gameObject.SetActive(false);
                    }
                }
                break;
            case 10:

                for (int i = 0; i < allPlayers.Length; i++)
                {
                    if (i < 11)
                    {
                        allPlayers[i].gameObject.SetActive(true);
                    }
                    else
                    {
                        allPlayers[i].gameObject.SetActive(false);
                    }
                }
                break;
            case 11:

                for (int i = 0; i < allPlayers.Length; i++)
                {
                    if (i < 12)
                    {
                        allPlayers[i].gameObject.SetActive(true);
                    }
                    else
                    {
                        allPlayers[i].gameObject.SetActive(false);
                    }
                }
                break;
        }
    }

    private void ChangeJerseyColorDropDown(TMP_Dropdown dropdown)
    {
        int dropDownOption = dropdown.value;
        switch (dropDownOption)
        {
            case 0:
                Debug.Log("Default Color");
                foreach (var player in allPlayers)
                {
                    player.GetComponent<Image>().color = colors[0];
                }
                break;

            case 1:
                Debug.Log("Green Color");
                foreach (var player in allPlayers)
                {
                    player.GetComponent<Image>().color = colors[1];
                }
                break;
            case 2:
                Debug.Log("Blue Color");
                foreach (var player in allPlayers)
                {
                    player.GetComponent<Image>().color = colors[2];
                }
                break;
        }
    }
}

