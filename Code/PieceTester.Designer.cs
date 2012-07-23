namespace ConsoleApplications.Blokus
{
    partial class PieceTester
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
            this.showButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.piece = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.label2 = new System.Windows.Forms.Label();
            this.player1button = new System.Windows.Forms.Button();
            this.player2button = new System.Windows.Forms.Button();
            this.player3button = new System.Windows.Forms.Button();
            this.player4button = new System.Windows.Forms.Button();
            this.rotCWbutton = new System.Windows.Forms.Button();
            this.rotCCWbutton = new System.Windows.Forms.Button();
            this.flipVbutton = new System.Windows.Forms.Button();
            this.flipHbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(230, 281);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(63, 23);
            this.showButton.TabIndex = 1;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21"});
            this.comboBox1.Location = new System.Drawing.Point(142, 283);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(82, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.showButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select the piece to show";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.piece});
            this.shapeContainer1.Size = new System.Drawing.Size(330, 390);
            this.shapeContainer1.TabIndex = 4;
            this.shapeContainer1.TabStop = false;
            // 
            // piece
            // 
            this.piece.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.piece.Location = new System.Drawing.Point(42, 14);
            this.piece.Name = "piece";
            this.piece.Size = new System.Drawing.Size(250, 250);
            this.piece.Visible = false;
            this.piece.Click += new System.EventHandler(this.rectangleShape1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Choose a player";
            // 
            // player1button
            // 
            this.player1button.Location = new System.Drawing.Point(106, 314);
            this.player1button.Name = "player1button";
            this.player1button.Size = new System.Drawing.Size(40, 23);
            this.player1button.TabIndex = 6;
            this.player1button.Text = "1";
            this.player1button.UseVisualStyleBackColor = true;
            this.player1button.Click += new System.EventHandler(this.playerbutton_Click);
            // 
            // player2button
            // 
            this.player2button.Location = new System.Drawing.Point(152, 314);
            this.player2button.Name = "player2button";
            this.player2button.Size = new System.Drawing.Size(40, 23);
            this.player2button.TabIndex = 7;
            this.player2button.Text = "2";
            this.player2button.UseVisualStyleBackColor = true;
            this.player2button.Click += new System.EventHandler(this.playerbutton_Click);
            // 
            // player3button
            // 
            this.player3button.Location = new System.Drawing.Point(198, 314);
            this.player3button.Name = "player3button";
            this.player3button.Size = new System.Drawing.Size(40, 23);
            this.player3button.TabIndex = 8;
            this.player3button.Text = "3";
            this.player3button.UseVisualStyleBackColor = true;
            this.player3button.Click += new System.EventHandler(this.playerbutton_Click);
            // 
            // player4button
            // 
            this.player4button.Location = new System.Drawing.Point(244, 314);
            this.player4button.Name = "player4button";
            this.player4button.Size = new System.Drawing.Size(40, 23);
            this.player4button.TabIndex = 9;
            this.player4button.Text = "4";
            this.player4button.UseVisualStyleBackColor = true;
            this.player4button.Click += new System.EventHandler(this.playerbutton_Click);
            // 
            // rotCWbutton
            // 
            this.rotCWbutton.Location = new System.Drawing.Point(3, 354);
            this.rotCWbutton.Name = "rotCWbutton";
            this.rotCWbutton.Size = new System.Drawing.Size(68, 23);
            this.rotCWbutton.TabIndex = 10;
            this.rotCWbutton.Text = "Rotate CW";
            this.rotCWbutton.UseVisualStyleBackColor = true;
            this.rotCWbutton.Click += new System.EventHandler(this.rotCWbutton_Click);
            // 
            // rotCCWbutton
            // 
            this.rotCCWbutton.Location = new System.Drawing.Point(77, 354);
            this.rotCCWbutton.Name = "rotCCWbutton";
            this.rotCCWbutton.Size = new System.Drawing.Size(76, 23);
            this.rotCCWbutton.TabIndex = 11;
            this.rotCCWbutton.Text = "Rotate CCW";
            this.rotCCWbutton.UseVisualStyleBackColor = true;
            this.rotCCWbutton.Click += new System.EventHandler(this.rotCCWbutton_Click);
            // 
            // flipVbutton
            // 
            this.flipVbutton.Location = new System.Drawing.Point(158, 354);
            this.flipVbutton.Name = "flipVbutton";
            this.flipVbutton.Size = new System.Drawing.Size(75, 23);
            this.flipVbutton.TabIndex = 12;
            this.flipVbutton.Text = "Flip Vertical";
            this.flipVbutton.UseVisualStyleBackColor = true;
            this.flipVbutton.Click += new System.EventHandler(this.flipVbutton_Click);
            // 
            // flipHbutton
            // 
            this.flipHbutton.Location = new System.Drawing.Point(239, 354);
            this.flipHbutton.Name = "flipHbutton";
            this.flipHbutton.Size = new System.Drawing.Size(87, 23);
            this.flipHbutton.TabIndex = 13;
            this.flipHbutton.Text = "Flip Horizontal";
            this.flipHbutton.UseVisualStyleBackColor = true;
            this.flipHbutton.Click += new System.EventHandler(this.flipHbutton_Click);
            // 
            // PieceTester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(330, 390);
            this.Controls.Add(this.flipHbutton);
            this.Controls.Add(this.flipVbutton);
            this.Controls.Add(this.rotCCWbutton);
            this.Controls.Add(this.rotCWbutton);
            this.Controls.Add(this.player4button);
            this.Controls.Add(this.player3button);
            this.Controls.Add(this.player2button);
            this.Controls.Add(this.player1button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "PieceTester";
            this.Text = "Blokus Piece Test";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape piece;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button player1button;
        private System.Windows.Forms.Button player2button;
        private System.Windows.Forms.Button player3button;
        private System.Windows.Forms.Button player4button;
        private System.Windows.Forms.Button rotCWbutton;
        private System.Windows.Forms.Button rotCCWbutton;
        private System.Windows.Forms.Button flipVbutton;
        private System.Windows.Forms.Button flipHbutton;
    }
}