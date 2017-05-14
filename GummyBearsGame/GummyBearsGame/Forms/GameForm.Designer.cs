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
            this.giveJuiceButton = new System.Windows.Forms.Button();
            this.juiceLabel = new System.Windows.Forms.Label();
            this.goldLabel = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.sacrificeButton = new System.Windows.Forms.Button();
            this.improveButton = new System.Windows.Forms.Button();
            this.attackButton = new System.Windows.Forms.Button();
            this.moveButton = new System.Windows.Forms.Button();
            this.endTourButton = new System.Windows.Forms.Button();
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
            this.actionsPanel.Controls.Add(this.endTourButton);
            this.actionsPanel.Controls.Add(this.giveJuiceButton);
            this.actionsPanel.Controls.Add(this.juiceLabel);
            this.actionsPanel.Controls.Add(this.goldLabel);
            this.actionsPanel.Controls.Add(this.button5);
            this.actionsPanel.Controls.Add(this.sacrificeButton);
            this.actionsPanel.Controls.Add(this.improveButton);
            this.actionsPanel.Controls.Add(this.attackButton);
            this.actionsPanel.Controls.Add(this.moveButton);
            this.actionsPanel.Location = new System.Drawing.Point(12, 707);
            this.actionsPanel.Name = "actionsPanel";
            this.actionsPanel.Size = new System.Drawing.Size(785, 62);
            this.actionsPanel.TabIndex = 1;
            // 
            // giveJuiceButton
            // 
            this.giveJuiceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.giveJuiceButton.Location = new System.Drawing.Point(272, 0);
            this.giveJuiceButton.Name = "giveJuiceButton";
            this.giveJuiceButton.Size = new System.Drawing.Size(62, 62);
            this.giveJuiceButton.TabIndex = 8;
            this.giveJuiceButton.Text = "Napój sokiem";
            this.giveJuiceButton.UseVisualStyleBackColor = true;
            // 
            // juiceLabel
            // 
            this.juiceLabel.AutoSize = true;
            this.juiceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.juiceLabel.Location = new System.Drawing.Point(420, 35);
            this.juiceLabel.Name = "juiceLabel";
            this.juiceLabel.Size = new System.Drawing.Size(123, 18);
            this.juiceLabel.TabIndex = 7;
            this.juiceLabel.Text = "Sok z gumijagód:";
            // 
            // goldLabel
            // 
            this.goldLabel.AutoSize = true;
            this.goldLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.goldLabel.Location = new System.Drawing.Point(420, 11);
            this.goldLabel.Name = "goldLabel";
            this.goldLabel.Size = new System.Drawing.Size(50, 18);
            this.goldLabel.TabIndex = 6;
            this.goldLabel.Text = "Złoto: ";
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button5.Location = new System.Drawing.Point(723, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(62, 62);
            this.button5.TabIndex = 4;
            this.button5.Text = "Poddaj";
            this.button5.UseVisualStyleBackColor = true;
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
            // 
            // improveButton
            // 
            this.improveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.improveButton.Location = new System.Drawing.Point(136, 0);
            this.improveButton.Name = "improveButton";
            this.improveButton.Size = new System.Drawing.Size(62, 62);
            this.improveButton.TabIndex = 2;
            this.improveButton.Text = "Ulepsz";
            this.improveButton.UseVisualStyleBackColor = true;
            // 
            // attackButton
            // 
            this.attackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.attackButton.Location = new System.Drawing.Point(68, 0);
            this.attackButton.Name = "attackButton";
            this.attackButton.Size = new System.Drawing.Size(62, 62);
            this.attackButton.TabIndex = 1;
            this.attackButton.Text = "Atak";
            this.attackButton.UseVisualStyleBackColor = true;
            // 
            // moveButton
            // 
            this.moveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.moveButton.Location = new System.Drawing.Point(0, 0);
            this.moveButton.Name = "moveButton";
            this.moveButton.Size = new System.Drawing.Size(62, 62);
            this.moveButton.TabIndex = 0;
            this.moveButton.Text = "Ruch";
            this.moveButton.UseVisualStyleBackColor = true;
            // 
            // endTourButton
            // 
            this.endTourButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.endTourButton.Location = new System.Drawing.Point(340, 0);
            this.endTourButton.Name = "endTourButton";
            this.endTourButton.Size = new System.Drawing.Size(62, 62);
            this.endTourButton.TabIndex = 9;
            this.endTourButton.Text = "Zakończ rundę";
            this.endTourButton.UseVisualStyleBackColor = true;
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
        private System.Windows.Forms.Button moveButton;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button sacrificeButton;
        private System.Windows.Forms.Button improveButton;
        private System.Windows.Forms.Button attackButton;
        private System.Windows.Forms.Label juiceLabel;
        private System.Windows.Forms.Label goldLabel;
        private System.Windows.Forms.Button giveJuiceButton;
        private System.Windows.Forms.Button endTourButton;
    }
}