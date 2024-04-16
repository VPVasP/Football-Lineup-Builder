using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerIcon : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI numberText;
    [SerializeField] private TextMeshProUGUI nameText;


    private void Start()
    {
        numberText = transform.GetChild(0).GetComponent<TextMeshProUGUI>();
        nameText = transform.GetChild(1).GetComponent<TextMeshProUGUI>();

        numberText.gameObject.transform.localPosition =new Vector2(0, -20);
        nameText.gameObject.transform.localPosition = new Vector2(0, -70);

        
        
    }
}
