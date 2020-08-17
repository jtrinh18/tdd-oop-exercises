using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture_2
{
    public class Person
    {
        private string _Firstname;
        private string _Lastname;
        private int _Age;
        private Person _Mother;
        private Person _Father;

        public string FirstName
        {
            //GetFirstName - læs firstname variabel 
            get { 
                return _Firstname;
            }
            //SetFisrtName - tilskriv firstname variabel værdi 
            set 
            {
                if (value == null)
                    return;
                if (value.Length > 100)
                    return;
                for(int i = 0; i < value.Length; i++)
                {
                    if (!char.IsLetter(value[i]))
                        return;
                }
                _Firstname = value;

            }
        }
          
        public string LastName
        {
            get { return _Lastname; }
            set
            {
                if (value == null)
                    return;
                if (value.Length > 100)
                    return;
                for (int i = 0; i < value.Length; i++)
                {
                    if (!char.IsLetter(value[i]))
                        return;
                }
                _Lastname = value;
            }
        }
        public int Age 
        {
            get { return _Age; }
            set 
            {
                if (value > 0)
                    this._Age = value;
            } 
        }

        public Person Mother
        {

            get
            {
                return _Mother;
            }
            set
            {
                if (value.Age <= this.Age)
                    return;
                _Mother = value;
            }
        }
        public Person Father 
        {
            get
            {
                return _Father;
            }
            set
            {
                if (value.Age < this.Age)
                    return;
                _Father = value;
            }
            
        }
        

    }
    
}
