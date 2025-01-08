using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment29
{
    public class CustomObject
    {


        private int _id;
        private string _name;
        public int Id
        {
            set { _id = value; }
            get { return _id; }
        }
        public string Name
        {
            set { _name = value; }
            get { return _name; }
        }

        public CustomObject(int id, string name)
        {
            this._id = id;
            this._name = name;
        }
        public override string ToString()
        {
            return $"Object [ID: {_id}, Name: {_name}]";
        }

    }
}
