using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RappelClasses
{
    public class GunGan
    {
        private string _firstName;

        public GunGan(string firstName)
        {
            this.FirstName = firstName;
        }

        public decimal Poids { get; set; }

        public string FirstName
        {
            get
            {
                return this._firstName;
            }
            set
            {
                this.ValidFirstName(value);
                this._firstName = value;
            }
        }

        private void ValidFirstName(string firstName)
        {
            if (string.IsNullOrEmpty(firstName))
            {
                throw new ArgumentNullException("firstName");
            }
        }

        private void ApprendreAParler()
        {
            throw new Exception("A finir");
        }
        
        public void Marcher()
        {
            Console.WriteLine("Je marche");
        }

    }
}
