using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    class MyDictionary<K,V>
    {

        K[] keyDictionary;
        V[] valueDictionary;
        public MyDictionary()
        {
            keyDictionary = new K[0];
            valueDictionary = new V[0];
        }
        public void Add(K key, V value)
        {
            K[] tempKey = keyDictionary;
            V[] tempValue = valueDictionary;
            keyDictionary = new K[tempKey.Length + 1];
            valueDictionary = new V[tempValue.Length + 1];
            for (int i = 0; i < tempKey.Length; i++)
            {
                keyDictionary[i] = tempKey[i];
                valueDictionary[i] = tempValue[i];
            }

            keyDictionary[keyDictionary.Length - 1] = key;
            valueDictionary[valueDictionary.Length - 1] = value;
        }

    }
}
