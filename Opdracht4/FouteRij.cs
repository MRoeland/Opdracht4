using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht4
{
    internal class FouteRij<T>
    {
        private List<T> container = new List<T>();
        private T Huidig;
        public bool IsLeeg;
        public int Count;

        public T Toevoegen(T iets)
        {
            if(container.Count == 0)
            {
                Huidig = iets;
            }

            container.Add(iets);

            return Huidig;
        }

        public T Verwijderen()
        {
            container.Remove(Huidig);

            if(container.Count != 0)
            {
                Huidig = container.First();
            }

            return Huidig;
        }

        /*public T Volgende()
        {
            int index = container.IndexOf(Huidig);
            Huidig = container[index + 1];

            if (container.Count > 0)
            {
            }
            return Huidig;
        }*/

        public void Leegmaken()
        {
            container.Clear();
            Huidig = default;
        }

        public T ZetAchteraan()
        {
            int Index = container.Count - 1;
            container[Index] = Huidig;

            return Huidig;
        }

        public override string ToString()
        {

            String containerValue = "";
            if (container.Count == 0)
            {
                containerValue = "Container is leeg";
            }
            else
            {
                for (int i = 0; i < container.Count; i++)
                {
                    containerValue += container[i].ToString();
                    containerValue += " | ";
                }
            }

            return containerValue;
        }

        public FouteRij<T> Copy()
        {

            FouteRij<T> clonedRij = (FouteRij<T>)this.MemberwiseClone();

            return clonedRij;
        }
    }
}
