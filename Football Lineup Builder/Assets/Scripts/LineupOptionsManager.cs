using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LineupOptionsManager : MonoBehaviour
{
    [SerializeField] private TMP_Dropdown fieldColorDropDown;
    [SerializeField] private TMP_Dropdown formationDropDown;
    [SerializeField] private Image fieldImage;

    private void Awake()
    {
        fieldColorDropDown.onValueChanged.AddListener(delegate {
            FieldDropDown(fieldColorDropDown);
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
}
