namespace GummyBearsGame.Forms
{
    partial class GameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.gamePanel = new System.Windows.Forms.Panel();
            this.actionsPanel = new System.Windows.Forms.Panel();
            this.attackWithJuiceDownButton = new System.Windows.Forms.Button();
            this.attackWithJuiceLeftButton = new System.Windows.Forms.Button();
            this.attackWithJuiceRightButton = new System.Windows.Forms.Button();
            this.attackWithJuiceUpButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.moveDownButton = new System.Windows.Forms.Button();
            this.moveLeftButton = new System.Windows.Forms.Button();
            this.moveRightButton = new System.Windows.Forms.Button();
            this.moveUpButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.attackDownButton = new System.Windows.Forms.Button();
            this.attackLeftButton = new System.Windows.Forms.Button();
            this.attackRightButton = new System.Windows.Forms.Button();
            this.attackUpButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.improveWarriorButton = new System.Windows.Forms.Button();
            this.improveMagicButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.endTourButton = new System.Windows.Forms.Button();
            this.juiceLabel = new System.Windows.Forms.Label();
            this.goldLabel = new System.Windows.Forms.Label();
            this.surrendButton = new System.Windows.Forms.Button();
            this.sacrificeButton = new System.Windows.Forms.Button();
            this.actionsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gamePanel
            // 
            this.gamePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gamePanel.Location = new System.Drawing.Point(12, 12);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(785, 689);
            this.gamePanel.TabIndex = 0;
            this.gamePanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gamePanel_MouseClick);
            // 
            // actionsPanel
            // 
            this.actionsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.actionsPanel.Controls.Add(this.attackWithJuiceDownButton);
            this.actionsPanel.Controls.Add(this.attackWithJuiceLeftButton);
            this.actionsPanel.Controls.Add(this.attackWithJuiceRightButton);
            this.actionsPanel.Controls.Add(this.attackWithJuiceUpButton);
            this.actionsPanel.Controls.Add(this.label4);
            this.actionsPanel.Controls.Add(this.moveDownButton);
            this.actionsPanel.Controls.Add(this.moveLeftButton);
            this.actionsPanel.Controls.Add(this.moveRightButton);
            this.actionsPanel.Controls.Add(this.moveUpButton);
            this.actionsPanel.Controls.Add(this.label3);
            this.actionsPanel.Controls.Add(this.attackDownButton);
            this.actionsPanel.Controls.Add(this.attackLeftButton);
            this.actionsPanel.Controls.Add(this.attackRightButton);
            this.actionsPanel.Controls.Add(this.attackUpButton);
            this.actionsPanel.Controls.Add(this.label2);
            this.actionsPanel.Controls.Add(this.improveWarriorButton);
            this.actionsPanel.Controls.Add(this.improveMagicButton);
            this.actionsPanel.Controls.Add(this.label1);
            this.actionsPanel.Controls.Add(this.endTourButton);
            this.actionsPanel.Controls.Add(this.juiceLabel);
            this.actionsPanel.Controls.Add(this.goldLabel);
            this.actionsPanel.Controls.Add(this.surrendButton);
            this.actionsPanel.Controls.Add(this.sacrificeButton);
            this.actionsPanel.Location = new System.Drawing.Point(12, 707);
            this.actionsPanel.Name = "actionsPanel";
            this.actionsPanel.Size = new System.Drawing.Size(785, 62);
            this.actionsPanel.TabIndex = 1;
            // 
            // attackWithJuiceDownButton
            // 
            this.attackWithJuiceDownButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.attackWithJuiceDownButton.Location = new System.Drawing.Point(315, 42);
            this.attackWithJuiceDownButton.Name = "attackWithJuiceDownButton";
            this.attackWithJuiceDownButton.Size = new System.Drawing.Size(20, 20);
            this.attackWithJuiceDownButton.TabIndex = 27;
            this.attackWithJuiceDownButton.Text = "v";
            this.attackWithJuiceDownButton.UseVisualStyleBackColor = true;
            this.attackWithJuiceDownButton.Click += new System.EventHandler(this.attackWithJuiceDownButton_Click);
            // 
            // attackWithJuiceLeftButton
            // 
            this.attackWithJuiceLeftButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.attackWithJuiceLeftButton.Location = new System.Drawing.Point(268, 22);
            this.attackWithJuiceLeftButton.Name = "attackWithJuiceLeftButton";
            this.attackWithJuiceLeftButton.Size = new System.Drawing.Size(20, 20);
            this.attackWithJuiceLeftButton.TabIndex = 26;
            this.attackWithJuiceLeftButton.Text = "<";
            this.attackWithJuiceLeftButton.UseVisualStyleBackColor = true;
            this.attackWithJuiceLeftButton.Click += new System.EventHandler(this.attackWithJuiceLeftButton_Click);
            // 
            // attackWithJuiceRightButton
            // 
            this.attackWithJuiceRightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.attackWithJuiceRightButton.Location = new System.Drawing.Point(361, 22);
            this.attackWithJuiceRightButton.Name = "attackWithJuiceRightButton";
            this.attackWithJuiceRightButton.Size = new System.Drawing.Size(20, 20);
            this.attackWithJuiceRightButton.TabIndex = 25;
            this.attackWithJuiceRightButton.Text = ">";
            this.attackWithJuiceRightButton.UseVisualStyleBackColor = true;
            this.attackWithJuiceRightButton.Click += new System.EventHandler(this.attackWithJuiceRightButton_Click);
            // 
            // attackWithJuiceUpButton
            // 
            this.attackWithJuiceUpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.attackWithJuiceUpButton.Location = new System.Drawing.Point(315, 2);
            this.attackWithJuiceUpButton.Name = "attackWithJuiceUpButton";
            this.attackWithJuiceUpButton.Size = new System.Drawing.Size(20, 20);
            this.attackWithJuiceUpButton.TabIndex = 24;
            this.attackWithJuiceUpButton.Text = "^";
            this.attackWithJuiceUpButton.UseVisualStyleBackColor = true;
            this.attackWithJuiceUpButton.Click += new System.EventHandler(this.attackWithJuiceUpButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(288, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Atak z sokiem";
            // 
            // moveDownButton
            // 
            this.moveDownButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.moveDownButton.Location = new System.Drawing.Point(23, 42);
            this.moveDownButton.Name = "moveDownButton";
            this.moveDownButton.Size = new System.Drawing.Size(20, 20);
            this.moveDownButton.TabIndex = 22;
            this.moveDownButton.Text = "v";
            this.moveDownButton.UseVisualStyleBackColor = true;
            this.moveDownButton.Click += new System.EventHandler(this.moveDownButton_Click);
            // 
            // moveLeftButton
            // 
            this.moveLeftButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.moveLeftButton.Location = new System.Drawing.Point(0, 21);
            this.moveLeftButton.Name = "moveLeftButton";
            this.moveLeftButton.Size = new System.Drawing.Size(20, 20);
            this.moveLeftButton.TabIndex = 21;
            this.moveLeftButton.Text = "<";
            this.moveLeftButton.UseVisualStyleBackColor = true;
            this.moveLeftButton.Click += new System.EventHandler(this.moveLeftButton_Click);
            // 
            // moveRightButton
            // 
            this.moveRightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.moveRightButton.Location = new System.Drawing.Point(48, 21);
            this.moveRightButton.Name = "moveRightButton";
            this.moveRightButton.Size = new System.Drawing.Size(20, 20);
            this.moveRightButton.TabIndex = 20;
            this.moveRightButton.Text = ">";
            this.moveRightButton.UseVisualStyleBackColor = true;
            this.moveRightButton.Click += new System.EventHandler(this.moveRightButton_Click);
            // 
            // moveUpButton
            // 
            this.moveUpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.moveUpButton.Location = new System.Drawing.Point(23, 1);
            this.moveUpButton.Name = "moveUpButton";
            this.moveUpButton.Size = new System.Drawing.Size(20, 20);
            this.moveUpButton.TabIndex = 19;
            this.moveUpButton.Text = "^";
            this.moveUpButton.UseVisualStyleBackColor = true;
            this.moveUpButton.Click += new System.EventHandler(this.moveUpButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Ruch";
            // 
            // attackDownButton
            // 
            this.attackDownButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.attackDownButton.Location = new System.Drawing.Point(91, 42);
            this.attackDownButton.Name = "attackDownButton";
            this.attackDownButton.Size = new System.Drawing.Size(20, 20);
            this.attackDownButton.TabIndex = 17;
            this.attackDownButton.Text = "v";
            this.attackDownButton.UseVisualStyleBackColor = true;
            this.attackDownButton.Click += new System.EventHandler(this.attackDownButton_Click);
            // 
            // attackLeftButton
            // 
            this.attackLeftButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.attackLeftButton.Location = new System.Drawing.Point(68, 21);
            this.attackLeftButton.Name = "attackLeftButton";
            this.attackLeftButton.Size = new System.Drawing.Size(20, 20);
            this.attackLeftButton.TabIndex = 16;
            this.attackLeftButton.Text = "<";
            this.attackLeftButton.UseVisualStyleBackColor = true;
            this.attackLeftButton.Click += new System.EventHandler(this.attackLeftButton_Click);
            // 
            // attackRightButton
            // 
            this.attackRightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.attackRightButton.Location = new System.Drawing.Point(116, 21);
            this.attackRightButton.Name = "attackRightButton";
            this.attackRightButton.Size = new System.Drawing.Size(20, 20);
            this.attackRightButton.TabIndex = 15;
            this.attackRightButton.Text = ">";
            this.attackRightButton.UseVisualStyleBackColor = true;
            this.attackRightButton.Click += new System.EventHandler(this.attackRightButton_Click);
            // 
            // attackUpButton
            // 
            this.attackUpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.attackUpButton.Location = new System.Drawing.Point(91, 1);
            this.attackUpButton.Name = "attackUpButton";
            this.attackUpButton.Size = new System.Drawing.Size(20, 20);
            this.attackUpButton.TabIndex = 14;
            this.attackUpButton.Text = "^";
            this.attackUpButton.UseVisualStyleBackColor = true;
            this.attackUpButton.Click += new System.EventHandler(this.attackUpButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Atak";
            // 
            // improveWarriorButton
            // 
            this.improveWarriorButton.Location = new System.Drawing.Point(136, 39);
            this.improveWarriorButton.Name = "improveWarriorButton";
            this.improveWarriorButton.Size = new System.Drawing.Size(61, 23);
            this.improveWarriorButton.TabIndex = 12;
            this.improveWarriorButton.Text = "Warrior";
            this.improveWarriorButton.UseVisualStyleBackColor = true;
            this.improveWarriorButton.Click += new System.EventHandler(this.improveWarriorButton_Click);
            // 
            // improveMagicButton
            // 
            this.improveMagicButton.Location = new System.Drawing.Point(136, 0);
            this.improveMagicButton.Name = "improveMagicButton";
            this.improveMagicButton.Size = new System.Drawing.Size(61, 23);
            this.improveMagicButton.TabIndex = 11;
            this.improveMagicButton.Text = "Magic";
            this.improveMagicButton.UseVisualStyleBackColor = true;
            this.improveMagicButton.Click += new System.EventHandler(this.improveMagicButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ulepsz";
            // 
            // endTourButton
            // 
            this.endTourButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.endTourButton.Location = new System.Drawing.Point(383, 0);
            this.endTourButton.Name = "endTourButton";
            this.endTourButton.Size = new System.Drawing.Size(62, 62);
            this.endTourButton.TabIndex = 9;
            this.endTourButton.Text = "Zakończ rundę";
            this.endTourButton.UseVisualStyleBackColor = true;
            this.endTourButton.Click += new System.EventHandler(this.endTourButton_Click);
            // 
            // juiceLabel
            // 
            this.juiceLabel.AutoSize = true;
            this.juiceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.juiceLabel.Location = new System.Drawing.Point(451, 35);
            this.juiceLabel.Name = "juiceLabel";
            this.juiceLabel.Size = new System.Drawing.Size(123, 18);
            this.juiceLabel.TabIndex = 7;
            this.juiceLabel.Text = "Sok z gumijagód:";
            // 
            // goldLabel
            // 
            this.goldLabel.AutoSize = true;
            this.goldLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.goldLabel.Location = new System.Drawing.Point(451, 11);
            this.goldLabel.Name = "goldLabel";
            this.goldLabel.Size = new System.Drawing.Size(50, 18);
            this.goldLabel.TabIndex = 6;
            this.goldLabel.Text = "Złoto: ";
            // 
            // surrendButton
            // 
            this.surrendButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.surrendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.surrendButton.Location = new System.Drawing.Point(723, 0);
            this.surrendButton.Name = "surrendButton";
            this.surrendButton.Size = new System.Drawing.Size(62, 62);
            this.surrendButton.TabIndex = 4;
            this.surrendButton.Text = "Poddaj";
            this.surrendButton.UseVisualStyleBackColor = true;
            this.surrendButton.Click += new System.EventHandler(this.surrendButton_Click);
            // 
            // sacrificeButton
            // 
            this.sacrificeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sacrificeButton.Location = new System.Drawing.Point(204, 0);
            this.sacrificeButton.Name = "sacrificeButton";
            this.sacrificeButton.Size = new System.Drawing.Size(62, 62);
            this.sacrificeButton.TabIndex = 3;
            this.sacrificeButton.Text = "Złóż w ofierze Bogu soku";
            this.sacrificeButton.UseVisualStyleBackColor = true;
            this.sacrificeButton.Click += new System.EventHandler(this.sacrificeButton_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 781);
            this.Controls.Add(this.actionsPanel);
            this.Controls.Add(this.gamePanel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gumisie Wars";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameForm_Paint);
            this.Resize += new System.EventHandler(this.GameForm_Resize);
            this.actionsPanel.ResumeLayout(false);
            this.actionsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel gamePanel;
        private System.Windows.Forms.Panel actionsPanel;
        private System.Windows.Forms.Button surrendButton;
        private System.Windows.Forms.Button sacrificeButton;
        private System.Windows.Forms.Label juiceLabel;
        private System.Windows.Forms.Label goldLabel;
        private System.Windows.Forms.Button endTourButton;
        private System.Windows.Forms.Button improveWarriorButton;
        private System.Windows.Forms.Button improveMagicButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button moveDownButton;
        private System.Windows.Forms.Button moveLeftButton;
        private System.Windows.Forms.Button moveRightButton;
        private System.Windows.Forms.Button moveUpButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button attackDownButton;
        private System.Windows.Forms.Button attackLeftButton;
        private System.Windows.Forms.Button attackRightButton;
        private System.Windows.Forms.Button attackUpButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button attackWithJuiceDownButton;
        private System.Windows.Forms.Button attackWithJuiceLeftButton;
        private System.Windows.Forms.Button attackWithJuiceRightButton;
        private System.Windows.Forms.Button attackWithJuiceUpButton;
        private System.Windows.Forms.Label label4;
    }
}