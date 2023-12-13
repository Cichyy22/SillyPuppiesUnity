using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ButtnManager : MonoBehaviour
{
    [SerializeField] int level;
    // Start is called before the first frame update
    void Start()
    {
        if(level > PlayerPrefs.GetInt("level", 1))
        {
            transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>().color = Color.grey;
            GetComponent<Button>().interactable = false;
        }
    }

}
