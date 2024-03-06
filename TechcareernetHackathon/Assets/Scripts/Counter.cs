using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Counter : MonoBehaviour
{
    public int liderlik;
    public int yaraticilik;
    public int kararlilik;
    public int analitikDusunce;
    public int takimCalismasi;
    public int problemCozme;
    public int girisimcililk;
    public int multitasking;
    public int iletisim;

    public string[] points = new string[9];

    public int A;
    public int B;
    public int C;

    public Quiz quiz;
    int index;

    public TextMeshProUGUI[] pointTexts;

    void Start()
    {
        liderlik = 0;
        yaraticilik = 0;
        analitikDusunce = 0;
    }

    void Update()
    {
        Calculate();
    }

    void Calculate()
    {
        index = quiz.GetIndex();

        if (index == 0)
        {
            liderlik += 3;
            kararlilik += 2;
            girisimcililk++;

            A = liderlik + kararlilik + girisimcililk;
        }

        if (index == 1)
        {
            analitikDusunce += 3;
            problemCozme += 2;
            multitasking++;

            B = analitikDusunce + problemCozme + multitasking;
        }

        if (index == 2)
        {
            yaraticilik += 3;
            iletisim += 2;
            takimCalismasi++;

            C = yaraticilik + iletisim + takimCalismasi;
        }

        quiz.ChangeIndex(3);
        ArrayLoader();
    }

    void ArrayLoader()
    {
        points[0] = girisimcililk.ToString();
        points[1] = liderlik.ToString();
        points[2] = kararlilik.ToString();
        points[3] = multitasking.ToString();
        points[4] = analitikDusunce.ToString();
        points[5] = problemCozme.ToString();
        points[6] = yaraticilik.ToString();
        points[7] = takimCalismasi.ToString();
        points[8] = iletisim.ToString();

        for (int i = 0; i < pointTexts.Length; i++)
        {
            pointTexts[i].text = points[i];
        }
    }

    public string GetPoints(int index)
    {
        return points[index];
    }
}
