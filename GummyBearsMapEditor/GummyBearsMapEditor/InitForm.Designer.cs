namespace GummyBearsMapEditor
{
    partial class InitForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InitForm));
            this.nameLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nextStepButton = new System.Windows.Forms.Button();
            this.iconPictureBox = new System.Windows.Forms.PictureBox();
            this.changeImageTimer = new System.Windows.Forms.Timer(this.components);
            this.moneyLabel = new System.Windows.Forms.Label();
            this.juiceLabel = new System.Windows.Forms.Label();
            this.moneyAILabel = new System.Windows.Forms.Label();
            this.juiceAILAbel = new System.Windows.Forms.Label();
            this.juiceAIUpDown = new System.Windows.Forms.NumericUpDown();
            this.moneyAIUpDown = new System.Windows.Forms.NumericUpDown();
            this.juiceUpDown = new System.Windows.Forms.NumericUpDown();
            this.moneyUpDown = new System.Windows.Forms.NumericUpDown();
            this.heightUpDown = new System.Windows.Forms.NumericUpDown();
            this.widthUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.juiceAIUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneyAIUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.juiceUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneyUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameLabel.Location = new System.Drawing.Point(181, 15);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(52, 16);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Nazwa:";
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.widthLabel.Location = new System.Drawing.Point(181, 45);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(112, 16);
            this.widthLabel.TabIndex = 2;
            this.widthLabel.Text = "Szerokość mapy:";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.heightLabel.Location = new System.Drawing.Point(181, 75);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(112, 16);
            this.heightLabel.TabIndex = 4;
            this.heightLabel.Text = "Wysokość mapy:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameTextBox.Location = new System.Drawing.Point(300, 15);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(122, 22);
            this.nameTextBox.TabIndex = 7;
            // 
            // nextStepButton
            // 
            this.nextStepButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nextStepButton.Location = new System.Drawing.Point(300, 232);
            this.nextStepButton.Name = "nextStepButton";
            this.nextStepButton.Size = new System.Drawing.Size(122, 27);
            this.nextStepButton.TabIndex = 10;
            this.nextStepButton.Text = "Przejdź dalej";
            this.nextStepButton.UseVisualStyleBackColor = true;
            this.nextStepButton.Click += new System.EventHandler(this.nextStepButton_Click);
            // 
            // iconPictureBox
            // 
            this.iconPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("iconPictureBox.Image")));
            this.iconPictureBox.Location = new System.Drawing.Point(12, 12);
            this.iconPictureBox.Name = "iconPictureBox";
            this.iconPictureBox.Size = new System.Drawing.Size(160, 249);
            this.iconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPictureBox.TabIndex = 11;
            this.iconPictureBox.TabStop = false;
            // 
            // changeImageTimer
            // 
            this.changeImageTimer.Interval = 4000;
            this.changeImageTimer.Tick += new System.EventHandler(this.changeImageTimer_Tick);
            // 
            // moneyLabel
            // 
            this.moneyLabel.AutoSize = true;
            this.moneyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.moneyLabel.Location = new System.Drawing.Point(181, 105);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(71, 16);
            this.moneyLabel.TabIndex = 12;
            this.moneyLabel.Text = "Pieniądze:";
            // 
            // juiceLabel
            // 
            this.juiceLabel.AutoSize = true;
            this.juiceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.juiceLabel.Location = new System.Drawing.Point(181, 135);
            this.juiceLabel.Name = "juiceLabel";
            this.juiceLabel.Size = new System.Drawing.Size(58, 16);
            this.juiceLabel.TabIndex = 13;
            this.juiceLabel.Text = "Sok [%]:";
            // 
            // moneyAILabel
            // 
            this.moneyAILabel.AutoSize = true;
            this.moneyAILabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.moneyAILabel.Location = new System.Drawing.Point(181, 165);
            this.moneyAILabel.Name = "moneyAILabel";
            this.moneyAILabel.Size = new System.Drawing.Size(86, 16);
            this.moneyAILabel.TabIndex = 14;
            this.moneyAILabel.Text = "Pieniądze AI:";
            // 
            // juiceAILAbel
            // 
            this.juiceAILAbel.AutoSize = true;
            this.juiceAILAbel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.juiceAILAbel.Location = new System.Drawing.Point(181, 195);
            this.juiceAILAbel.Name = "juiceAILAbel";
            this.juiceAILAbel.Size = new System.Drawing.Size(73, 16);
            this.juiceAILAbel.TabIndex = 15;
            this.juiceAILAbel.Text = "Sok AI [%]:";
            // 
            // juiceAIUpDown
            // 
            this.juiceAIUpDown.DecimalPlaces = 2;
            this.juiceAIUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.juiceAIUpDown.Location = new System.Drawing.Point(300, 195);
            this.juiceAIUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.juiceAIUpDown.Name = "juiceAIUpDown";
            this.juiceAIUpDown.Size = new System.Drawing.Size(121, 20);
            this.juiceAIUpDown.TabIndex = 30;
            // 
            // moneyAIUpDown
            // 
            this.moneyAIUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.moneyAIUpDown.Location = new System.Drawing.Point(300, 165);
            this.moneyAIUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.moneyAIUpDown.Name = "moneyAIUpDown";
            this.moneyAIUpDown.Size = new System.Drawing.Size(121, 20);
            this.moneyAIUpDown.TabIndex = 31;
            // 
            // juiceUpDown
            // 
            this.juiceUpDown.DecimalPlaces = 2;
            this.juiceUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.juiceUpDown.Location = new System.Drawing.Point(300, 135);
            this.juiceUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.juiceUpDown.Name = "juiceUpDown";
            this.juiceUpDown.Size = new System.Drawing.Size(121, 20);
            this.juiceUpDown.TabIndex = 32;
            // 
            // moneyUpDown
            // 
            this.moneyUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.moneyUpDown.Location = new System.Drawing.Point(300, 105);
            this.moneyUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.moneyUpDown.Name = "moneyUpDown";
            this.moneyUpDown.Size = new System.Drawing.Size(121, 20);
            this.moneyUpDown.TabIndex = 33;
            // 
            // heightUpDown
            // 
            this.heightUpDown.Location = new System.Drawing.Point(300, 75);
            this.heightUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.heightUpDown.Name = "heightUpDown";
            this.heightUpDown.Size = new System.Drawing.Size(121, 20);
            this.heightUpDown.TabIndex = 34;
            this.heightUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // widthUpDown
            // 
            this.widthUpDown.Location = new System.Drawing.Point(300, 45);
            this.widthUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.widthUpDown.Name = "widthUpDown";
            this.widthUpDown.Size = new System.Drawing.Size(122, 20);
            this.widthUpDown.TabIndex = 35;
            this.widthUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // InitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 271);
            this.Controls.Add(this.widthUpDown);
            this.Controls.Add(this.heightUpDown);
            this.Controls.Add(this.moneyUpDown);
            this.Controls.Add(this.juiceUpDown);
            this.Controls.Add(this.moneyAIUpDown);
            this.Controls.Add(this.juiceAIUpDown);
            this.Controls.Add(this.juiceAILAbel);
            this.Controls.Add(this.moneyAILabel);
            this.Controls.Add(this.juiceLabel);
            this.Controls.Add(this.moneyLabel);
            this.Controls.Add(this.iconPictureBox);
            this.Controls.Add(this.nextStepButton);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.nameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "InitForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gumisie Wars Map Editor";
            this.Load += new System.EventHandler(this.InitForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.juiceAIUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneyAIUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.juiceUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneyUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button nextStepButton;
        private System.Windows.Forms.PictureBox iconPictureBox;
        private System.Windows.Forms.Timer changeImageTimer;
        private System.Windows.Forms.Label moneyLabel;
        private System.Windows.Forms.Label juiceLabel;
        private System.Windows.Forms.Label moneyAILabel;
        private System.Windows.Forms.Label juiceAILAbel;
        private System.Windows.Forms.NumericUpDown juiceAIUpDown;
        private System.Windows.Forms.NumericUpDown moneyAIUpDown;
        private System.Windows.Forms.NumericUpDown juiceUpDown;
        private System.Windows.Forms.NumericUpDown moneyUpDown;
        private System.Windows.Forms.NumericUpDown heightUpDown;
        private System.Windows.Forms.NumericUpDown widthUpDown;
    }
}