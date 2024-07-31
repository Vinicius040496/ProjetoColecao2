using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoColecao2.Entites
{
    internal class Studant
    {
        public int ID { get; set; }

        public Studant(int iD)
        {
            ID = iD;
        }
        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            if (!(obj is Studant)) 
                return false;
            else
            {
                Studant other = (Studant)obj;
                return ID == other.ID;
            }
        }
    }
}
