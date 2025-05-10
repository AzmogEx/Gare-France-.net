namespace IHM_GARE {
    partial class C_CADRE {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(C_CADRE));
            ListBox_Departement = new ListBox();
            La_Carte = new GMap.NET.WindowsForms.GMapControl();
            ListBox_Commune = new ListBox();
            Panel_info = new Panel();
            Picture_Voyageur = new PictureBox();
            Picture_Marchandise = new PictureBox();
            Label_Code_Ligne = new Label();
            Button_Gmap = new MaterialSkin.Controls.MaterialButton();
            Label_Marchandise = new Label();
            Label_Voyageur = new Label();
            Label_Coordonée_X = new Label();
            Label_Coordonée_Y = new Label();
            Picture_Departement = new PictureBox();
            Label_Departement = new Label();
            Picture_Gare = new PictureBox();
            Label_Gare = new Label();
            Label_Titre = new Label();
            Panel_info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Picture_Voyageur).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Picture_Marchandise).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Picture_Departement).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Picture_Gare).BeginInit();
            SuspendLayout();
            // 
            // ListBox_Departement
            // 
            ListBox_Departement.FormattingEnabled = true;
            ListBox_Departement.ItemHeight = 15;
            ListBox_Departement.Location = new Point(137,12);
            ListBox_Departement.Name = "ListBox_Departement";
            ListBox_Departement.Size = new Size(184,259);
            ListBox_Departement.TabIndex = 0;
            ListBox_Departement.SelectedIndexChanged += ListBox_Departement_SelectedIndexChanged;
            // 
            // La_Carte
            // 
            La_Carte.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            La_Carte.Bearing = 0F;
            La_Carte.CanDragMap = true;
            La_Carte.EmptyTileColor = Color.Navy;
            La_Carte.GrayScaleMode = false;
            La_Carte.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            La_Carte.LevelsKeepInMemory = 5;
            La_Carte.Location = new Point(91,330);
            La_Carte.MarkersEnabled = true;
            La_Carte.MaxZoom = 150;
            La_Carte.MinZoom = 0;
            La_Carte.MouseWheelZoomEnabled = true;
            La_Carte.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            La_Carte.Name = "La_Carte";
            La_Carte.NegativeMode = false;
            La_Carte.PolygonsEnabled = true;
            La_Carte.RetryLoadTile = 0;
            La_Carte.RoutesEnabled = true;
            La_Carte.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            La_Carte.SelectedAreaFillColor = Color.FromArgb(33,65,105,225);
            La_Carte.ShowTileGridLines = false;
            La_Carte.Size = new Size(805,267);
            La_Carte.TabIndex = 1;
            La_Carte.Zoom = 50D;
            // 
            // ListBox_Commune
            // 
            ListBox_Commune.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ListBox_Commune.FormattingEnabled = true;
            ListBox_Commune.ItemHeight = 15;
            ListBox_Commune.Location = new Point(352,12);
            ListBox_Commune.Name = "ListBox_Commune";
            ListBox_Commune.Size = new Size(184,259);
            ListBox_Commune.TabIndex = 2;
            ListBox_Commune.SelectedIndexChanged += ListBox_Commune_SelectedIndexChanged;
            // 
            // Panel_info
            // 
            Panel_info.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Panel_info.BackColor = SystemColors.AppWorkspace;
            Panel_info.BorderStyle = BorderStyle.FixedSingle;
            Panel_info.Controls.Add(Picture_Voyageur);
            Panel_info.Controls.Add(Picture_Marchandise);
            Panel_info.Controls.Add(Label_Code_Ligne);
            Panel_info.Controls.Add(Button_Gmap);
            Panel_info.Controls.Add(Label_Marchandise);
            Panel_info.Controls.Add(Label_Voyageur);
            Panel_info.Controls.Add(Label_Coordonée_X);
            Panel_info.Controls.Add(Label_Coordonée_Y);
            Panel_info.Location = new Point(605,61);
            Panel_info.Name = "Panel_info";
            Panel_info.Size = new Size(327,230);
            Panel_info.TabIndex = 4;
            // 
            // Picture_Voyageur
            // 
            Picture_Voyageur.Image = Properties.Resources.User;
            Picture_Voyageur.Location = new Point(50,107);
            Picture_Voyageur.Name = "Picture_Voyageur";
            Picture_Voyageur.Size = new Size(28,24);
            Picture_Voyageur.SizeMode = PictureBoxSizeMode.StretchImage;
            Picture_Voyageur.TabIndex = 11;
            Picture_Voyageur.TabStop = false;
            // 
            // Picture_Marchandise
            // 
            Picture_Marchandise.Image = Properties.Resources.marchandise;
            Picture_Marchandise.Location = new Point(6,134);
            Picture_Marchandise.Name = "Picture_Marchandise";
            Picture_Marchandise.Size = new Size(33,21);
            Picture_Marchandise.SizeMode = PictureBoxSizeMode.StretchImage;
            Picture_Marchandise.TabIndex = 10;
            Picture_Marchandise.TabStop = false;
            // 
            // Label_Code_Ligne
            // 
            Label_Code_Ligne.AutoSize = true;
            Label_Code_Ligne.Location = new Point(114,79);
            Label_Code_Ligne.Name = "Label_Code_Ligne";
            Label_Code_Ligne.Size = new Size(70,15);
            Label_Code_Ligne.TabIndex = 5;
            Label_Code_Ligne.Text = "Code Ligne:";
            // 
            // Button_Gmap
            // 
            Button_Gmap.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Button_Gmap.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            Button_Gmap.Depth = 0;
            Button_Gmap.HighEmphasis = true;
            Button_Gmap.Icon = null;
            Button_Gmap.Location = new Point(114,174);
            Button_Gmap.Margin = new Padding(4,6,4,6);
            Button_Gmap.MouseState = MaterialSkin.MouseState.HOVER;
            Button_Gmap.Name = "Button_Gmap";
            Button_Gmap.NoAccentTextColor = Color.Empty;
            Button_Gmap.Size = new Size(123,36);
            Button_Gmap.TabIndex = 4;
            Button_Gmap.Text = "Google maps";
            Button_Gmap.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            Button_Gmap.UseAccentColor = false;
            Button_Gmap.UseVisualStyleBackColor = true;
            Button_Gmap.Click += Button_Gmap_Click;
            // 
            // Label_Marchandise
            // 
            Label_Marchandise.AutoSize = true;
            Label_Marchandise.Location = new Point(45,134);
            Label_Marchandise.Name = "Label_Marchandise";
            Label_Marchandise.Size = new Size(78,15);
            Label_Marchandise.TabIndex = 3;
            Label_Marchandise.Text = "Marchandise:";
            // 
            // Label_Voyageur
            // 
            Label_Voyageur.AutoSize = true;
            Label_Voyageur.Location = new Point(84,110);
            Label_Voyageur.Name = "Label_Voyageur";
            Label_Voyageur.Size = new Size(59,15);
            Label_Voyageur.TabIndex = 2;
            Label_Voyageur.Text = "Voyageur:";
            // 
            // Label_Coordonée_X
            // 
            Label_Coordonée_X.AutoSize = true;
            Label_Coordonée_X.Location = new Point(84,22);
            Label_Coordonée_X.Name = "Label_Coordonée_X";
            Label_Coordonée_X.Size = new Size(69,15);
            Label_Coordonée_X.TabIndex = 1;
            Label_Coordonée_X.Text = "Coordonée:";
            // 
            // Label_Coordonée_Y
            // 
            Label_Coordonée_Y.AutoSize = true;
            Label_Coordonée_Y.Location = new Point(84,48);
            Label_Coordonée_Y.Name = "Label_Coordonée_Y";
            Label_Coordonée_Y.Size = new Size(69,15);
            Label_Coordonée_Y.TabIndex = 0;
            Label_Coordonée_Y.Text = "Coordonée:";
            // 
            // Picture_Departement
            // 
            Picture_Departement.Image = Properties.Resources.ville;
            Picture_Departement.Location = new Point(152,277);
            Picture_Departement.Name = "Picture_Departement";
            Picture_Departement.Size = new Size(47,37);
            Picture_Departement.SizeMode = PictureBoxSizeMode.StretchImage;
            Picture_Departement.TabIndex = 5;
            Picture_Departement.TabStop = false;
            // 
            // Label_Departement
            // 
            Label_Departement.AutoSize = true;
            Label_Departement.Font = new Font("Segoe UI",11.25F,FontStyle.Bold,GraphicsUnit.Point,0);
            Label_Departement.Location = new Point(205,286);
            Label_Departement.Name = "Label_Departement";
            Label_Departement.Size = new Size(102,20);
            Label_Departement.TabIndex = 6;
            Label_Departement.Text = "Departement";
            // 
            // Picture_Gare
            // 
            Picture_Gare.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Picture_Gare.Image = Properties.Resources.train;
            Picture_Gare.Location = new Point(396,277);
            Picture_Gare.Name = "Picture_Gare";
            Picture_Gare.Size = new Size(49,38);
            Picture_Gare.SizeMode = PictureBoxSizeMode.StretchImage;
            Picture_Gare.TabIndex = 7;
            Picture_Gare.TabStop = false;
            // 
            // Label_Gare
            // 
            Label_Gare.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Label_Gare.AutoSize = true;
            Label_Gare.Font = new Font("Segoe UI",11.25F,FontStyle.Bold,GraphicsUnit.Point,0);
            Label_Gare.Location = new Point(451,286);
            Label_Gare.Name = "Label_Gare";
            Label_Gare.Size = new Size(42,20);
            Label_Gare.TabIndex = 9;
            Label_Gare.Text = "Gare";
            // 
            // Label_Titre
            // 
            Label_Titre.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Label_Titre.AutoSize = true;
            Label_Titre.Font = new Font("Segoe UI",20F,FontStyle.Bold);
            Label_Titre.Location = new Point(651,12);
            Label_Titre.Name = "Label_Titre";
            Label_Titre.Size = new Size(265,37);
            Label_Titre.TabIndex = 10;
            Label_Titre.Text = "Les gares de France";
            // 
            // C_CADRE
            // 
            AutoScaleDimensions = new SizeF(7F,15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(971,596);
            Controls.Add(Label_Titre);
            Controls.Add(Label_Gare);
            Controls.Add(Picture_Gare);
            Controls.Add(Label_Departement);
            Controls.Add(Picture_Departement);
            Controls.Add(Panel_info);
            Controls.Add(ListBox_Commune);
            Controls.Add(La_Carte);
            Controls.Add(ListBox_Departement);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "C_CADRE";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Les gares de France";
            Panel_info.ResumeLayout(false);
            Panel_info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Picture_Voyageur).EndInit();
            ((System.ComponentModel.ISupportInitialize)Picture_Marchandise).EndInit();
            ((System.ComponentModel.ISupportInitialize)Picture_Departement).EndInit();
            ((System.ComponentModel.ISupportInitialize)Picture_Gare).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox ListBox_Departement;
        private GMap.NET.WindowsForms.GMapControl La_Carte;
        private ListBox ListBox_Commune;
        private Panel Panel_info;
        private Label Label_Coordonée_Y;
        private Label Label_Coordonée_X;
        private Label Label_Voyageur;
        private Label Label_Marchandise;
        private MaterialSkin.Controls.MaterialButton Button_Gmap;
        private Label Label_Code_Ligne;
        private PictureBox Picture_Departement;
        private Label Label_Departement;
        private PictureBox Picture_Gare;
        private Label Label_Gare;
        private PictureBox Picture_Marchandise;
        private PictureBox Picture_Voyageur;
        private Label Label_Titre;
    }
}
