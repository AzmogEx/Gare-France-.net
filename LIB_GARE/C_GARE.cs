using System.Xml.Linq;

namespace LIB_GARE;

public class C_GARE
{
    public string code_uic { get; set; }
    public string libelle { get; set; }
    public string fret { get; set; }
    public string voyageurs { get; set; }
    public string code_ligne { get; set; }
    public int rg_troncon { get; set; }
    public string pk { get; set; }
    public string commune { get; set; }
    public string departemen { get; set; }
    public int idreseau { get; set; }
    public string idgaia { get; set; }
    public double x_l93 { get; set; }
    public double y_l93 { get; set; }
    public double x_wgs84 { get; set; }
    public double y_wgs84 { get; set; }
    public C_GEO c_geo { get; set; }
    public C_GEO_POINT geo_point_2d { get; set; }
    public C_GEO_DHAPE geo_shape { get; set; }

    //------------------------------------------------
    public void Affiche_Toi() {
        Console.WriteLine($"{libelle,5} {fret,5} {voyageurs,5} {code_ligne,-32} {commune, 5} {departemen, 5} {x_l93, 5} {y_l93, 5} ");
    }
}
