using System;
using System.Collections.Generic;
using System.Text;

namespace P127_Abstraction_Interface
{
    class Movie : Art
    {
        public string Name;
        public int Duration;
        private string _category;
        public override string Category
        {

            get => _category;
            set
            {

                if (value.Length > 3)
                {
                    _category = value;
                }
            }
        }

    }
}
