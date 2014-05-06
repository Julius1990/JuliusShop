using System.Windows.Forms.VisualStyles;
namespace picture_editor
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.bildÖffnenDialog = new System.Windows.Forms.OpenFileDialog();
            this.panelPictureBox = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.filterPanel = new System.Windows.Forms.Panel();
            this.invertierenButton = new System.Windows.Forms.Button();
            this.sepiaFarbenButton = new System.Windows.Forms.Button();
            this.pseudoColorButton = new System.Windows.Forms.Button();
            this.filterLabel = new System.Windows.Forms.Label();
            this.blackWhiteButton = new System.Windows.Forms.Button();
            this.bildSpeichernDialog = new System.Windows.Forms.SaveFileDialog();
            this.skalierenPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.aktuelleGroeseLabel = new System.Windows.Forms.Label();
            this.viertelButton = new System.Windows.Forms.Button();
            this.vierfachButton = new System.Windows.Forms.Button();
            this.halbButton = new System.Windows.Forms.Button();
            this.groeseLabel = new System.Windows.Forms.Label();
            this.zweifachButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.anzeigenPanel = new System.Windows.Forms.Panel();
            this.zoomOutButton = new System.Windows.Forms.Button();
            this.zoomInButton = new System.Windows.Forms.Button();
            this.centerButton = new System.Windows.Forms.Button();
            this.zoomButton = new System.Windows.Forms.Button();
            this.pictureBoxPanel = new System.Windows.Forms.Label();
            this.autosizeButton = new System.Windows.Forms.Button();
            this.histogrammPanel = new System.Windows.Forms.Panel();
            this.histogramPictureBox = new System.Windows.Forms.PictureBox();
            this.graukeilPictureBox = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öffnenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speichernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schließenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.schließenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schrittToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rückgängigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wiederholenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bearbeitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helligkeitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kontrastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogrammToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayscaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rGBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grünToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rGBToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.brightnessTextBox = new System.Windows.Forms.TextBox();
            this.saturationTextBox = new System.Windows.Forms.TextBox();
            this.hueTextBox = new System.Windows.Forms.TextBox();
            this.blauTextBox = new System.Windows.Forms.TextBox();
            this.gruenTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rotTextBox = new System.Windows.Forms.TextBox();
            this.panelPictureBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.filterPanel.SuspendLayout();
            this.skalierenPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.anzeigenPanel.SuspendLayout();
            this.histogrammPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.histogramPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graukeilPictureBox)).BeginInit();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // bildÖffnenDialog
            // 
            this.bildÖffnenDialog.FileName = "openFileDialog1";
            // 
            // panelPictureBox
            // 
            this.panelPictureBox.AutoScroll = true;
            this.panelPictureBox.BackColor = System.Drawing.Color.LightSlateGray;
            this.panelPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPictureBox.Controls.Add(this.pictureBox1);
            this.panelPictureBox.Location = new System.Drawing.Point(124, 40);
            this.panelPictureBox.Name = "panelPictureBox";
            this.panelPictureBox.Size = new System.Drawing.Size(766, 534);
            this.panelPictureBox.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightSlateGray;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(758, 526);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // filterPanel
            // 
            this.filterPanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.filterPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.filterPanel.Controls.Add(this.invertierenButton);
            this.filterPanel.Controls.Add(this.sepiaFarbenButton);
            this.filterPanel.Controls.Add(this.pseudoColorButton);
            this.filterPanel.Controls.Add(this.filterLabel);
            this.filterPanel.Controls.Add(this.blackWhiteButton);
            this.filterPanel.Enabled = false;
            this.filterPanel.Location = new System.Drawing.Point(12, 373);
            this.filterPanel.Name = "filterPanel";
            this.filterPanel.Size = new System.Drawing.Size(106, 146);
            this.filterPanel.TabIndex = 5;
            // 
            // invertierenButton
            // 
            this.invertierenButton.AutoSize = true;
            this.invertierenButton.Location = new System.Drawing.Point(7, 116);
            this.invertierenButton.Name = "invertierenButton";
            this.invertierenButton.Size = new System.Drawing.Size(89, 23);
            this.invertierenButton.TabIndex = 4;
            this.invertierenButton.Text = "Negativ";
            this.invertierenButton.UseVisualStyleBackColor = true;
            this.invertierenButton.Click += new System.EventHandler(this.invertierenButton_Click);
            // 
            // sepiaFarbenButton
            // 
            this.sepiaFarbenButton.AutoSize = true;
            this.sepiaFarbenButton.Location = new System.Drawing.Point(7, 87);
            this.sepiaFarbenButton.Name = "sepiaFarbenButton";
            this.sepiaFarbenButton.Size = new System.Drawing.Size(89, 23);
            this.sepiaFarbenButton.TabIndex = 3;
            this.sepiaFarbenButton.Text = "Sepia Farben";
            this.sepiaFarbenButton.UseVisualStyleBackColor = true;
            this.sepiaFarbenButton.Click += new System.EventHandler(this.sepiaFarbenButton_Click);
            // 
            // pseudoColorButton
            // 
            this.pseudoColorButton.AutoSize = true;
            this.pseudoColorButton.Location = new System.Drawing.Point(7, 59);
            this.pseudoColorButton.Name = "pseudoColorButton";
            this.pseudoColorButton.Size = new System.Drawing.Size(89, 23);
            this.pseudoColorButton.TabIndex = 2;
            this.pseudoColorButton.Text = "Pseudo Farben";
            this.pseudoColorButton.UseVisualStyleBackColor = true;
            this.pseudoColorButton.Click += new System.EventHandler(this.pseudoColorButton_Click);
            // 
            // filterLabel
            // 
            this.filterLabel.AutoSize = true;
            this.filterLabel.BackColor = System.Drawing.Color.Transparent;
            this.filterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterLabel.ForeColor = System.Drawing.Color.Black;
            this.filterLabel.Location = new System.Drawing.Point(3, 7);
            this.filterLabel.Name = "filterLabel";
            this.filterLabel.Size = new System.Drawing.Size(44, 20);
            this.filterLabel.TabIndex = 1;
            this.filterLabel.Text = "Filter";
            // 
            // blackWhiteButton
            // 
            this.blackWhiteButton.AutoSize = true;
            this.blackWhiteButton.Location = new System.Drawing.Point(7, 30);
            this.blackWhiteButton.Name = "blackWhiteButton";
            this.blackWhiteButton.Size = new System.Drawing.Size(89, 23);
            this.blackWhiteButton.TabIndex = 0;
            this.blackWhiteButton.Text = "Grauwertbild";
            this.blackWhiteButton.UseVisualStyleBackColor = true;
            this.blackWhiteButton.Click += new System.EventHandler(this.blackWhite_Click);
            // 
            // bildSpeichernDialog
            // 
            this.bildSpeichernDialog.Filter = "JPG|*.jpg|PNG|*.png|BMP|*.bmp|GIF|*.gif";
            // 
            // skalierenPanel
            // 
            this.skalierenPanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.skalierenPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.skalierenPanel.Controls.Add(this.label1);
            this.skalierenPanel.Controls.Add(this.aktuelleGroeseLabel);
            this.skalierenPanel.Controls.Add(this.viertelButton);
            this.skalierenPanel.Controls.Add(this.vierfachButton);
            this.skalierenPanel.Controls.Add(this.halbButton);
            this.skalierenPanel.Controls.Add(this.groeseLabel);
            this.skalierenPanel.Controls.Add(this.zweifachButton);
            this.skalierenPanel.Enabled = false;
            this.skalierenPanel.Location = new System.Drawing.Point(13, 197);
            this.skalierenPanel.Name = "skalierenPanel";
            this.skalierenPanel.Size = new System.Drawing.Size(105, 170);
            this.skalierenPanel.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(7, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 7;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // aktuelleGroeseLabel
            // 
            this.aktuelleGroeseLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aktuelleGroeseLabel.Location = new System.Drawing.Point(10, 87);
            this.aktuelleGroeseLabel.Name = "aktuelleGroeseLabel";
            this.aktuelleGroeseLabel.Size = new System.Drawing.Size(62, 0);
            this.aktuelleGroeseLabel.TabIndex = 6;
            this.aktuelleGroeseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // viertelButton
            // 
            this.viertelButton.AutoSize = true;
            this.viertelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viertelButton.Location = new System.Drawing.Point(7, 136);
            this.viertelButton.Name = "viertelButton";
            this.viertelButton.Size = new System.Drawing.Size(89, 23);
            this.viertelButton.TabIndex = 5;
            this.viertelButton.UseVisualStyleBackColor = true;
            this.viertelButton.Click += new System.EventHandler(this.viertelButton_Click);
            // 
            // vierfachButton
            // 
            this.vierfachButton.AutoSize = true;
            this.vierfachButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vierfachButton.Location = new System.Drawing.Point(7, 32);
            this.vierfachButton.Name = "vierfachButton";
            this.vierfachButton.Size = new System.Drawing.Size(89, 23);
            this.vierfachButton.TabIndex = 4;
            this.vierfachButton.UseVisualStyleBackColor = true;
            this.vierfachButton.Click += new System.EventHandler(this.vierfachButton_Click);
            // 
            // halbButton
            // 
            this.halbButton.AutoSize = true;
            this.halbButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.halbButton.Location = new System.Drawing.Point(7, 107);
            this.halbButton.Name = "halbButton";
            this.halbButton.Size = new System.Drawing.Size(89, 23);
            this.halbButton.TabIndex = 3;
            this.halbButton.UseVisualStyleBackColor = true;
            this.halbButton.Click += new System.EventHandler(this.verkleinernButton_Click);
            // 
            // groeseLabel
            // 
            this.groeseLabel.AutoSize = true;
            this.groeseLabel.BackColor = System.Drawing.Color.Transparent;
            this.groeseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groeseLabel.ForeColor = System.Drawing.Color.Black;
            this.groeseLabel.Location = new System.Drawing.Point(3, 9);
            this.groeseLabel.Name = "groeseLabel";
            this.groeseLabel.Size = new System.Drawing.Size(75, 20);
            this.groeseLabel.TabIndex = 2;
            this.groeseLabel.Text = "Skalieren";
            // 
            // zweifachButton
            // 
            this.zweifachButton.AutoSize = true;
            this.zweifachButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zweifachButton.Location = new System.Drawing.Point(7, 61);
            this.zweifachButton.Name = "zweifachButton";
            this.zweifachButton.Size = new System.Drawing.Size(90, 23);
            this.zweifachButton.TabIndex = 0;
            this.zweifachButton.UseVisualStyleBackColor = true;
            this.zweifachButton.Click += new System.EventHandler(this.groeserButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.LightSlateGray;
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(254, 86);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // anzeigenPanel
            // 
            this.anzeigenPanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.anzeigenPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.anzeigenPanel.Controls.Add(this.zoomOutButton);
            this.anzeigenPanel.Controls.Add(this.zoomInButton);
            this.anzeigenPanel.Controls.Add(this.centerButton);
            this.anzeigenPanel.Controls.Add(this.zoomButton);
            this.anzeigenPanel.Controls.Add(this.pictureBoxPanel);
            this.anzeigenPanel.Controls.Add(this.autosizeButton);
            this.anzeigenPanel.Enabled = false;
            this.anzeigenPanel.Location = new System.Drawing.Point(13, 40);
            this.anzeigenPanel.Name = "anzeigenPanel";
            this.anzeigenPanel.Size = new System.Drawing.Size(105, 151);
            this.anzeigenPanel.TabIndex = 12;
            // 
            // zoomOutButton
            // 
            this.zoomOutButton.AutoSize = true;
            this.zoomOutButton.Location = new System.Drawing.Point(58, 117);
            this.zoomOutButton.Name = "zoomOutButton";
            this.zoomOutButton.Size = new System.Drawing.Size(38, 23);
            this.zoomOutButton.TabIndex = 6;
            this.zoomOutButton.Text = "-";
            this.zoomOutButton.UseVisualStyleBackColor = true;
            this.zoomOutButton.Visible = false;
            this.zoomOutButton.Click += new System.EventHandler(this.zoomOutButton_Click);
            // 
            // zoomInButton
            // 
            this.zoomInButton.AutoSize = true;
            this.zoomInButton.Location = new System.Drawing.Point(7, 117);
            this.zoomInButton.Name = "zoomInButton";
            this.zoomInButton.Size = new System.Drawing.Size(38, 23);
            this.zoomInButton.TabIndex = 5;
            this.zoomInButton.Text = "+";
            this.zoomInButton.UseVisualStyleBackColor = true;
            this.zoomInButton.Visible = false;
            this.zoomInButton.Click += new System.EventHandler(this.zoomInButton_Click);
            // 
            // centerButton
            // 
            this.centerButton.AutoSize = true;
            this.centerButton.Location = new System.Drawing.Point(7, 59);
            this.centerButton.Name = "centerButton";
            this.centerButton.Size = new System.Drawing.Size(89, 23);
            this.centerButton.TabIndex = 4;
            this.centerButton.Text = "Zentriert";
            this.centerButton.UseVisualStyleBackColor = true;
            this.centerButton.Click += new System.EventHandler(this.centerButton_Click);
            // 
            // zoomButton
            // 
            this.zoomButton.AutoSize = true;
            this.zoomButton.Location = new System.Drawing.Point(7, 88);
            this.zoomButton.Name = "zoomButton";
            this.zoomButton.Size = new System.Drawing.Size(89, 23);
            this.zoomButton.TabIndex = 3;
            this.zoomButton.Text = "Eingepasst";
            this.zoomButton.UseVisualStyleBackColor = true;
            this.zoomButton.Click += new System.EventHandler(this.zoomButton_Click);
            // 
            // pictureBoxPanel
            // 
            this.pictureBoxPanel.AutoSize = true;
            this.pictureBoxPanel.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pictureBoxPanel.ForeColor = System.Drawing.Color.Black;
            this.pictureBoxPanel.Location = new System.Drawing.Point(3, 7);
            this.pictureBoxPanel.Name = "pictureBoxPanel";
            this.pictureBoxPanel.Size = new System.Drawing.Size(76, 20);
            this.pictureBoxPanel.TabIndex = 1;
            this.pictureBoxPanel.Text = "Anzeigen";
            // 
            // autosizeButton
            // 
            this.autosizeButton.AutoSize = true;
            this.autosizeButton.Location = new System.Drawing.Point(7, 30);
            this.autosizeButton.Name = "autosizeButton";
            this.autosizeButton.Size = new System.Drawing.Size(89, 23);
            this.autosizeButton.TabIndex = 0;
            this.autosizeButton.Text = "Volle Größe";
            this.autosizeButton.UseVisualStyleBackColor = true;
            this.autosizeButton.Click += new System.EventHandler(this.autosizeButton_Click);
            // 
            // histogrammPanel
            // 
            this.histogrammPanel.BackColor = System.Drawing.Color.LightSlateGray;
            this.histogrammPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.histogrammPanel.Controls.Add(this.histogramPictureBox);
            this.histogrammPanel.Controls.Add(this.graukeilPictureBox);
            this.histogrammPanel.Location = new System.Drawing.Point(896, 411);
            this.histogrammPanel.Name = "histogrammPanel";
            this.histogrammPanel.Size = new System.Drawing.Size(267, 163);
            this.histogrammPanel.TabIndex = 13;
            // 
            // histogramPictureBox
            // 
            this.histogramPictureBox.Location = new System.Drawing.Point(3, 3);
            this.histogramPictureBox.Name = "histogramPictureBox";
            this.histogramPictureBox.Size = new System.Drawing.Size(255, 132);
            this.histogramPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.histogramPictureBox.TabIndex = 1;
            this.histogramPictureBox.TabStop = false;
            // 
            // graukeilPictureBox
            // 
            this.graukeilPictureBox.BackColor = System.Drawing.Color.LightSlateGray;
            this.graukeilPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.graukeilPictureBox.Location = new System.Drawing.Point(2, 137);
            this.graukeilPictureBox.Name = "graukeilPictureBox";
            this.graukeilPictureBox.Size = new System.Drawing.Size(257, 15);
            this.graukeilPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.graukeilPictureBox.TabIndex = 0;
            this.graukeilPictureBox.TabStop = false;
            this.graukeilPictureBox.Visible = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(3, 3);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(96, 40);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Location = new System.Drawing.Point(12, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1151, 26);
            this.panel2.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.schrittToolStripMenuItem,
            this.bearbeitenToolStripMenuItem,
            this.histogrammToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1149, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öffnenToolStripMenuItem,
            this.speichernToolStripMenuItem,
            this.schließenToolStripMenuItem1,
            this.schließenToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // öffnenToolStripMenuItem
            // 
            this.öffnenToolStripMenuItem.Name = "öffnenToolStripMenuItem";
            this.öffnenToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.öffnenToolStripMenuItem.Text = "Öffnen";
            this.öffnenToolStripMenuItem.Click += new System.EventHandler(this.öffnenToolStripMenuItem_Click_1);
            // 
            // speichernToolStripMenuItem
            // 
            this.speichernToolStripMenuItem.Name = "speichernToolStripMenuItem";
            this.speichernToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.speichernToolStripMenuItem.Text = "Speichern";
            this.speichernToolStripMenuItem.Click += new System.EventHandler(this.speichernToolStripMenuItem_Click_1);
            // 
            // schließenToolStripMenuItem1
            // 
            this.schließenToolStripMenuItem1.Name = "schließenToolStripMenuItem1";
            this.schließenToolStripMenuItem1.Size = new System.Drawing.Size(126, 22);
            this.schließenToolStripMenuItem1.Text = "Schließen";
            this.schließenToolStripMenuItem1.Click += new System.EventHandler(this.schließenToolStripMenuItem1_Click);
            // 
            // schließenToolStripMenuItem
            // 
            this.schließenToolStripMenuItem.Name = "schließenToolStripMenuItem";
            this.schließenToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.schließenToolStripMenuItem.Text = "Beenden";
            this.schließenToolStripMenuItem.Click += new System.EventHandler(this.schließenToolStripMenuItem_Click);
            // 
            // schrittToolStripMenuItem
            // 
            this.schrittToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rückgängigToolStripMenuItem,
            this.wiederholenToolStripMenuItem});
            this.schrittToolStripMenuItem.Name = "schrittToolStripMenuItem";
            this.schrittToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.schrittToolStripMenuItem.Text = "Schritt";
            // 
            // rückgängigToolStripMenuItem
            // 
            this.rückgängigToolStripMenuItem.Name = "rückgängigToolStripMenuItem";
            this.rückgängigToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.rückgängigToolStripMenuItem.Text = "Rückgängig";
            this.rückgängigToolStripMenuItem.Click += new System.EventHandler(this.rückgängigToolStripMenuItem_Click);
            // 
            // wiederholenToolStripMenuItem
            // 
            this.wiederholenToolStripMenuItem.Name = "wiederholenToolStripMenuItem";
            this.wiederholenToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.wiederholenToolStripMenuItem.Text = "Wiederholen";
            this.wiederholenToolStripMenuItem.Click += new System.EventHandler(this.wiederholenToolStripMenuItem_Click);
            // 
            // bearbeitenToolStripMenuItem
            // 
            this.bearbeitenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helligkeitToolStripMenuItem,
            this.kontrastToolStripMenuItem});
            this.bearbeitenToolStripMenuItem.Name = "bearbeitenToolStripMenuItem";
            this.bearbeitenToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.bearbeitenToolStripMenuItem.Text = "Bearbeiten";
            // 
            // helligkeitToolStripMenuItem
            // 
            this.helligkeitToolStripMenuItem.Name = "helligkeitToolStripMenuItem";
            this.helligkeitToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.helligkeitToolStripMenuItem.Text = "Helligkeit";
            this.helligkeitToolStripMenuItem.Click += new System.EventHandler(this.helligkeitToolStripMenuItem_Click);
            // 
            // kontrastToolStripMenuItem
            // 
            this.kontrastToolStripMenuItem.Name = "kontrastToolStripMenuItem";
            this.kontrastToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.kontrastToolStripMenuItem.Text = "Kontrast";
            this.kontrastToolStripMenuItem.Click += new System.EventHandler(this.kontrastToolStripMenuItem_Click);
            // 
            // histogrammToolStripMenuItem
            // 
            this.histogrammToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.grayscaleToolStripMenuItem,
            this.rGBToolStripMenuItem,
            this.grünToolStripMenuItem,
            this.blauToolStripMenuItem,
            this.rGBToolStripMenuItem1});
            this.histogrammToolStripMenuItem.Name = "histogrammToolStripMenuItem";
            this.histogrammToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.histogrammToolStripMenuItem.Text = "Histogramm";
            // 
            // grayscaleToolStripMenuItem
            // 
            this.grayscaleToolStripMenuItem.Name = "grayscaleToolStripMenuItem";
            this.grayscaleToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.grayscaleToolStripMenuItem.Text = "Grauwert";
            this.grayscaleToolStripMenuItem.Click += new System.EventHandler(this.grayscaleToolStripMenuItem_Click);
            // 
            // rGBToolStripMenuItem
            // 
            this.rGBToolStripMenuItem.Name = "rGBToolStripMenuItem";
            this.rGBToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.rGBToolStripMenuItem.Text = "Rot";
            this.rGBToolStripMenuItem.Click += new System.EventHandler(this.rGBToolStripMenuItem_Click);
            // 
            // grünToolStripMenuItem
            // 
            this.grünToolStripMenuItem.Name = "grünToolStripMenuItem";
            this.grünToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.grünToolStripMenuItem.Text = "Grün";
            this.grünToolStripMenuItem.Click += new System.EventHandler(this.grünToolStripMenuItem_Click);
            // 
            // blauToolStripMenuItem
            // 
            this.blauToolStripMenuItem.Name = "blauToolStripMenuItem";
            this.blauToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.blauToolStripMenuItem.Text = "Blau";
            this.blauToolStripMenuItem.Click += new System.EventHandler(this.blauToolStripMenuItem_Click);
            // 
            // rGBToolStripMenuItem1
            // 
            this.rGBToolStripMenuItem1.Name = "rGBToolStripMenuItem1";
            this.rGBToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.rGBToolStripMenuItem1.Text = "RGB";
            this.rGBToolStripMenuItem1.Click += new System.EventHandler(this.rGBToolStripMenuItem1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Location = new System.Drawing.Point(896, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(267, 182);
            this.panel3.TabIndex = 15;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.LightSlateGray;
            this.pictureBox3.Location = new System.Drawing.Point(3, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(257, 172);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.progressBar1);
            this.panel4.Location = new System.Drawing.Point(12, 525);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(106, 49);
            this.panel4.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.brightnessTextBox);
            this.panel5.Controls.Add(this.saturationTextBox);
            this.panel5.Controls.Add(this.hueTextBox);
            this.panel5.Controls.Add(this.blauTextBox);
            this.panel5.Controls.Add(this.gruenTextBox);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.rotTextBox);
            this.panel5.Controls.Add(this.pictureBox2);
            this.panel5.Location = new System.Drawing.Point(896, 231);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(267, 174);
            this.panel5.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(90, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Brightness";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(90, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Saturation";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(90, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Hue";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Blau";
            // 
            // brightnessTextBox
            // 
            this.brightnessTextBox.Location = new System.Drawing.Point(3, 147);
            this.brightnessTextBox.Name = "brightnessTextBox";
            this.brightnessTextBox.Size = new System.Drawing.Size(81, 20);
            this.brightnessTextBox.TabIndex = 19;
            // 
            // saturationTextBox
            // 
            this.saturationTextBox.Location = new System.Drawing.Point(3, 121);
            this.saturationTextBox.Name = "saturationTextBox";
            this.saturationTextBox.Size = new System.Drawing.Size(81, 20);
            this.saturationTextBox.TabIndex = 18;
            // 
            // hueTextBox
            // 
            this.hueTextBox.Location = new System.Drawing.Point(3, 95);
            this.hueTextBox.Name = "hueTextBox";
            this.hueTextBox.Size = new System.Drawing.Size(81, 20);
            this.hueTextBox.TabIndex = 17;
            // 
            // blauTextBox
            // 
            this.blauTextBox.Location = new System.Drawing.Point(209, 147);
            this.blauTextBox.Name = "blauTextBox";
            this.blauTextBox.Size = new System.Drawing.Size(48, 20);
            this.blauTextBox.TabIndex = 16;
            // 
            // gruenTextBox
            // 
            this.gruenTextBox.Location = new System.Drawing.Point(209, 121);
            this.gruenTextBox.Name = "gruenTextBox";
            this.gruenTextBox.Size = new System.Drawing.Size(48, 20);
            this.gruenTextBox.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Grün";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Rot";
            // 
            // rotTextBox
            // 
            this.rotTextBox.Location = new System.Drawing.Point(209, 95);
            this.rotTextBox.Name = "rotTextBox";
            this.rotTextBox.Size = new System.Drawing.Size(49, 20);
            this.rotTextBox.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1169, 582);
            this.ControlBox = false;
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panelPictureBox);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.histogrammPanel);
            this.Controls.Add(this.anzeigenPanel);
            this.Controls.Add(this.skalierenPanel);
            this.Controls.Add(this.filterPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Picture Editor by Julius Weyl";
            this.TransparencyKey = System.Drawing.Color.Crimson;
            this.panelPictureBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.filterPanel.ResumeLayout(false);
            this.filterPanel.PerformLayout();
            this.skalierenPanel.ResumeLayout(false);
            this.skalierenPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.anzeigenPanel.ResumeLayout(false);
            this.anzeigenPanel.PerformLayout();
            this.histogrammPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.histogramPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graukeilPictureBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.OpenFileDialog bildÖffnenDialog;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel filterPanel;
        private System.Windows.Forms.Button blackWhiteButton;
        private System.Windows.Forms.Label filterLabel;
        private System.Windows.Forms.Button pseudoColorButton;
        private System.Windows.Forms.Button sepiaFarbenButton;
        private System.Windows.Forms.SaveFileDialog bildSpeichernDialog;
        private System.Windows.Forms.Panel skalierenPanel;
        private System.Windows.Forms.Button halbButton;
        private System.Windows.Forms.Label groeseLabel;
        private System.Windows.Forms.Button zweifachButton;
        public System.Windows.Forms.Panel panelPictureBox;
        private System.Windows.Forms.Button vierfachButton;
        private System.Windows.Forms.Button viertelButton;
        private System.Windows.Forms.Label aktuelleGroeseLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button invertierenButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel anzeigenPanel;
        private System.Windows.Forms.Button centerButton;
        private System.Windows.Forms.Button zoomButton;
        private System.Windows.Forms.Label pictureBoxPanel;
        private System.Windows.Forms.Button autosizeButton;
        private System.Windows.Forms.Button zoomOutButton;
        private System.Windows.Forms.Button zoomInButton;
        private System.Windows.Forms.Panel histogrammPanel;
        private System.Windows.Forms.PictureBox graukeilPictureBox;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öffnenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem speichernToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schließenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schrittToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rückgängigToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wiederholenToolStripMenuItem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ToolStripMenuItem bearbeitenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helligkeitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kontrastToolStripMenuItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox brightnessTextBox;
        private System.Windows.Forms.TextBox saturationTextBox;
        private System.Windows.Forms.TextBox hueTextBox;
        private System.Windows.Forms.TextBox blauTextBox;
        private System.Windows.Forms.TextBox gruenTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox rotTextBox;
        private System.Windows.Forms.PictureBox histogramPictureBox;
        private System.Windows.Forms.ToolStripMenuItem schließenToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem histogrammToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grayscaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rGBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grünToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blauToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rGBToolStripMenuItem1;
    }
}

