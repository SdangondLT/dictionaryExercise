using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionaryExercise
{
    internal class Articles
    {
        private string _name { get; set; }
        private int _id { get; set; }
        private decimal _price { get; set; }
        private string _isImported { get; set; }
        private int _count { get; set; }

        public Articles(string name, int id, decimal price, string isImported, int count)
        {
            this._name = name;
            this._id = id;
            this._price = price;
            this._isImported = isImported;
            this._count = count;
        }        

        public int GetId()
        {
            return _id;
        }

        public string GetName()
        {
            return _name;
        }

        public decimal GetPrice()
        {
            return _price;
        }

        public string GetIsImported()
        {
            return _isImported;
        }

        public int GetCount()
        {
            return _count;
        }
    }
}
