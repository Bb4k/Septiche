using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Linq;
using System;


public class Pachet : MonoBehaviour
{
    // Start is called before the first frame update

    public int RandomNumber(int min, int max)
    {
        System.Random random = new System.Random();
        return random.Next(min, max);
    }

        public Tuple<int, int>[] pachet =
           {
                     Tuple.Create(7,1),
                     Tuple.Create(7,2),
                     Tuple.Create(7,3),
                     Tuple.Create(7,4),
                     Tuple.Create(8,1),
                     Tuple.Create(8,2),
                     Tuple.Create(8,3),
                     Tuple.Create(8,4),
                     Tuple.Create(9,1),
                     Tuple.Create(9,2),
                     Tuple.Create(9,3),
                     Tuple.Create(9,4),
                     Tuple.Create(10,1),
                     Tuple.Create(10,2),
                     Tuple.Create(10,3),
                     Tuple.Create(10,4),
                     Tuple.Create(11,1),
                     Tuple.Create(11,2),
                     Tuple.Create(11,3),
                     Tuple.Create(11,4),
                     Tuple.Create(12,1),
                     Tuple.Create(12,2),
                     Tuple.Create(12,3),
                     Tuple.Create(12,4),
                     Tuple.Create(13,1),
                     Tuple.Create(13,2),
                     Tuple.Create(13,3),
                     Tuple.Create(13,4),
                     Tuple.Create(14,1),
                     Tuple.Create(14,2),
                     Tuple.Create(14,3),
                     Tuple.Create(14,4)
    };


    public void shuffle()
    {
        //Console.WriteLine(pachet[0]);
        int prev = 0;
        for (int i = 0; i < 33; i++)
        {
            e: int a = RandomNumber(0, 32);

            if (a == i || a == prev) goto e;

            prev = a;

            (pachet[i], pachet[a]) = (pachet[a], pachet[i]);
        }
    }

    public int ReturnCardVal(int i)
    {
            return pachet[i].Item1;

    }

    public int ReturnCardCol(int i)
    {

            return pachet[i].Item2;

    }

    void Start()
    {

        shuffle();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
