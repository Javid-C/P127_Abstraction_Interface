using System;
using System.Collections.Generic;
using System.Text;

namespace P127_Abstraction_Interface
{
    class Soap:Art
    {
        public int Episodes;
        private string _category;
        public override string Category {
            get => _category;
            set { 
                if(value.Length > 6)
                {
                    _category = value;
                }
            
            } }

    }
}
