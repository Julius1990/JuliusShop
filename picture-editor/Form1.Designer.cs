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
            this.loadPictureButton = new System.Windows.Forms.Button();
            this.bildÖffnenDialog = new System.Windows.Forms.OpenFileDialog();
            this.panelPictureBox = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.filterPanel = new System.Windows.Forms.Panel();
            this.invertierenButton = new System.Windows.Forms.Button();
            this.sepiaFarbenButton = new System.Windows.Forms.Button();
            this.pseudoColorButton = new System.Windows.Forms.Button();
            this.filterLabel = new System.Windows.Forms.Label();
            this.blackWhiteButton = new System.Windows.Forms.Button();
            this.schrittePanel = new System.Windows.Forms.Panel();
            this.schrittZurueckButton = new System.Windows.Forms.Button();
            this.schrittLabel = new System.Windows.Forms.Label();
            this.schrittVorButton = new System.Windows.Forms.Button();
            this.betrachtenButton = new System.Windows.Forms.Button();
            this.contrastButton = new System.Windows.Forms.Button();
            this.safeButton = new System.Windows.Forms.Button();
            this.bildSpeichernDialog = new System.Windows.Forms.SaveFileDialog();
            this.helligkeitPanel = new System.Windows.Forms.Panel();
            this.helligkeitButton = new System.Windows.Forms.Button();
            this.helligkeitLabel = new System.Windows.Forms.Label();
            this.groesePanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.aktuelleGroeseLabel = new System.Windows.Forms.Label();
            this.viertelButton = new System.Windows.Forms.Button();
            this.vierfachButton = new System.Windows.Forms.Button();
            this.halbButton = new System.Windows.Forms.Button();
            this.groeseLabel = new System.Windows.Forms.Label();
            this.zweifachButton = new System.Windows.Forms.Button();
            this.bildPanel = new System.Windows.Forms.Panel();
            this.bildLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.centerButton = new System.Windows.Forms.Button();
            this.zoomButton = new System.Windows.Forms.Button();
            this.pictureBoxPanel = new System.Windows.Forms.Label();
            this.autosizeButton = new System.Windows.Forms.Button();
            this.panelPictureBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.filterPanel.SuspendLayout();
            this.schrittePanel.SuspendLayout();
            this.helligkeitPanel.SuspendLayout();
            this.groesePanel.SuspendLayout();
            this.bildPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // loadPictureButton
            // 
            this.loadPictureButton.Location = new System.Drawing.Point(7, 32);
            this.loadPictureButton.Name = "loadPictureButton";
            this.loadPictureButton.Size = new System.Drawing.Size(84, 23);
            this.loadPictureButton.TabIndex = 2;
            this.loadPictureButton.Text = "öffnen";
            this.loadPictureButton.UseVisualStyleBackColor = true;
            this.loadPictureButton.Click += new System.EventHandler(this.loadPictureButton_Click);
            // 
            // bildÖffnenDialog
            // 
            this.bildÖffnenDialog.FileName = "openFileDialog1";
            this.bildÖffnenDialog.Filter = "JPG|*.jpg";
            // 
            // panelPictureBox
            // 
            this.panelPictureBox.AutoScroll = true;
            this.panelPictureBox.BackColor = System.Drawing.Color.LightGray;
            this.panelPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPictureBox.Controls.Add(this.pictureBox1);
            this.panelPictureBox.Location = new System.Drawing.Point(128, 12);
            this.panelPictureBox.Name = "panelPictureBox";
            this.panelPictureBox.Size = new System.Drawing.Size(681, 519);
            this.panelPictureBox.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(673, 510);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // filterPanel
            // 
            this.filterPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.filterPanel.Controls.Add(this.invertierenButton);
            this.filterPanel.Controls.Add(this.sepiaFarbenButton);
            this.filterPanel.Controls.Add(this.pseudoColorButton);
            this.filterPanel.Controls.Add(this.filterLabel);
            this.filterPanel.Controls.Add(this.blackWhiteButton);
            this.filterPanel.Location = new System.Drawing.Point(815, 108);
            this.filterPanel.Name = "filterPanel";
            this.filterPanel.Size = new System.Drawing.Size(119, 146);
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
            this.filterLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
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
            this.blackWhiteButton.Text = "Schwarz-Weiß";
            this.blackWhiteButton.UseVisualStyleBackColor = true;
            this.blackWhiteButton.Click += new System.EventHandler(this.blackWhite_Click);
            // 
            // schrittePanel
            // 
            this.schrittePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.schrittePanel.Controls.Add(this.schrittZurueckButton);
            this.schrittePanel.Controls.Add(this.schrittLabel);
            this.schrittePanel.Controls.Add(this.schrittVorButton);
            this.schrittePanel.Location = new System.Drawing.Point(815, 12);
            this.schrittePanel.Name = "schrittePanel";
            this.schrittePanel.Size = new System.Drawing.Size(119, 90);
            this.schrittePanel.TabIndex = 1;
            // 
            // schrittZurueckButton
            // 
            this.schrittZurueckButton.AutoSize = true;
            this.schrittZurueckButton.Location = new System.Drawing.Point(53, 42);
            this.schrittZurueckButton.Name = "schrittZurueckButton";
            this.schrittZurueckButton.Size = new System.Drawing.Size(55, 35);
            this.schrittZurueckButton.TabIndex = 3;
            this.schrittZurueckButton.Text = "zurueck";
            this.schrittZurueckButton.UseVisualStyleBackColor = true;
            this.schrittZurueckButton.Click += new System.EventHandler(this.schrittZurueckButton_Click);
            // 
            // schrittLabel
            // 
            this.schrittLabel.AutoSize = true;
            this.schrittLabel.BackColor = System.Drawing.Color.Transparent;
            this.schrittLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schrittLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.schrittLabel.Location = new System.Drawing.Point(3, 9);
            this.schrittLabel.Name = "schrittLabel";
            this.schrittLabel.Size = new System.Drawing.Size(64, 20);
            this.schrittLabel.TabIndex = 2;
            this.schrittLabel.Text = "Schritte";
            // 
            // schrittVorButton
            // 
            this.schrittVorButton.AutoSize = true;
            this.schrittVorButton.Location = new System.Drawing.Point(3, 42);
            this.schrittVorButton.Name = "schrittVorButton";
            this.schrittVorButton.Size = new System.Drawing.Size(44, 35);
            this.schrittVorButton.TabIndex = 0;
            this.schrittVorButton.Text = "vor";
            this.schrittVorButton.UseVisualStyleBackColor = true;
            this.schrittVorButton.Click += new System.EventHandler(this.schrittVorButton_Click);
            // 
            // betrachtenButton
            // 
            this.betrachtenButton.Location = new System.Drawing.Point(7, 92);
            this.betrachtenButton.Name = "betrachtenButton";
            this.betrachtenButton.Size = new System.Drawing.Size(84, 23);
            this.betrachtenButton.TabIndex = 6;
            this.betrachtenButton.Text = "betrachten";
            this.betrachtenButton.UseVisualStyleBackColor = true;
            this.betrachtenButton.Visible = false;
            this.betrachtenButton.Click += new System.EventHandler(this.viewerOpenButton_Click);
            // 
            // contrastButton
            // 
            this.contrastButton.AutoSize = true;
            this.contrastButton.Location = new System.Drawing.Point(7, 61);
            this.contrastButton.Name = "contrastButton";
            this.contrastButton.Size = new System.Drawing.Size(90, 23);
            this.contrastButton.TabIndex = 4;
            this.contrastButton.Text = "Kontrast";
            this.contrastButton.UseVisualStyleBackColor = true;
            this.contrastButton.Click += new System.EventHandler(this.contrastButton_Click);
            // 
            // safeButton
            // 
            this.safeButton.Location = new System.Drawing.Point(7, 61);
            this.safeButton.Name = "safeButton";
            this.safeButton.Size = new System.Drawing.Size(84, 23);
            this.safeButton.TabIndex = 8;
            this.safeButton.Text = "speichern";
            this.safeButton.UseVisualStyleBackColor = true;
            this.safeButton.Visible = false;
            this.safeButton.Click += new System.EventHandler(this.safeButton_Click);
            // 
            // bildSpeichernDialog
            // 
            this.bildSpeichernDialog.Filter = "JPG|*.jpg|PNG|*.png";
            // 
            // helligkeitPanel
            // 
            this.helligkeitPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.helligkeitPanel.Controls.Add(this.contrastButton);
            this.helligkeitPanel.Controls.Add(this.helligkeitButton);
            this.helligkeitPanel.Controls.Add(this.helligkeitLabel);
            this.helligkeitPanel.Location = new System.Drawing.Point(815, 260);
            this.helligkeitPanel.Name = "helligkeitPanel";
            this.helligkeitPanel.Size = new System.Drawing.Size(119, 94);
            this.helligkeitPanel.TabIndex = 9;
            // 
            // helligkeitButton
            // 
            this.helligkeitButton.AutoSize = true;
            this.helligkeitButton.Location = new System.Drawing.Point(7, 32);
            this.helligkeitButton.Name = "helligkeitButton";
            this.helligkeitButton.Size = new System.Drawing.Size(90, 23);
            this.helligkeitButton.TabIndex = 3;
            this.helligkeitButton.Text = "Helligkeit";
            this.helligkeitButton.UseVisualStyleBackColor = true;
            this.helligkeitButton.Click += new System.EventHandler(this.helligkeitButton_Click);
            // 
            // helligkeitLabel
            // 
            this.helligkeitLabel.AutoSize = true;
            this.helligkeitLabel.BackColor = System.Drawing.Color.Transparent;
            this.helligkeitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helligkeitLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.helligkeitLabel.Location = new System.Drawing.Point(3, 9);
            this.helligkeitLabel.Name = "helligkeitLabel";
            this.helligkeitLabel.Size = new System.Drawing.Size(105, 20);
            this.helligkeitLabel.TabIndex = 2;
            this.helligkeitLabel.Text = "Einstellungen";
            // 
            // groesePanel
            // 
            this.groesePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.groesePanel.Controls.Add(this.label1);
            this.groesePanel.Controls.Add(this.aktuelleGroeseLabel);
            this.groesePanel.Controls.Add(this.viertelButton);
            this.groesePanel.Controls.Add(this.vierfachButton);
            this.groesePanel.Controls.Add(this.halbButton);
            this.groesePanel.Controls.Add(this.groeseLabel);
            this.groesePanel.Controls.Add(this.zweifachButton);
            this.groesePanel.Location = new System.Drawing.Point(7, 266);
            this.groesePanel.Name = "groesePanel";
            this.groesePanel.Size = new System.Drawing.Size(105, 170);
            this.groesePanel.TabIndex = 8;
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
            this.groeseLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
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
            // bildPanel
            // 
            this.bildPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bildPanel.Controls.Add(this.bildLabel);
            this.bildPanel.Controls.Add(this.betrachtenButton);
            this.bildPanel.Controls.Add(this.loadPictureButton);
            this.bildPanel.Controls.Add(this.safeButton);
            this.bildPanel.Location = new System.Drawing.Point(7, 12);
            this.bildPanel.Name = "bildPanel";
            this.bildPanel.Size = new System.Drawing.Size(110, 122);
            this.bildPanel.TabIndex = 4;
            // 
            // bildLabel
            // 
            this.bildLabel.AutoSize = true;
            this.bildLabel.BackColor = System.Drawing.Color.Transparent;
            this.bildLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bildLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.bildLabel.Location = new System.Drawing.Point(3, 9);
            this.bildLabel.Name = "bildLabel";
            this.bildLabel.Size = new System.Drawing.Size(35, 20);
            this.bildLabel.TabIndex = 2;
            this.bildLabel.Text = "Bild";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(815, 360);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(115, 82);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.centerButton);
            this.panel1.Controls.Add(this.zoomButton);
            this.panel1.Controls.Add(this.pictureBoxPanel);
            this.panel1.Controls.Add(this.autosizeButton);
            this.panel1.Location = new System.Drawing.Point(7, 140);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(105, 120);
            this.panel1.TabIndex = 12;
            // 
            // centerButton
            // 
            this.centerButton.AutoSize = true;
            this.centerButton.Location = new System.Drawing.Point(7, 88);
            this.centerButton.Name = "centerButton";
            this.centerButton.Size = new System.Drawing.Size(89, 23);
            this.centerButton.TabIndex = 4;
            this.centerButton.Text = "Zoom";
            this.centerButton.UseVisualStyleBackColor = true;
            this.centerButton.Click += new System.EventHandler(this.centerButton_Click);
            // 
            // zoomButton
            // 
            this.zoomButton.AutoSize = true;
            this.zoomButton.Location = new System.Drawing.Point(7, 59);
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
            this.pictureBoxPanel.ForeColor = System.Drawing.Color.CornflowerBlue;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 539);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.bildPanel);
            this.Controls.Add(this.groesePanel);
            this.Controls.Add(this.helligkeitPanel);
            this.Controls.Add(this.schrittePanel);
            this.Controls.Add(this.filterPanel);
            this.Controls.Add(this.panelPictureBox);
            this.Name = "Form1";
            this.Text = "Photoshop für Arme";
            this.panelPictureBox.ResumeLayout(false);
            this.panelPictureBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.filterPanel.ResumeLayout(false);
            this.filterPanel.PerformLayout();
            this.schrittePanel.ResumeLayout(false);
            this.schrittePanel.PerformLayout();
            this.helligkeitPanel.ResumeLayout(false);
            this.helligkeitPanel.PerformLayout();
            this.groesePanel.ResumeLayout(false);
            this.groesePanel.PerformLayout();
            this.bildPanel.ResumeLayout(false);
            this.bildPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button loadPictureButton;
        private System.Windows.Forms.OpenFileDialog bildÖffnenDialog;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel filterPanel;
        private System.Windows.Forms.Button blackWhiteButton;
        private System.Windows.Forms.Label filterLabel;
        private System.Windows.Forms.Panel schrittePanel;
        private System.Windows.Forms.Button schrittZurueckButton;
        private System.Windows.Forms.Label schrittLabel;
        private System.Windows.Forms.Button schrittVorButton;
        private System.Windows.Forms.Button pseudoColorButton;
        private System.Windows.Forms.Button sepiaFarbenButton;
        private System.Windows.Forms.Button betrachtenButton;
        private System.Windows.Forms.Button safeButton;
        private System.Windows.Forms.SaveFileDialog bildSpeichernDialog;
        private System.Windows.Forms.Panel helligkeitPanel;
        private System.Windows.Forms.Label helligkeitLabel;
        private System.Windows.Forms.Panel groesePanel;
        private System.Windows.Forms.Button halbButton;
        private System.Windows.Forms.Label groeseLabel;
        private System.Windows.Forms.Button zweifachButton;
        private System.Windows.Forms.Panel bildPanel;
        private System.Windows.Forms.Label bildLabel;
        public System.Windows.Forms.Panel panelPictureBox;
        private System.Windows.Forms.Button helligkeitButton;
        private System.Windows.Forms.Button contrastButton;
        private System.Windows.Forms.Button vierfachButton;
        private System.Windows.Forms.Button viertelButton;
        private System.Windows.Forms.Label aktuelleGroeseLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button invertierenButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button centerButton;
        private System.Windows.Forms.Button zoomButton;
        private System.Windows.Forms.Label pictureBoxPanel;
        private System.Windows.Forms.Button autosizeButton;
    }
}

