using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Cartejuc : MonoBehaviour
{



    public GameObject pachetel;
    Pachet pachet;

    
    

    // Start is called before the first frame update
    void Start()
    {

        pachet = pachetel.GetComponent<Pachet>();

        pachet.shuffle();


        int[,] pachet2 = new int[32,2];

        int ValIncr, CulIncr;
        for (int i = 0; i < 33; i++)
        {
            ValIncr = pachet.ReturnCardVal(i);
            for (int j = 0; j < 4; j++)s
            {


                CulIncr = pachet.ReturnCardCol(i);
                pachet2[i,j] = { { ValIncr, CulIncr} }; 
        }
        }

        
       

        gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load("c01", typeof(Sprite)) as Sprite;
        string nume = gameObject.GetComponent<SpriteRenderer>().sprite.texture.name;
        transform.localScale = new Vector3(0.35f, 0.35f);
        
        int carte = 0;

        Int32.TryParse(nume, out carte);

        Console.WriteLine(carte);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
