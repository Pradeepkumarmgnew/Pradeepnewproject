using System;
using System.Collections.Generic;
using System.Text;

namespace Learningcsharpmay26.Csharpfirstproject
{
    class MainVehicle
    {
        static void Main(string[] args)
        {
            VehicleChild Mycar = new VehicleChild();
            Mycar.Model();
            Console.WriteLine(Mycar.name+""+ Mycar.Cartype);
        }
    }
}
