using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Three
{
    internal class MyHashTable
    {
        private LinkedList<KeyValuePair<string, string>>[] _cells;

        public MyHashTable(int size)
        {
            _cells = new LinkedList<KeyValuePair<string, string>>[size];
        }

        public bool AddElement(string key, string value)
        {
            var index = GetCellIndex(key);
            if (_cells[index] == null)
            {
                _cells[index] = new LinkedList<KeyValuePair<string, string>>();
            }
            _cells[index].AddLast(new KeyValuePair<string, string>(key, value));
            return true;
        }

        public LinkedList<KeyValuePair<string,string>>[] GetAllElements()
        {
            return _cells;
        }

        private int GetCellIndex(string key)
        {
            return Math.Abs(key.GetHashCode()) % _cells.Length;
        }

        public bool RemoveElement(string key, string value)
        {
            var index = GetCellIndex(key);
            if (_cells[index] == null)
            {
                return false;
            }
            var cell = _cells[index].First;
            while (cell != null)
            {
                if (cell.Value.Key.Equals(key) && cell.Value.Value.Equals(value))
                {
                    _cells[index].Remove(cell.Value);
                    break;
                }
                cell = cell.Next;
            }
            return true;
        }

        public bool UpdateElement(string key, string oldValue, string newValue)
        {
            var index = GetCellIndex(key);
            if (_cells[index] == null)
            {
                return false;
            }
            RemoveElement(key, oldValue);
            AddElement(key, newValue);
            return true;
        }
    }
}
