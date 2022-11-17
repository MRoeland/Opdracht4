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
        private T? Huidig = default;
        public bool IsLeeg = true;
        public int Count = 0;

        public T? HuidigElement()
        {
            return Huidig;
        }

        public T? Toevoegen(T iets)
        {
            if (container.Count == 0)
            {
                Huidig = iets;
            }

            if (iets != null)
                container.Add(iets);

            return Huidig;
        }

        public T? Verwijderen()
        {
            if (Huidig != null)
            {
                container.Remove(Huidig);
                Huidig = default;
            }

            if (container.Count > 0)
            {
                Huidig = container.First();
            }

            return Huidig;
        }

        public T? Volgende()
        {
            if (container.Count == 0)
                return Huidig;
            int index = -1;
            if (Huidig != null)
                container.IndexOf(Huidig);
            if (index < container.Count - 1)
                Huidig = container[index + 1];
            else if (container.Count > 0)
                Huidig = container.First();
            else
                Huidig = default;
            return Huidig;
        }

        public void Leegmaken()
        {
            container.Clear();
            Huidig = default;
        }

        public T? ZetAchteraan()
        {
            if (Huidig != null)
            {
                container.Remove(Huidig);
                container.Add(Huidig);
            }
            if (container.Count > 0)
                Huidig = container.First();

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
                    if (container[i] != null)
                    {
                        containerValue += container[i].ToString();
                        containerValue += "\r\n";
                    }
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
