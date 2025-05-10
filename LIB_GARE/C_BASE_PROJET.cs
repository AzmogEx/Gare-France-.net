using System.Collections.Generic;
using System.Text.Json;

namespace LIB_GARE;

//=================================================

public class C_BASE_PROJET {

    List<C_GARE> Les_Gares;
    //---------------------------
    public C_BASE_PROJET() {
        Chargement_Memoire();
    }
    //----------------------------
    void Chargement_Memoire() {
        var Data_Json = File.ReadAllText("liste-des-gares.json");
        Les_Gares = JsonSerializer.Deserialize<List<C_GARE>>(Data_Json);
    }
    //-----------------------------
    public void Affiche_Gare() {
        foreach(C_GARE Une_Gare in Les_Gares) {
            Une_Gare.Affiche_Toi();
        }
    }
    //-----------------------------
    public List<string> GetDistinctDepartements() {
        List<string> distinctDepartements = Les_Gares.Select(selection_gare_distincte => selection_gare_distincte.departemen).Distinct().ToList();
        return distinctDepartements;
    }
    //----------------------------
    public List<C_GARE> Get_Commune_By_Departement(string departementName) {
        List<C_GARE> Communes_Trouvees = new List<C_GARE>();
        string Nom_Recherche = departementName.ToLower();
        foreach(C_GARE Une_Gare in Les_Gares) {
            if(Une_Gare.departemen.ToLower() == Nom_Recherche) {
                Communes_Trouvees.Add(Une_Gare);
            }
        }
        return Communes_Trouvees;
    }

    public List<C_GARE> Get_All_Departement() {
        return Les_Gares;
    }

    //----------------------------
    public List<C_GARE> Get_Gare_By_Commune(string P_Nom) {
        List<C_GARE> Gare_Trouvee = new List<C_GARE>();
        string Nom_Recherche = P_Nom.ToLower();
        foreach(C_GARE Une_Gare in Les_Gares) {
            if(Une_Gare.commune.ToLower().StartsWith(Nom_Recherche)) {
                Gare_Trouvee.Add(Une_Gare);
            }
        }

        return Gare_Trouvee;
    }
}