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
            this.openColorDialogButton = new System.Windows.Forms.Button();
            this.loadPictureButton = new System.Windows.Forms.Button();
            this.bildÖffnenDialog = new System.Windows.Forms.OpenFileDialog();
            this.panelPictureBox = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.filterPanel = new System.Windows.Forms.Panel();
            this.sepiaFarbenButton = new System.Windows.Forms.Button();
            this.pseudoColorButton = new System.Windows.Forms.Button();
            this.filterLabel = new System.Windows.Forms.Label();
            this.blackWhiteButton = new System.Windows.Forms.Button();
            this.schrittePanel = new System.Windows.Forms.Panel();
            this.schrittZurueckButton = new System.Windows.Forms.Button();
            this.schrittLabel = new System.Windows.Forms.Label();
            this.schrittVorButton = new System.Windows.Forms.Button();
            this.viewerOpenButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.runterLabel = new System.Windows.Forms.Button();
            this.contrastLabel = new System.Windows.Forms.Label();
            this.hochLabel = new System.Windows.Forms.Button();
            this.safeButton = new System.Windows.Forms.Button();
            this.bildSpeichernDialog = new System.Windows.Forms.SaveFileDialog();
            this.helligkeitPanel = new System.Windows.Forms.Panel();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.helligkeitLabel = new System.Windows.Forms.Label();
            this.groesePanel = new System.Windows.Forms.Panel();
            this.verkleinernButton = new System.Windows.Forms.Button();
            this.groeseLabel = new System.Windows.Forms.Label();
            this.groeserButton = new System.Windows.Forms.Button();
            this.panelPictureBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.filterPanel.SuspendLayout();
            this.schrittePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.helligkeitPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groesePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // openColorDialogButton
            // 
            this.openColorDialogButton.Location = new System.Drawing.Point(12, 12);
            this.openColorDialogButton.Name = "openColorDialogButton";
            this.openColorDialogButton.Size = new System.Drawing.Size(100, 23);
            this.openColorDialogButton.TabIndex = 0;
            this.openColorDialogButton.Text = "Color Dialog";
            this.openColorDialogButton.UseVisualStyleBackColor = true;
            this.openColorDialogButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // loadPictureButton
            // 
            this.loadPictureButton.Location = new System.Drawing.Point(12, 479);
            this.loadPictureButton.Name = "loadPictureButton";
            this.loadPictureButton.Size = new System.Drawing.Size(100, 23);
            this.loadPictureButton.TabIndex = 2;
            this.loadPictureButton.Text = "Bild öffnen";
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
            this.panelPictureBox.Location = new System.Drawing.Point(118, 12);
            this.panelPictureBox.Name = "panelPictureBox";
            this.panelPictureBox.Size = new System.Drawing.Size(666, 519);
            this.panelPictureBox.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // filterPanel
            // 
            this.filterPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.filterPanel.Controls.Add(this.sepiaFarbenButton);
            this.filterPanel.Controls.Add(this.pseudoColorButton);
            this.filterPanel.Controls.Add(this.filterLabel);
            this.filterPanel.Controls.Add(this.blackWhiteButton);
            this.filterPanel.Location = new System.Drawing.Point(790, 108);
            this.filterPanel.Name = "filterPanel";
            this.filterPanel.Size = new System.Drawing.Size(129, 120);
            this.filterPanel.TabIndex = 5;
            // 
            // sepiaFarbenButton
            // 
            this.sepiaFarbenButton.AutoSize = true;
            this.sepiaFarbenButton.Location = new System.Drawing.Point(3, 88);
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
            this.pseudoColorButton.Location = new System.Drawing.Point(3, 59);
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
            this.blackWhiteButton.Location = new System.Drawing.Point(3, 30);
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
            this.schrittePanel.Location = new System.Drawing.Point(790, 12);
            this.schrittePanel.Name = "schrittePanel";
            this.schrittePanel.Size = new System.Drawing.Size(129, 90);
            this.schrittePanel.TabIndex = 1;
            // 
            // schrittZurueckButton
            // 
            this.schrittZurueckButton.AutoSize = true;
            this.schrittZurueckButton.Location = new System.Drawing.Point(61, 42);
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
            this.schrittVorButton.Size = new System.Drawing.Size(52, 35);
            this.schrittVorButton.TabIndex = 0;
            this.schrittVorButton.Text = "vor";
            this.schrittVorButton.UseVisualStyleBackColor = true;
            this.schrittVorButton.Click += new System.EventHandler(this.schrittVorButton_Click);
            // 
            // viewerOpenButton
            // 
            this.viewerOpenButton.Location = new System.Drawing.Point(12, 450);
            this.viewerOpenButton.Name = "viewerOpenButton";
            this.viewerOpenButton.Size = new System.Drawing.Size(100, 23);
            this.viewerOpenButton.TabIndex = 6;
            this.viewerOpenButton.Text = "Bild öffnen mit";
            this.viewerOpenButton.UseVisualStyleBackColor = true;
            this.viewerOpenButton.Click += new System.EventHandler(this.viewerOpenButton_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.runterLabel);
            this.panel1.Controls.Add(this.contrastLabel);
            this.panel1.Controls.Add(this.hochLabel);
            this.panel1.Location = new System.Drawing.Point(790, 234);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(129, 90);
            this.panel1.TabIndex = 7;
            // 
            // runterLabel
            // 
            this.runterLabel.AutoSize = true;
            this.runterLabel.Location = new System.Drawing.Point(61, 42);
            this.runterLabel.Name = "runterLabel";
            this.runterLabel.Size = new System.Drawing.Size(55, 35);
            this.runterLabel.TabIndex = 3;
            this.runterLabel.Text = "runter";
            this.runterLabel.UseVisualStyleBackColor = true;
            this.runterLabel.Click += new System.EventHandler(this.runterLabel_Click);
            // 
            // contrastLabel
            // 
            this.contrastLabel.AutoSize = true;
            this.contrastLabel.BackColor = System.Drawing.Color.Transparent;
            this.contrastLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contrastLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.contrastLabel.Location = new System.Drawing.Point(3, 9);
            this.contrastLabel.Name = "contrastLabel";
            this.contrastLabel.Size = new System.Drawing.Size(69, 20);
            this.contrastLabel.TabIndex = 2;
            this.contrastLabel.Text = "Kontrast";
            // 
            // hochLabel
            // 
            this.hochLabel.AutoSize = true;
            this.hochLabel.Location = new System.Drawing.Point(3, 42);
            this.hochLabel.Name = "hochLabel";
            this.hochLabel.Size = new System.Drawing.Size(52, 35);
            this.hochLabel.TabIndex = 0;
            this.hochLabel.Text = "hoch";
            this.hochLabel.UseVisualStyleBackColor = true;
            this.hochLabel.Click += new System.EventHandler(this.hochLabel_Click);
            // 
            // safeButton
            // 
            this.safeButton.Location = new System.Drawing.Point(12, 508);
            this.safeButton.Name = "safeButton";
            this.safeButton.Size = new System.Drawing.Size(100, 23);
            this.safeButton.TabIndex = 8;
            this.safeButton.Text = "Bild speichern";
            this.safeButton.UseVisualStyleBackColor = true;
            this.safeButton.Click += new System.EventHandler(this.safeButton_Click);
            // 
            // bildSpeichernDialog
            // 
            this.bildSpeichernDialog.Filter = "JPG|*.jpg";
            // 
            // helligkeitPanel
            // 
            this.helligkeitPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.helligkeitPanel.Controls.Add(this.trackBar1);
            this.helligkeitPanel.Controls.Add(this.helligkeitLabel);
            this.helligkeitPanel.Location = new System.Drawing.Point(790, 330);
            this.helligkeitPanel.Name = "helligkeitPanel";
            this.helligkeitPanel.Size = new System.Drawing.Size(129, 76);
            this.helligkeitPanel.TabIndex = 9;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(-2, 33);
            this.trackBar1.Minimum = -10;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(129, 45);
            this.trackBar1.TabIndex = 3;
            this.trackBar1.TabStop = false;
            this.trackBar1.TickFrequency = 5;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // helligkeitLabel
            // 
            this.helligkeitLabel.AutoSize = true;
            this.helligkeitLabel.BackColor = System.Drawing.Color.Transparent;
            this.helligkeitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helligkeitLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.helligkeitLabel.Location = new System.Drawing.Point(3, 9);
            this.helligkeitLabel.Name = "helligkeitLabel";
            this.helligkeitLabel.Size = new System.Drawing.Size(73, 20);
            this.helligkeitLabel.TabIndex = 2;
            this.helligkeitLabel.Text = "Helligkeit";
            // 
            // groesePanel
            // 
            this.groesePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.groesePanel.Controls.Add(this.verkleinernButton);
            this.groesePanel.Controls.Add(this.groeseLabel);
            this.groesePanel.Controls.Add(this.groeserButton);
            this.groesePanel.Location = new System.Drawing.Point(790, 416);
            this.groesePanel.Name = "groesePanel";
            this.groesePanel.Size = new System.Drawing.Size(129, 90);
            this.groesePanel.TabIndex = 8;
            // 
            // verkleinernButton
            // 
            this.verkleinernButton.AutoSize = true;
            this.verkleinernButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verkleinernButton.Location = new System.Drawing.Point(61, 42);
            this.verkleinernButton.Name = "verkleinernButton";
            this.verkleinernButton.Size = new System.Drawing.Size(55, 35);
            this.verkleinernButton.TabIndex = 3;
            this.verkleinernButton.Text = "-";
            this.verkleinernButton.UseVisualStyleBackColor = true;
            this.verkleinernButton.Click += new System.EventHandler(this.verkleinernButton_Click);
            // 
            // groeseLabel
            // 
            this.groeseLabel.AutoSize = true;
            this.groeseLabel.BackColor = System.Drawing.Color.Transparent;
            this.groeseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groeseLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.groeseLabel.Location = new System.Drawing.Point(3, 9);
            this.groeseLabel.Name = "groeseLabel";
            this.groeseLabel.Size = new System.Drawing.Size(55, 20);
            this.groeseLabel.TabIndex = 2;
            this.groeseLabel.Text = "Größe";
            // 
            // groeserButton
            // 
            this.groeserButton.AutoSize = true;
            this.groeserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groeserButton.Location = new System.Drawing.Point(3, 42);
            this.groeserButton.Name = "groeserButton";
            this.groeserButton.Size = new System.Drawing.Size(52, 35);
            this.groeserButton.TabIndex = 0;
            this.groeserButton.Text = "+";
            this.groeserButton.UseVisualStyleBackColor = true;
            this.groeserButton.Click += new System.EventHandler(this.groeserButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 543);
            this.Controls.Add(this.groesePanel);
            this.Controls.Add(this.helligkeitPanel);
            this.Controls.Add(this.safeButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.viewerOpenButton);
            this.Controls.Add(this.schrittePanel);
            this.Controls.Add(this.filterPanel);
            this.Controls.Add(this.panelPictureBox);
            this.Controls.Add(this.loadPictureButton);
            this.Controls.Add(this.openColorDialogButton);
            this.Name = "Form1";
            this.Text = "Hallo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelPictureBox.ResumeLayout(false);
            this.panelPictureBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.filterPanel.ResumeLayout(false);
            this.filterPanel.PerformLayout();
            this.schrittePanel.ResumeLayout(false);
            this.schrittePanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.helligkeitPanel.ResumeLayout(false);
            this.helligkeitPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groesePanel.ResumeLayout(false);
            this.groesePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button openColorDialogButton;
        private System.Windows.Forms.Button loadPictureButton;
        private System.Windows.Forms.OpenFileDialog bildÖffnenDialog;
        private System.Windows.Forms.Panel panelPictureBox;
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
        private System.Windows.Forms.Button viewerOpenButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button runterLabel;
        private System.Windows.Forms.Label contrastLabel;
        private System.Windows.Forms.Button hochLabel;
        private System.Windows.Forms.Button safeButton;
        private System.Windows.Forms.SaveFileDialog bildSpeichernDialog;
        private System.Windows.Forms.Panel helligkeitPanel;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label helligkeitLabel;
        private System.Windows.Forms.Panel groesePanel;
        private System.Windows.Forms.Button verkleinernButton;
        private System.Windows.Forms.Label groeseLabel;
        private System.Windows.Forms.Button groeserButton;
    }
}

