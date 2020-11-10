namespace Pokedex
{
    partial class PokeDex
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Bunifu.UI.WinForms.BunifuAnimatorNS.Animation animation3 = new Bunifu.UI.WinForms.BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PokeDex));
            this.pokeName = new Bunifu.UI.WinForms.BunifuLabel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.baseStatsLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.weightValue = new Bunifu.UI.WinForms.BunifuLabel();
            this.heightValue = new Bunifu.UI.WinForms.BunifuLabel();
            this.speciesValue = new Bunifu.UI.WinForms.BunifuLabel();
            this.minimizeButton = new Guna.UI2.WinForms.Guna2PictureBox();
            this.PokeFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.type1Content = new Bunifu.UI.WinForms.BunifuLabel();
            this.pokeType2Content = new Bunifu.UI.WinForms.BunifuLabel();
            this.defenseLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.atkLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.spAtkLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.spDefLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.totalStatsLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.speedLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.hpLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.pokemonImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pokeNumber = new Bunifu.UI.WinForms.BunifuLabel();
            this.backgroundTransition = new BunifuColorTransition.BunifuColorTransition(this.components);
            this.bunifuTransition = new Bunifu.UI.WinForms.BunifuTransition(this.components);
            this.scrollBar = new Bunifu.UI.WinForms.BunifuVScrollBar();
            this.PokeType = new Bunifu.UI.WinForms.BunifuLabel();
            this.hpValueLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.defenseValueLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.spAtkContentLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.spDefContentLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.speedLabelContent = new Bunifu.UI.WinForms.BunifuLabel();
            this.totalLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.hpValue = new Bunifu.UI.Winforms.BunifuProgressBar();
            this.atkValue = new Bunifu.UI.Winforms.BunifuProgressBar();
            this.defValue = new Bunifu.UI.Winforms.BunifuProgressBar();
            this.spAtkValue = new Bunifu.UI.Winforms.BunifuProgressBar();
            this.spDefValue = new Bunifu.UI.Winforms.BunifuProgressBar();
            this.speedValue = new Bunifu.UI.Winforms.BunifuProgressBar();
            this.totalValue = new Bunifu.UI.Winforms.BunifuProgressBar();
            this.attackLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.exitButton = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            this.SuspendLayout();
            // 
            // pokeName
            // 
            this.pokeName.AutoEllipsis = false;
            this.pokeName.CursorType = null;
            this.bunifuTransition.SetDecoration(this.pokeName, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.pokeName.Font = new System.Drawing.Font("Rockwell", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pokeName.ForeColor = System.Drawing.Color.White;
            this.pokeName.Location = new System.Drawing.Point(24, 50);
            this.pokeName.Name = "pokeName";
            this.pokeName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pokeName.Size = new System.Drawing.Size(187, 48);
            this.pokeName.TabIndex = 53;
            this.pokeName.Text = "Bulbasaur";
            this.pokeName.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.pokeName.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // baseStatsLabel
            // 
            this.baseStatsLabel.AutoEllipsis = false;
            this.baseStatsLabel.CursorType = null;
            this.bunifuTransition.SetDecoration(this.baseStatsLabel, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.baseStatsLabel.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseStatsLabel.ForeColor = System.Drawing.Color.White;
            this.baseStatsLabel.Location = new System.Drawing.Point(24, 490);
            this.baseStatsLabel.Name = "baseStatsLabel";
            this.baseStatsLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.baseStatsLabel.Size = new System.Drawing.Size(143, 31);
            this.baseStatsLabel.TabIndex = 54;
            this.baseStatsLabel.Text = "Base Stats : ";
            this.baseStatsLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.baseStatsLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // weightValue
            // 
            this.weightValue.AutoEllipsis = false;
            this.weightValue.CursorType = null;
            this.bunifuTransition.SetDecoration(this.weightValue, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.weightValue.Font = new System.Drawing.Font("Gilroy", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightValue.ForeColor = System.Drawing.Color.White;
            this.weightValue.Location = new System.Drawing.Point(24, 166);
            this.weightValue.Name = "weightValue";
            this.weightValue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.weightValue.Size = new System.Drawing.Size(68, 22);
            this.weightValue.TabIndex = 55;
            this.weightValue.Text = "Weight : ";
            this.weightValue.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.weightValue.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // heightValue
            // 
            this.heightValue.AutoEllipsis = false;
            this.heightValue.CursorType = null;
            this.bunifuTransition.SetDecoration(this.heightValue, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.heightValue.Font = new System.Drawing.Font("Gilroy", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heightValue.ForeColor = System.Drawing.Color.White;
            this.heightValue.Location = new System.Drawing.Point(24, 138);
            this.heightValue.Name = "heightValue";
            this.heightValue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.heightValue.Size = new System.Drawing.Size(63, 22);
            this.heightValue.TabIndex = 56;
            this.heightValue.Text = "Height : ";
            this.heightValue.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.heightValue.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // speciesValue
            // 
            this.speciesValue.AutoEllipsis = false;
            this.speciesValue.CursorType = null;
            this.bunifuTransition.SetDecoration(this.speciesValue, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.speciesValue.Font = new System.Drawing.Font("Gilroy", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speciesValue.ForeColor = System.Drawing.Color.White;
            this.speciesValue.Location = new System.Drawing.Point(24, 102);
            this.speciesValue.Name = "speciesValue";
            this.speciesValue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.speciesValue.Size = new System.Drawing.Size(101, 30);
            this.speciesValue.TabIndex = 57;
            this.speciesValue.Text = "Species : ";
            this.speciesValue.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.speciesValue.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // minimizeButton
            // 
            this.minimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.minimizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition.SetDecoration(this.minimizeButton, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.minimizeButton.Image = ((System.Drawing.Image)(resources.GetObject("minimizeButton.Image")));
            this.minimizeButton.Location = new System.Drawing.Point(1623, 23);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.ShadowDecoration.Parent = this.minimizeButton;
            this.minimizeButton.Size = new System.Drawing.Size(50, 35);
            this.minimizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizeButton.TabIndex = 61;
            this.minimizeButton.TabStop = false;
            // 
            // PokeFlowPanel
            // 
            this.PokeFlowPanel.BackColor = System.Drawing.Color.Transparent;
            this.PokeFlowPanel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.bunifuTransition.SetDecoration(this.PokeFlowPanel, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.PokeFlowPanel.Location = new System.Drawing.Point(1655, 173);
            this.PokeFlowPanel.Name = "PokeFlowPanel";
            this.PokeFlowPanel.Size = new System.Drawing.Size(50, 579);
            this.PokeFlowPanel.TabIndex = 64;
            // 
            // type1Content
            // 
            this.type1Content.AutoEllipsis = false;
            this.type1Content.CursorType = null;
            this.bunifuTransition.SetDecoration(this.type1Content, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.type1Content.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type1Content.ForeColor = System.Drawing.Color.White;
            this.type1Content.Location = new System.Drawing.Point(91, 411);
            this.type1Content.Name = "type1Content";
            this.type1Content.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.type1Content.Size = new System.Drawing.Size(56, 25);
            this.type1Content.TabIndex = 66;
            this.type1Content.Text = "Grass";
            this.type1Content.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.type1Content.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // pokeType2Content
            // 
            this.pokeType2Content.AutoEllipsis = false;
            this.pokeType2Content.CursorType = null;
            this.bunifuTransition.SetDecoration(this.pokeType2Content, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.pokeType2Content.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pokeType2Content.ForeColor = System.Drawing.Color.White;
            this.pokeType2Content.Location = new System.Drawing.Point(91, 448);
            this.pokeType2Content.Name = "pokeType2Content";
            this.pokeType2Content.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pokeType2Content.Size = new System.Drawing.Size(67, 25);
            this.pokeType2Content.TabIndex = 67;
            this.pokeType2Content.Text = "Poison";
            this.pokeType2Content.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.pokeType2Content.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // defenseLabel
            // 
            this.defenseLabel.AutoEllipsis = false;
            this.defenseLabel.CursorType = null;
            this.bunifuTransition.SetDecoration(this.defenseLabel, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.defenseLabel.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.defenseLabel.ForeColor = System.Drawing.Color.White;
            this.defenseLabel.Location = new System.Drawing.Point(67, 643);
            this.defenseLabel.Name = "defenseLabel";
            this.defenseLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.defenseLabel.Size = new System.Drawing.Size(70, 21);
            this.defenseLabel.TabIndex = 68;
            this.defenseLabel.Text = "Defense";
            this.defenseLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.defenseLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // atkLabel
            // 
            this.atkLabel.AutoEllipsis = false;
            this.atkLabel.CursorType = null;
            this.bunifuTransition.SetDecoration(this.atkLabel, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.atkLabel.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atkLabel.ForeColor = System.Drawing.Color.White;
            this.atkLabel.Location = new System.Drawing.Point(81, 590);
            this.atkLabel.Name = "atkLabel";
            this.atkLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.atkLabel.Size = new System.Drawing.Size(56, 21);
            this.atkLabel.TabIndex = 69;
            this.atkLabel.Text = "Attack";
            this.atkLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.atkLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // spAtkLabel
            // 
            this.spAtkLabel.AutoEllipsis = false;
            this.spAtkLabel.CursorType = null;
            this.bunifuTransition.SetDecoration(this.spAtkLabel, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.spAtkLabel.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spAtkLabel.ForeColor = System.Drawing.Color.White;
            this.spAtkLabel.Location = new System.Drawing.Point(52, 696);
            this.spAtkLabel.Name = "spAtkLabel";
            this.spAtkLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.spAtkLabel.Size = new System.Drawing.Size(85, 21);
            this.spAtkLabel.TabIndex = 70;
            this.spAtkLabel.Text = "Sp. Attack";
            this.spAtkLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.spAtkLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // spDefLabel
            // 
            this.spDefLabel.AutoEllipsis = false;
            this.spDefLabel.CursorType = null;
            this.bunifuTransition.SetDecoration(this.spDefLabel, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.spDefLabel.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spDefLabel.ForeColor = System.Drawing.Color.White;
            this.spDefLabel.Location = new System.Drawing.Point(38, 749);
            this.spDefLabel.Name = "spDefLabel";
            this.spDefLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.spDefLabel.Size = new System.Drawing.Size(99, 21);
            this.spDefLabel.TabIndex = 71;
            this.spDefLabel.Text = "Sp. Defense";
            this.spDefLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.spDefLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // totalStatsLabel
            // 
            this.totalStatsLabel.AutoEllipsis = false;
            this.totalStatsLabel.CursorType = null;
            this.bunifuTransition.SetDecoration(this.totalStatsLabel, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.totalStatsLabel.Font = new System.Drawing.Font("Montserrat", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalStatsLabel.ForeColor = System.Drawing.Color.White;
            this.totalStatsLabel.Location = new System.Drawing.Point(91, 852);
            this.totalStatsLabel.Name = "totalStatsLabel";
            this.totalStatsLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.totalStatsLabel.Size = new System.Drawing.Size(46, 23);
            this.totalStatsLabel.TabIndex = 80;
            this.totalStatsLabel.Text = "Total";
            this.totalStatsLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.totalStatsLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 15;
            this.guna2Elipse2.TargetControl = this.PokeFlowPanel;
            // 
            // speedLabel
            // 
            this.speedLabel.AutoEllipsis = false;
            this.speedLabel.CursorType = null;
            this.bunifuTransition.SetDecoration(this.speedLabel, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.speedLabel.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speedLabel.ForeColor = System.Drawing.Color.White;
            this.speedLabel.Location = new System.Drawing.Point(82, 802);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.speedLabel.Size = new System.Drawing.Size(55, 21);
            this.speedLabel.TabIndex = 72;
            this.speedLabel.Text = "Speed ";
            this.speedLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.speedLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // hpLabel
            // 
            this.hpLabel.AutoEllipsis = false;
            this.hpLabel.CursorType = null;
            this.bunifuTransition.SetDecoration(this.hpLabel, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.hpLabel.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hpLabel.ForeColor = System.Drawing.Color.White;
            this.hpLabel.Location = new System.Drawing.Point(111, 537);
            this.hpLabel.Name = "hpLabel";
            this.hpLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.hpLabel.Size = new System.Drawing.Size(26, 21);
            this.hpLabel.TabIndex = 79;
            this.hpLabel.Text = "HP";
            this.hpLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.hpLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // pokemonImage
            // 
            this.pokemonImage.BackColor = System.Drawing.Color.Transparent;
            this.pokemonImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bunifuTransition.SetDecoration(this.pokemonImage, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.pokemonImage.Location = new System.Drawing.Point(660, 214);
            this.pokemonImage.Name = "pokemonImage";
            this.pokemonImage.ShadowDecoration.Parent = this.pokemonImage;
            this.pokemonImage.Size = new System.Drawing.Size(570, 494);
            this.pokemonImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pokemonImage.TabIndex = 89;
            this.pokemonImage.TabStop = false;
            this.pokemonImage.UseTransparentBackground = true;
            // 
            // pokeNumber
            // 
            this.pokeNumber.AutoEllipsis = false;
            this.pokeNumber.CursorType = null;
            this.bunifuTransition.SetDecoration(this.pokeNumber, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.pokeNumber.Font = new System.Drawing.Font("Gilroy", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pokeNumber.ForeColor = System.Drawing.Color.White;
            this.pokeNumber.Location = new System.Drawing.Point(24, 23);
            this.pokeNumber.Name = "pokeNumber";
            this.pokeNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pokeNumber.Size = new System.Drawing.Size(113, 30);
            this.pokeNumber.TabIndex = 90;
            this.pokeNumber.Text = "Bulbasaur";
            this.pokeNumber.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.pokeNumber.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // backgroundTransition
            // 
            this.backgroundTransition.AutoTransition = false;
            this.backgroundTransition.ColorArray = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(143)))), ((int)(((byte)(127))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(209)))), ((int)(((byte)(180))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(135)))), ((int)(((byte)(153))))),
        System.Drawing.Color.Empty,
        System.Drawing.Color.Empty,
        System.Drawing.Color.Empty,
        System.Drawing.Color.Empty,
        System.Drawing.Color.Empty,
        System.Drawing.Color.Empty};
            this.backgroundTransition.EndColor = System.Drawing.Color.White;
            this.backgroundTransition.Interval = 30;
            this.backgroundTransition.ProgessValue = 0;
            this.backgroundTransition.StartColor = System.Drawing.Color.White;
            this.backgroundTransition.TransitionControl = this;
            // 
            // bunifuTransition
            // 
            this.bunifuTransition.AnimationType = Bunifu.UI.WinForms.BunifuAnimatorNS.AnimationType.VertSlide;
            this.bunifuTransition.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(0);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.bunifuTransition.DefaultAnimation = animation3;
            // 
            // scrollBar
            // 
            this.scrollBar.AllowCursorChanges = true;
            this.scrollBar.AllowHomeEndKeysDetection = false;
            this.scrollBar.AllowIncrementalClickMoves = true;
            this.scrollBar.AllowMouseDownEffects = true;
            this.scrollBar.AllowMouseHoverEffects = true;
            this.scrollBar.AllowScrollingAnimations = true;
            this.scrollBar.AllowScrollKeysDetection = true;
            this.scrollBar.AllowScrollOptionsMenu = true;
            this.scrollBar.AllowShrinkingOnFocusLost = false;
            this.scrollBar.BackgroundColor = System.Drawing.Color.Transparent;
            this.scrollBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("scrollBar.BackgroundImage")));
            this.scrollBar.BindingContainer = this.PokeFlowPanel;
            this.scrollBar.BorderColor = System.Drawing.Color.White;
            this.scrollBar.BorderRadius = 14;
            this.scrollBar.BorderThickness = 1;
            this.bunifuTransition.SetDecoration(this.scrollBar, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.scrollBar.DurationBeforeShrink = 2000;
            this.scrollBar.LargeChange = 10;
            this.scrollBar.Location = new System.Drawing.Point(1711, 173);
            this.scrollBar.Maximum = 1000;
            this.scrollBar.Minimum = 0;
            this.scrollBar.MinimumThumbLength = 18;
            this.scrollBar.Name = "scrollBar";
            this.scrollBar.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.scrollBar.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.scrollBar.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.scrollBar.ScrollBarBorderColor = System.Drawing.Color.White;
            this.scrollBar.ScrollBarColor = System.Drawing.Color.Transparent;
            this.scrollBar.ShrinkSizeLimit = 3;
            this.scrollBar.Size = new System.Drawing.Size(18, 579);
            this.scrollBar.SmallChange = 1;
            this.scrollBar.TabIndex = 91;
            this.scrollBar.ThumbColor = System.Drawing.Color.White;
            this.scrollBar.ThumbLength = 18;
            this.scrollBar.ThumbMargin = 1;
            this.scrollBar.ThumbStyle = Bunifu.UI.WinForms.BunifuVScrollBar.ThumbStyles.Inset;
            this.scrollBar.Value = 1;
            // 
            // PokeType
            // 
            this.PokeType.AutoEllipsis = false;
            this.PokeType.CursorType = null;
            this.bunifuTransition.SetDecoration(this.PokeType, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.PokeType.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PokeType.ForeColor = System.Drawing.Color.White;
            this.PokeType.Location = new System.Drawing.Point(24, 365);
            this.PokeType.Name = "PokeType";
            this.PokeType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PokeType.Size = new System.Drawing.Size(76, 31);
            this.PokeType.TabIndex = 94;
            this.PokeType.Text = "Type : ";
            this.PokeType.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.PokeType.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // hpValueLabel
            // 
            this.hpValueLabel.AutoEllipsis = false;
            this.hpValueLabel.CursorType = null;
            this.bunifuTransition.SetDecoration(this.hpValueLabel, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.hpValueLabel.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hpValueLabel.ForeColor = System.Drawing.Color.White;
            this.hpValueLabel.Location = new System.Drawing.Point(283, 541);
            this.hpValueLabel.Name = "hpValueLabel";
            this.hpValueLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.hpValueLabel.Size = new System.Drawing.Size(31, 21);
            this.hpValueLabel.TabIndex = 95;
            this.hpValueLabel.Text = "100";
            this.hpValueLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.hpValueLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // defenseValueLabel
            // 
            this.defenseValueLabel.AutoEllipsis = false;
            this.defenseValueLabel.CursorType = null;
            this.bunifuTransition.SetDecoration(this.defenseValueLabel, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.defenseValueLabel.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.defenseValueLabel.ForeColor = System.Drawing.Color.White;
            this.defenseValueLabel.Location = new System.Drawing.Point(283, 649);
            this.defenseValueLabel.Name = "defenseValueLabel";
            this.defenseValueLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.defenseValueLabel.Size = new System.Drawing.Size(31, 21);
            this.defenseValueLabel.TabIndex = 96;
            this.defenseValueLabel.Text = "100";
            this.defenseValueLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.defenseValueLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // spAtkContentLabel
            // 
            this.spAtkContentLabel.AutoEllipsis = false;
            this.spAtkContentLabel.CursorType = null;
            this.bunifuTransition.SetDecoration(this.spAtkContentLabel, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.spAtkContentLabel.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spAtkContentLabel.ForeColor = System.Drawing.Color.White;
            this.spAtkContentLabel.Location = new System.Drawing.Point(283, 692);
            this.spAtkContentLabel.Name = "spAtkContentLabel";
            this.spAtkContentLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.spAtkContentLabel.Size = new System.Drawing.Size(31, 21);
            this.spAtkContentLabel.TabIndex = 97;
            this.spAtkContentLabel.Text = "100";
            this.spAtkContentLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.spAtkContentLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // spDefContentLabel
            // 
            this.spDefContentLabel.AutoEllipsis = false;
            this.spDefContentLabel.CursorType = null;
            this.bunifuTransition.SetDecoration(this.spDefContentLabel, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.spDefContentLabel.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spDefContentLabel.ForeColor = System.Drawing.Color.White;
            this.spDefContentLabel.Location = new System.Drawing.Point(283, 754);
            this.spDefContentLabel.Name = "spDefContentLabel";
            this.spDefContentLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.spDefContentLabel.Size = new System.Drawing.Size(31, 21);
            this.spDefContentLabel.TabIndex = 98;
            this.spDefContentLabel.Text = "100";
            this.spDefContentLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.spDefContentLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // speedLabelContent
            // 
            this.speedLabelContent.AutoEllipsis = false;
            this.speedLabelContent.CursorType = null;
            this.bunifuTransition.SetDecoration(this.speedLabelContent, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.speedLabelContent.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speedLabelContent.ForeColor = System.Drawing.Color.White;
            this.speedLabelContent.Location = new System.Drawing.Point(283, 808);
            this.speedLabelContent.Name = "speedLabelContent";
            this.speedLabelContent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.speedLabelContent.Size = new System.Drawing.Size(31, 21);
            this.speedLabelContent.TabIndex = 99;
            this.speedLabelContent.Text = "100";
            this.speedLabelContent.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.speedLabelContent.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoEllipsis = false;
            this.totalLabel.CursorType = null;
            this.bunifuTransition.SetDecoration(this.totalLabel, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.totalLabel.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.ForeColor = System.Drawing.Color.White;
            this.totalLabel.Location = new System.Drawing.Point(283, 856);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.totalLabel.Size = new System.Drawing.Size(31, 21);
            this.totalLabel.TabIndex = 100;
            this.totalLabel.Text = "100";
            this.totalLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.totalLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // hpValue
            // 
            this.hpValue.Animation = 4;
            this.hpValue.AnimationStep = 10;
            this.hpValue.BackColor = System.Drawing.Color.Transparent;
            this.hpValue.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hpValue.BackgroundImage")));
            this.hpValue.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.hpValue.BorderRadius = 10;
            this.hpValue.BorderThickness = 1;
            this.bunifuTransition.SetDecoration(this.hpValue, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.hpValue.Location = new System.Drawing.Point(147, 543);
            this.hpValue.MaximumValue = 255;
            this.hpValue.MinimumValue = 0;
            this.hpValue.Name = "hpValue";
            this.hpValue.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.hpValue.ProgressColorLeft = System.Drawing.Color.White;
            this.hpValue.ProgressColorRight = System.Drawing.Color.White;
            this.hpValue.Size = new System.Drawing.Size(128, 12);
            this.hpValue.TabIndex = 102;
            this.hpValue.Value = 50;
            // 
            // atkValue
            // 
            this.atkValue.Animation = 4;
            this.atkValue.AnimationStep = 10;
            this.atkValue.BackColor = System.Drawing.Color.Transparent;
            this.atkValue.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("atkValue.BackgroundImage")));
            this.atkValue.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.atkValue.BorderRadius = 10;
            this.atkValue.BorderThickness = 1;
            this.bunifuTransition.SetDecoration(this.atkValue, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.atkValue.Location = new System.Drawing.Point(147, 590);
            this.atkValue.MaximumValue = 190;
            this.atkValue.MinimumValue = 0;
            this.atkValue.Name = "atkValue";
            this.atkValue.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.atkValue.ProgressColorLeft = System.Drawing.Color.White;
            this.atkValue.ProgressColorRight = System.Drawing.Color.White;
            this.atkValue.Size = new System.Drawing.Size(128, 12);
            this.atkValue.TabIndex = 103;
            this.atkValue.Value = 50;
            // 
            // defValue
            // 
            this.defValue.Animation = 4;
            this.defValue.AnimationStep = 10;
            this.defValue.BackColor = System.Drawing.Color.Transparent;
            this.defValue.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("defValue.BackgroundImage")));
            this.defValue.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.defValue.BorderRadius = 10;
            this.defValue.BorderThickness = 1;
            this.bunifuTransition.SetDecoration(this.defValue, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.defValue.Location = new System.Drawing.Point(147, 652);
            this.defValue.MaximumValue = 250;
            this.defValue.MinimumValue = 0;
            this.defValue.Name = "defValue";
            this.defValue.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.defValue.ProgressColorLeft = System.Drawing.Color.White;
            this.defValue.ProgressColorRight = System.Drawing.Color.White;
            this.defValue.Size = new System.Drawing.Size(128, 12);
            this.defValue.TabIndex = 104;
            this.defValue.Value = 50;
            // 
            // spAtkValue
            // 
            this.spAtkValue.Animation = 4;
            this.spAtkValue.AnimationStep = 10;
            this.spAtkValue.BackColor = System.Drawing.Color.Transparent;
            this.spAtkValue.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("spAtkValue.BackgroundImage")));
            this.spAtkValue.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.spAtkValue.BorderRadius = 10;
            this.spAtkValue.BorderThickness = 1;
            this.bunifuTransition.SetDecoration(this.spAtkValue, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.spAtkValue.Location = new System.Drawing.Point(147, 696);
            this.spAtkValue.MaximumValue = 194;
            this.spAtkValue.MinimumValue = 0;
            this.spAtkValue.Name = "spAtkValue";
            this.spAtkValue.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.spAtkValue.ProgressColorLeft = System.Drawing.Color.White;
            this.spAtkValue.ProgressColorRight = System.Drawing.Color.White;
            this.spAtkValue.Size = new System.Drawing.Size(128, 12);
            this.spAtkValue.TabIndex = 105;
            this.spAtkValue.Value = 50;
            // 
            // spDefValue
            // 
            this.spDefValue.Animation = 4;
            this.spDefValue.AnimationStep = 10;
            this.spDefValue.BackColor = System.Drawing.Color.Transparent;
            this.spDefValue.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("spDefValue.BackgroundImage")));
            this.spDefValue.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.spDefValue.BorderRadius = 10;
            this.spDefValue.BorderThickness = 1;
            this.bunifuTransition.SetDecoration(this.spDefValue, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.spDefValue.Location = new System.Drawing.Point(147, 758);
            this.spDefValue.MaximumValue = 250;
            this.spDefValue.MinimumValue = 0;
            this.spDefValue.Name = "spDefValue";
            this.spDefValue.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.spDefValue.ProgressColorLeft = System.Drawing.Color.White;
            this.spDefValue.ProgressColorRight = System.Drawing.Color.White;
            this.spDefValue.Size = new System.Drawing.Size(128, 12);
            this.spDefValue.TabIndex = 106;
            this.spDefValue.Value = 50;
            // 
            // speedValue
            // 
            this.speedValue.Animation = 4;
            this.speedValue.AnimationStep = 10;
            this.speedValue.BackColor = System.Drawing.Color.Transparent;
            this.speedValue.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("speedValue.BackgroundImage")));
            this.speedValue.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.speedValue.BorderRadius = 10;
            this.speedValue.BorderThickness = 1;
            this.bunifuTransition.SetDecoration(this.speedValue, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.speedValue.Location = new System.Drawing.Point(147, 811);
            this.speedValue.MaximumValue = 200;
            this.speedValue.MinimumValue = 0;
            this.speedValue.Name = "speedValue";
            this.speedValue.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.speedValue.ProgressColorLeft = System.Drawing.Color.White;
            this.speedValue.ProgressColorRight = System.Drawing.Color.White;
            this.speedValue.Size = new System.Drawing.Size(128, 12);
            this.speedValue.TabIndex = 107;
            this.speedValue.Value = 50;
            // 
            // totalValue
            // 
            this.totalValue.Animation = 4;
            this.totalValue.AnimationStep = 10;
            this.totalValue.BackColor = System.Drawing.Color.Transparent;
            this.totalValue.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("totalValue.BackgroundImage")));
            this.totalValue.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.totalValue.BorderRadius = 10;
            this.totalValue.BorderThickness = 1;
            this.bunifuTransition.SetDecoration(this.totalValue, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.totalValue.Location = new System.Drawing.Point(147, 861);
            this.totalValue.MaximumValue = 1000;
            this.totalValue.MinimumValue = 0;
            this.totalValue.Name = "totalValue";
            this.totalValue.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.totalValue.ProgressColorLeft = System.Drawing.Color.White;
            this.totalValue.ProgressColorRight = System.Drawing.Color.White;
            this.totalValue.Size = new System.Drawing.Size(128, 12);
            this.totalValue.TabIndex = 108;
            this.totalValue.Value = 50;
            // 
            // attackLabel
            // 
            this.attackLabel.AutoEllipsis = false;
            this.attackLabel.CursorType = null;
            this.bunifuTransition.SetDecoration(this.attackLabel, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.attackLabel.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attackLabel.ForeColor = System.Drawing.Color.White;
            this.attackLabel.Location = new System.Drawing.Point(283, 586);
            this.attackLabel.Name = "attackLabel";
            this.attackLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.attackLabel.Size = new System.Drawing.Size(31, 21);
            this.attackLabel.TabIndex = 109;
            this.attackLabel.Text = "100";
            this.attackLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.attackLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition.SetDecoration(this.exitButton, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.exitButton.Image = ((System.Drawing.Image)(resources.GetObject("exitButton.Image")));
            this.exitButton.Location = new System.Drawing.Point(1679, 23);
            this.exitButton.Name = "exitButton";
            this.exitButton.ShadowDecoration.Parent = this.exitButton;
            this.exitButton.Size = new System.Drawing.Size(50, 35);
            this.exitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exitButton.TabIndex = 111;
            this.exitButton.TabStop = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // PokeDex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(209)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(1752, 938);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.attackLabel);
            this.Controls.Add(this.totalValue);
            this.Controls.Add(this.speedValue);
            this.Controls.Add(this.spDefValue);
            this.Controls.Add(this.spAtkValue);
            this.Controls.Add(this.defValue);
            this.Controls.Add(this.atkValue);
            this.Controls.Add(this.hpValue);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.speedLabelContent);
            this.Controls.Add(this.spDefContentLabel);
            this.Controls.Add(this.spAtkContentLabel);
            this.Controls.Add(this.defenseValueLabel);
            this.Controls.Add(this.hpValueLabel);
            this.Controls.Add(this.PokeType);
            this.Controls.Add(this.scrollBar);
            this.Controls.Add(this.pokeNumber);
            this.Controls.Add(this.hpLabel);
            this.Controls.Add(this.speedLabel);
            this.Controls.Add(this.pokemonImage);
            this.Controls.Add(this.totalStatsLabel);
            this.Controls.Add(this.spDefLabel);
            this.Controls.Add(this.spAtkLabel);
            this.Controls.Add(this.atkLabel);
            this.Controls.Add(this.defenseLabel);
            this.Controls.Add(this.pokeType2Content);
            this.Controls.Add(this.type1Content);
            this.Controls.Add(this.PokeFlowPanel);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.speciesValue);
            this.Controls.Add(this.heightValue);
            this.Controls.Add(this.weightValue);
            this.Controls.Add(this.baseStatsLabel);
            this.Controls.Add(this.pokeName);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.bunifuTransition.SetDecoration(this, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PokeDex";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PokeDex";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PokeDex_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PokeDex_MouseMove_1);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PokeDex_MouseUp_1);
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuLabel pokeName;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Bunifu.UI.WinForms.BunifuLabel hpLabel;
        private Bunifu.UI.WinForms.BunifuLabel speedLabel;
        private Bunifu.UI.WinForms.BunifuLabel totalStatsLabel;
        private Bunifu.UI.WinForms.BunifuLabel spDefLabel;
        private Bunifu.UI.WinForms.BunifuLabel spAtkLabel;
        private Bunifu.UI.WinForms.BunifuLabel atkLabel;
        private Bunifu.UI.WinForms.BunifuLabel defenseLabel;
        private Bunifu.UI.WinForms.BunifuLabel pokeType2Content;
        private Bunifu.UI.WinForms.BunifuLabel type1Content;
        private System.Windows.Forms.FlowLayoutPanel PokeFlowPanel;
        private Guna.UI2.WinForms.Guna2PictureBox minimizeButton;
        private Bunifu.UI.WinForms.BunifuLabel speciesValue;
        private Bunifu.UI.WinForms.BunifuLabel heightValue;
        private Bunifu.UI.WinForms.BunifuLabel weightValue;
        private Bunifu.UI.WinForms.BunifuLabel baseStatsLabel;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2PictureBox pokemonImage;
        private Bunifu.UI.WinForms.BunifuLabel pokeNumber;
        private BunifuColorTransition.BunifuColorTransition backgroundTransition;
        private Bunifu.UI.WinForms.BunifuTransition bunifuTransition;
        private Bunifu.UI.WinForms.BunifuVScrollBar scrollBar;
        private Bunifu.UI.WinForms.BunifuLabel totalLabel;
        private Bunifu.UI.WinForms.BunifuLabel speedLabelContent;
        private Bunifu.UI.WinForms.BunifuLabel spDefContentLabel;
        private Bunifu.UI.WinForms.BunifuLabel spAtkContentLabel;
        private Bunifu.UI.WinForms.BunifuLabel defenseValueLabel;
        private Bunifu.UI.WinForms.BunifuLabel hpValueLabel;
        private Bunifu.UI.WinForms.BunifuLabel PokeType;
        private Bunifu.UI.WinForms.BunifuLabel attackLabel;
        private Bunifu.UI.Winforms.BunifuProgressBar totalValue;
        private Bunifu.UI.Winforms.BunifuProgressBar speedValue;
        private Bunifu.UI.Winforms.BunifuProgressBar spDefValue;
        private Bunifu.UI.Winforms.BunifuProgressBar spAtkValue;
        private Bunifu.UI.Winforms.BunifuProgressBar defValue;
        private Bunifu.UI.Winforms.BunifuProgressBar atkValue;
        private Bunifu.UI.Winforms.BunifuProgressBar hpValue;
        private Guna.UI2.WinForms.Guna2PictureBox exitButton;
    }
}

