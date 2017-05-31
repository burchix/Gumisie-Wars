namespace GummyBearsMapEditor
{
    partial class CreateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateForm));
            this.gamePanel = new System.Windows.Forms.Panel();
            this.createMapButton = new System.Windows.Forms.Button();
            this.gummyMultLabel = new System.Windows.Forms.Label();
            this.juiceLabel = new System.Windows.Forms.Label();
            this.goldLabel = new System.Windows.Forms.Label();
            this.ownerLabel = new System.Windows.Forms.Label();
            this.ownerComboBox = new System.Windows.Forms.ComboBox();
            this.gummyTypeLabel = new System.Windows.Forms.Label();
            this.gummyNrLabel = new System.Windows.Forms.Label();
            this.gummyTypeComboBox = new System.Windows.Forms.ComboBox();
            this.defenceLabel = new System.Windows.Forms.Label();
            this.defenceUpDown = new System.Windows.Forms.NumericUpDown();
            this.goldUpDown = new System.Windows.Forms.NumericUpDown();
            this.gummyNrUpDown = new System.Windows.Forms.NumericUpDown();
            this.gummyMultUpDown = new System.Windows.Forms.NumericUpDown();
            this.juiceUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.defenceUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goldUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gummyNrUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gummyMultUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.juiceUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // gamePanel
            // 
            this.gamePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gamePanel.Location = new System.Drawing.Point(12, 12);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(652, 517);
            this.gamePanel.TabIndex = 1;
            this.gamePanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gamePanel_MouseClick);
            // 
            // createMapButton
            // 
            this.createMapButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.createMapButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.createMapButton.Location = new System.Drawing.Point(797, 502);
            this.createMapButton.Name = "createMapButton";
            this.createMapButton.Size = new System.Drawing.Size(121, 27);
            this.createMapButton.TabIndex = 11;
            this.createMapButton.Text = "Utwórz mapę";
            this.createMapButton.UseVisualStyleBackColor = true;
            this.createMapButton.Click += new System.EventHandler(this.createMapButton_Click);
            // 
            // gummyMultLabel
            // 
            this.gummyMultLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gummyMultLabel.AutoSize = true;
            this.gummyMultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gummyMultLabel.Location = new System.Drawing.Point(670, 132);
            this.gummyMultLabel.Name = "gummyMultLabel";
            this.gummyMultLabel.Size = new System.Drawing.Size(121, 16);
            this.gummyMultLabel.TabIndex = 12;
            this.gummyMultLabel.Text = "Przyrost jednostek:";
            // 
            // juiceLabel
            // 
            this.juiceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.juiceLabel.AutoSize = true;
            this.juiceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.juiceLabel.Location = new System.Drawing.Point(670, 102);
            this.juiceLabel.Name = "juiceLabel";
            this.juiceLabel.Size = new System.Drawing.Size(91, 16);
            this.juiceLabel.TabIndex = 13;
            this.juiceLabel.Text = "Przyrost soku:";
            // 
            // goldLabel
            // 
            this.goldLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.goldLabel.AutoSize = true;
            this.goldLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.goldLabel.Location = new System.Drawing.Point(670, 72);
            this.goldLabel.Name = "goldLabel";
            this.goldLabel.Size = new System.Drawing.Size(93, 16);
            this.goldLabel.TabIndex = 14;
            this.goldLabel.Text = "Przyrost złota:";
            // 
            // ownerLabel
            // 
            this.ownerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ownerLabel.AutoSize = true;
            this.ownerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ownerLabel.Location = new System.Drawing.Point(670, 12);
            this.ownerLabel.Name = "ownerLabel";
            this.ownerLabel.Size = new System.Drawing.Size(76, 16);
            this.ownerLabel.TabIndex = 15;
            this.ownerLabel.Text = "Właściciel:";
            // 
            // ownerComboBox
            // 
            this.ownerComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ownerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ownerComboBox.FormattingEnabled = true;
            this.ownerComboBox.Location = new System.Drawing.Point(798, 12);
            this.ownerComboBox.Name = "ownerComboBox";
            this.ownerComboBox.Size = new System.Drawing.Size(121, 21);
            this.ownerComboBox.TabIndex = 22;
            this.ownerComboBox.SelectedIndexChanged += new System.EventHandler(this.ownerComboBox_SelectedIndexChanged);
            // 
            // gummyTypeLabel
            // 
            this.gummyTypeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gummyTypeLabel.AutoSize = true;
            this.gummyTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gummyTypeLabel.Location = new System.Drawing.Point(670, 192);
            this.gummyTypeLabel.Name = "gummyTypeLabel";
            this.gummyTypeLabel.Size = new System.Drawing.Size(116, 16);
            this.gummyTypeLabel.TabIndex = 23;
            this.gummyTypeLabel.Text = "Rodzaj jednostek:";
            // 
            // gummyNrLabel
            // 
            this.gummyNrLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gummyNrLabel.AutoSize = true;
            this.gummyNrLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gummyNrLabel.Location = new System.Drawing.Point(670, 162);
            this.gummyNrLabel.Name = "gummyNrLabel";
            this.gummyNrLabel.Size = new System.Drawing.Size(101, 16);
            this.gummyNrLabel.TabIndex = 24;
            this.gummyNrLabel.Text = "Ilość jednostek:";
            // 
            // gummyTypeComboBox
            // 
            this.gummyTypeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gummyTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gummyTypeComboBox.Enabled = false;
            this.gummyTypeComboBox.FormattingEnabled = true;
            this.gummyTypeComboBox.Location = new System.Drawing.Point(798, 192);
            this.gummyTypeComboBox.Name = "gummyTypeComboBox";
            this.gummyTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.gummyTypeComboBox.TabIndex = 25;
            this.gummyTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.gummyTypeComboBox_SelectedIndexChanged);
            // 
            // defenceLabel
            // 
            this.defenceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.defenceLabel.AutoSize = true;
            this.defenceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.defenceLabel.Location = new System.Drawing.Point(670, 42);
            this.defenceLabel.Name = "defenceLabel";
            this.defenceLabel.Size = new System.Drawing.Size(101, 16);
            this.defenceLabel.TabIndex = 26;
            this.defenceLabel.Text = "Obrona (boost):";
            // 
            // defenceUpDown
            // 
            this.defenceUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.defenceUpDown.DecimalPlaces = 2;
            this.defenceUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.defenceUpDown.Location = new System.Drawing.Point(798, 42);
            this.defenceUpDown.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.defenceUpDown.Name = "defenceUpDown";
            this.defenceUpDown.Size = new System.Drawing.Size(121, 20);
            this.defenceUpDown.TabIndex = 29;
            this.defenceUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.defenceUpDown.ValueChanged += new System.EventHandler(this.defenceUpDown_ValueChanged);
            // 
            // goldUpDown
            // 
            this.goldUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.goldUpDown.DecimalPlaces = 2;
            this.goldUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.goldUpDown.Location = new System.Drawing.Point(798, 72);
            this.goldUpDown.Name = "goldUpDown";
            this.goldUpDown.Size = new System.Drawing.Size(121, 20);
            this.goldUpDown.TabIndex = 30;
            this.goldUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.goldUpDown.ValueChanged += new System.EventHandler(this.goldUpDown_ValueChanged);
            // 
            // gummyNrUpDown
            // 
            this.gummyNrUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gummyNrUpDown.Location = new System.Drawing.Point(798, 162);
            this.gummyNrUpDown.Name = "gummyNrUpDown";
            this.gummyNrUpDown.Size = new System.Drawing.Size(121, 20);
            this.gummyNrUpDown.TabIndex = 31;
            this.gummyNrUpDown.ValueChanged += new System.EventHandler(this.gummyNrUpDown_ValueChanged);
            // 
            // gummyMultUpDown
            // 
            this.gummyMultUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gummyMultUpDown.Location = new System.Drawing.Point(798, 132);
            this.gummyMultUpDown.Name = "gummyMultUpDown";
            this.gummyMultUpDown.Size = new System.Drawing.Size(121, 20);
            this.gummyMultUpDown.TabIndex = 32;
            this.gummyMultUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.gummyMultUpDown.ValueChanged += new System.EventHandler(this.gummyMultUpDown_ValueChanged);
            // 
            // juiceUpDown
            // 
            this.juiceUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.juiceUpDown.DecimalPlaces = 2;
            this.juiceUpDown.Location = new System.Drawing.Point(798, 102);
            this.juiceUpDown.Name = "juiceUpDown";
            this.juiceUpDown.Size = new System.Drawing.Size(121, 20);
            this.juiceUpDown.TabIndex = 33;
            this.juiceUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.juiceUpDown.ValueChanged += new System.EventHandler(this.juiceUpDown_ValueChanged);
            // 
            // CreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(931, 543);
            this.Controls.Add(this.juiceUpDown);
            this.Controls.Add(this.gummyMultUpDown);
            this.Controls.Add(this.gummyNrUpDown);
            this.Controls.Add(this.goldUpDown);
            this.Controls.Add(this.defenceUpDown);
            this.Controls.Add(this.defenceLabel);
            this.Controls.Add(this.gummyTypeComboBox);
            this.Controls.Add(this.gummyNrLabel);
            this.Controls.Add(this.gummyTypeLabel);
            this.Controls.Add(this.ownerComboBox);
            this.Controls.Add(this.ownerLabel);
            this.Controls.Add(this.goldLabel);
            this.Controls.Add(this.juiceLabel);
            this.Controls.Add(this.gummyMultLabel);
            this.Controls.Add(this.createMapButton);
            this.Controls.Add(this.gamePanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gumisie Wars Map Editor";
            this.Load += new System.EventHandler(this.CreateForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.CreateForm_Paint);
            this.Resize += new System.EventHandler(this.CreateForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.defenceUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goldUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gummyNrUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gummyMultUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.juiceUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel gamePanel;
        private System.Windows.Forms.Button createMapButton;
        private System.Windows.Forms.Label gummyMultLabel;
        private System.Windows.Forms.Label juiceLabel;
        private System.Windows.Forms.Label goldLabel;
        private System.Windows.Forms.Label ownerLabel;
        private System.Windows.Forms.ComboBox ownerComboBox;
        private System.Windows.Forms.Label gummyTypeLabel;
        private System.Windows.Forms.Label gummyNrLabel;
        private System.Windows.Forms.ComboBox gummyTypeComboBox;
        private System.Windows.Forms.Label defenceLabel;
        private System.Windows.Forms.NumericUpDown defenceUpDown;
        private System.Windows.Forms.NumericUpDown goldUpDown;
        private System.Windows.Forms.NumericUpDown gummyNrUpDown;
        private System.Windows.Forms.NumericUpDown gummyMultUpDown;
        private System.Windows.Forms.NumericUpDown juiceUpDown;
    }
}