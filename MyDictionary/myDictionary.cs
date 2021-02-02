using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class myDictionary<Tkey, Tvalue>
    {
        Tkey[] keyArray;
        Tvalue[] valueArray;

        public myDictionary()
        {
            keyArray = new Tkey[0];
            valueArray = new Tvalue[0];
        }

        public void Add(Tkey key, Tvalue value)
        {
            Tkey[] TempKeyArray = keyArray; //geçiçi bir arraye "array"in adresini atıyoruz
            keyArray = new Tkey[keyArray.Length + 1];//array'in eleman saysını arttırıyoruz

            Tvalue[] TempValueArray = valueArray;
            valueArray = new Tvalue[valueArray.Length + 1];

            for(int i=0; i < TempKeyArray.Length; i++)
            {
                keyArray[i] = TempKeyArray[i];   //geçici array'deki elemanları yeni oluşturduğumuz ve eleman sayısını arttırdığımız arraye atıyoruz
                valueArray[i] = TempValueArray[i];
            }
            keyArray[keyArray.Length - 1] = key; //yeni array'in son elemanına eklenmek istenen elemanı ekliyoruz.
            valueArray[valueArray.Length - 1] = value;
        }

        public int Length
        {
            get { return keyArray.Length; }
        }
        

        public Tvalue[] Items
        {
            get { return valueArray; }
        }

    }
}
