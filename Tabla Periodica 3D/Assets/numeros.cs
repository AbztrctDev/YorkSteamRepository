using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class numeros : MonoBehaviour
{
    public GameObject golden;

    public Dropdown opciones;

    public InputField digito1;
    string digito1string;

    public InputField digito2;
    string digito2string;

    public Text signo;

    public Text result;
    float f1;
    float f2;

    // Update is called once per frame
    public void Update()
    {
        if (opciones.value == 0)
        {
            signo.text = "+";
        }
        else if (opciones.value == 1)
        {
            signo.text = "-";
        }
        else if (opciones.value == 2)
        {
            signo.text = "X";
        }
        else if (opciones.value == 3)
        {
            signo.text = "/";
        }
        digito1string = digito1.text;
        digito2string = digito2.text;

        f1 = float.Parse(digito1string);
        f2 = float.Parse(digito2string);
    }

    public void Calculate()
    {
        if (opciones.value == 0)
        {
            if (f1 == 19 && f2 == 87)
            {
                result.text = "";
                golden.SetActive(true);
            }
            else
            {
                golden.SetActive(false);
                float resultNumber = f1 + f2;
                result.text = resultNumber.ToString();
            }
        }
        else if (opciones.value == 1)
        {
            golden.SetActive(false);
            float resultNumber = f1 - f2;
            result.text = resultNumber.ToString();
        }
        else if (opciones.value == 2)
        {
            golden.SetActive(false);
            float resultNumber = f1 * f2;
            result.text = resultNumber.ToString();
        }
        else if (opciones.value == 3)
        {
            if (f1 == 0 && f2 == 0)
            {
                golden.SetActive(false);
                result.text = "siendo el tercero me envidia el primero";
            }
            else if (f2 == 0)
            {
                golden.SetActive(false);
                result.text = "Can't divide by 0";
            }
            else
            {
                golden.SetActive(false);
                float resultNumber = f1 / f2;
                result.text = resultNumber.ToString();
            }
        }


    }
}
