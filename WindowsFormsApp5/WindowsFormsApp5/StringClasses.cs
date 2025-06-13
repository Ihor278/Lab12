using System;
using System.Collections;
using System.Collections.Generic;

namespace StringApp
{
    public class BitString
    {
        private string value;

        public BitString(string str)
        {
            if (!IsValidBitString(str))
                throw new ArgumentException("BitString can only contain 0 or 1");
            this.value = str;
        }

        private bool IsValidBitString(string str)
        {
            foreach (char c in str)
            {
                if (c != '0' && c != '1')
                    return false;
            }
            return true;
        }

        public override string ToString() => value;
    }

    public class BStringCollection
    {
        private Hashtable hashtable = new Hashtable();
        private SortedList<int, BitString> sortedList = new SortedList<int, BitString>();

        public void Add(int key, BitString value)
        {
            if (value == null)
                throw new ArgumentNullException(nameof(value));

            hashtable[key] = value;
            sortedList[key] = value;
        }

        public string IterateHashtable()
        {
            var result = "Hashtable Contents:\n";
            foreach (DictionaryEntry item in hashtable)
            {
                result += $"Key: {item.Key}, Value: {item.Value}\n";
            }
            return result;
        }

        public string IterateSortedList()
        {
            var result = "SortedList Contents:\n";
            foreach (var item in sortedList)
            {
                result += $"Key: {item.Key}, Value: {item.Value}\n";
            }
            return result;
        }

        public BitString FindByKey(int key)
        {
            return sortedList.TryGetValue(key, out BitString value) ? value : null;
        }

        public string GetCollectionStats()
        {
            return $"Hashtable Count: {hashtable.Count}\nSortedList Count: {sortedList.Count}";
        }
    }
}