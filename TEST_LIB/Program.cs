using LIB_GARE;
using System;

namespace test_lib;

internal class Program {
    static void Main(string[] args) {
        C_BASE_PROJET la_base = new C_BASE_PROJET();

        var toutes_les_gares = la_base.Get_All_Departement();
        Console.WriteLine($"il y a {toutes_les_gares.Count} gares dans la base\n\n");
        //--------------------
        Console.WriteLine("les 10 premières : ");
        for(int index = 0; index < 10; index++) {
            Console.WriteLine($"{toutes_les_gares[index].libelle}");
        }
        Console.WriteLine("------------------");

        //--------------------
        var les_gares_de_nimes = la_base.Get_Gare_By_Commune("nimes");
        if(les_gares_de_nimes.Count > 0) {
            Console.WriteLine($"première gare de nîmes : ");
            Console.WriteLine($"\t{les_gares_de_nimes[0].commune}");
            Console.WriteLine($"\t{les_gares_de_nimes[0].libelle}");
            Console.WriteLine($"\t position => {les_gares_de_nimes[0].geo_point_2d.lon}, {les_gares_de_nimes[0].geo_point_2d.lat}");


        }


    }
}
