using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Workshop_1.models
{
    public class Store
    {
        private List<Garment> garments = new List<Garment>();

        //Agregar prendas a la lista
        public void AddGarment(Garment garment)
        {
            garments.Add(garment);
        }
        //Buscar prendas por nombre en la lista
        public void FindGarmentByName(string name)
        {
            var garmentFound = garments.FirstOrDefault(g => g.Name == name);
            if (garmentFound != null)
            {
                garmentFound.ShowGarmentDetails();
            }
            else
            {
                Console.WriteLine("Prenda no encontrada");
            }
        }

        public void ShowGarmentList()
        {
            //Recorrer a la lista con un foreach
            foreach (var g in garments)
            {
                g.ShowGarmentDetails();
            }
        }
    }
}