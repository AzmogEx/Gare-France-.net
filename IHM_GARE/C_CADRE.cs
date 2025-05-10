using GMap.NET.MapProviders;
using GMap.NET;
using LIB_GARE;
using System.Drawing;
using System.Diagnostics;

namespace IHM_GARE;
public partial class C_CADRE :Form {
    C_BASE_PROJET La_Base;

    public C_CADRE() {
        InitializeComponent();

        La_Carte.MapProvider = BingMapProvider.Instance;
        GMaps.Instance.Mode = AccessMode.ServerAndCache;
        La_Carte.DragButton = MouseButtons.Left;

        La_Carte.MapProvider = GMapProviders.BingHybridMap;

        try {
            La_Base = new C_BASE_PROJET();

            var Liste_Departement = La_Base.GetDistinctDepartements();

            ListBox_Departement.DataSource = Liste_Departement;
        }
        catch(Exception P_Erreur) {
            MessageBox.Show(P_Erreur.Message,"Erreur",MessageBoxButtons.OK,MessageBoxIcon.Error);
            Close();
        }

    }
    //-----------------------------------------------------------------
    private void ListBox_Departement_SelectedIndexChanged(object sender,EventArgs e) {
        string Departement_Selectionnee = ListBox_Departement.SelectedItem as string;
        if(Departement_Selectionnee == null) return;

        var Liste_Commune = La_Base.Get_Commune_By_Departement(Departement_Selectionnee);

        ListBox_Commune.DisplayMember = nameof(C_GARE.commune);
        ListBox_Commune.DataSource = Liste_Commune;


    }
    //-----------------------------------------------------------------

    private void ListBox_Commune_SelectedIndexChanged(object sender,EventArgs e) {
        if(ListBox_Commune.SelectedItems == null) return;

        C_GARE Commune_Selectionnee = (C_GARE)ListBox_Commune.SelectedItem;

        La_Carte.Position = new PointLatLng(Commune_Selectionnee.y_wgs84,Commune_Selectionnee.x_wgs84);
        La_Carte.Zoom = 8;

        Label_Coordonée_Y.Text = $"Coordonée Y : {Commune_Selectionnee.y_wgs84}";
        Label_Coordonée_X.Text = $"Coordonée X : {Commune_Selectionnee.x_wgs84}";

        Label_Code_Ligne.Text = $"Code Ligne: {Commune_Selectionnee.code_ligne}";

        if(Commune_Selectionnee.voyageurs == "O")
            Label_Voyageur.Text = "Prend en charge les voyageurs";
        else if(Commune_Selectionnee.voyageurs == "N")
            Label_Voyageur.Text = "Ne prend pas en charge les voyageurs";
        else
            Label_Voyageur.Text = "Informations indisponibles";

        //-----------------------------------------------------------------------------------
        if(Commune_Selectionnee.fret == "O")
            Label_Marchandise.Text = "Prend en charge le transport de marchandise";
        else if(Commune_Selectionnee.fret == "N")
            Label_Marchandise.Text = "Ne prend pas en charge le transport de marchandise";
        else
            Label_Marchandise.Text = "Informations indisponibles";
        //-----------------------------------------------------------------------------------
    }

    private void ListBox_Gare_SelectedIndexChanged(object sender,EventArgs e) {

    }

    private void Button_Gmap_Click(object sender,EventArgs e) {
        C_GARE Commune_Selectionnee = ListBox_Commune.SelectedItem as C_GARE;
        if(Commune_Selectionnee != null) {
            string urlGMap = $"https://www.google.com/maps?q={Commune_Selectionnee.commune}";

            Process.Start(new ProcessStartInfo(urlGMap) { UseShellExecute = true });
        }
    }
}
