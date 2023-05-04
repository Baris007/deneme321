using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class para : MonoBehaviour
{
    public Text money_text;
    public int money_int;
    public Text madenci_text;
    public int madenci_int;
    // Start is called before the first frame update
    void Start()
    {
        money_text.text = "500";
        madenci_text.text = "0";
        StartCoroutine(paraarttýr());

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void madenci_buton()
    {
        string para_miktarý = money_text.text;
        int money_parsed = int.Parse(para_miktarý);
        if (money_parsed >= 100) { 
        string madenci_sayýsý = madenci_text.text;
        int madenci_parsed = int.Parse(madenci_sayýsý);
        madenci_int = madenci_parsed + 1;
        madenci_text.text = madenci_int.ToString();

        money_int = money_parsed - 100;
        money_text.text = money_int.ToString();
        }

    }
    IEnumerator paraarttýr()
    {
        while (true)
        {
            string madenci_sayýsý = madenci_text.text;
            int madeci_parsed = int.Parse(madenci_sayýsý);
            madenci_int = madeci_parsed;
            //
            string para_miktarý = money_text.text;
            int money_parsed = int.Parse(para_miktarý);
            money_int = money_parsed;
            money_int += 1 * madenci_int;
            money_text.text = money_int.ToString();

            yield return new WaitForSeconds(1f);
        }

    }
}
