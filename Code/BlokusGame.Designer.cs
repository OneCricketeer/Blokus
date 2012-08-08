using System.Windows.Forms;
using Microsoft.VisualBasic.PowerPacks;
using System.Drawing;

namespace ConsoleApplications.Blokus
{
    partial class BlokusGame
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
            this.rotateCWButton = new System.Windows.Forms.Button();
            this.rotateCCWbutton = new System.Windows.Forms.Button();
            this.flipVbutton = new System.Windows.Forms.Button();
            this.flipHbutton = new System.Windows.Forms.Button();
            this.placeTileButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.matrx = new ConsoleApplications.Blokus.BoardControl();
            this.player2Control = new ConsoleApplications.Blokus.PlayerControl();
            this.player3Control = new ConsoleApplications.Blokus.PlayerControl();
            this.player4Control = new ConsoleApplications.Blokus.PlayerControl();
            this.pieceControl = new ConsoleApplications.Blokus.SelectedPieceControl();
            this.pieceSelectControl = new ConsoleApplications.Blokus.SelectionControl();
            this.currentPlayerControl = new ConsoleApplications.Blokus.PlayerControl();
            this.SuspendLayout();
            // 
            // rotateCWButton
            // 
            this.rotateCWButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rotateCWButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rotateCWButton.Location = new System.Drawing.Point(0, 578);
            this.rotateCWButton.Name = "rotateCWButton";
            this.rotateCWButton.Size = new System.Drawing.Size(141, 23);
            this.rotateCWButton.TabIndex = 5;
            this.rotateCWButton.Text = "RotateCW";
            this.rotateCWButton.UseVisualStyleBackColor = true;
            this.rotateCWButton.Click += new System.EventHandler(this.rotateCWButton_Click);
            // 
            // rotateCCWbutton
            // 
            this.rotateCCWbutton.Location = new System.Drawing.Point(0, 607);
            this.rotateCCWbutton.Name = "rotateCCWbutton";
            this.rotateCCWbutton.Size = new System.Drawing.Size(141, 23);
            this.rotateCCWbutton.TabIndex = 17;
            this.rotateCCWbutton.Text = "RotateCCW";
            this.rotateCCWbutton.UseVisualStyleBackColor = true;
            this.rotateCCWbutton.Click += new System.EventHandler(this.rotateCCWbutton_Click);
            // 
            // flipVbutton
            // 
            this.flipVbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flipVbutton.Location = new System.Drawing.Point(0, 636);
            this.flipVbutton.Name = "flipVbutton";
            this.flipVbutton.Size = new System.Drawing.Size(141, 23);
            this.flipVbutton.TabIndex = 6;
            this.flipVbutton.Text = "Flip Vertical";
            this.flipVbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.flipVbutton.UseVisualStyleBackColor = true;
            this.flipVbutton.Click += new System.EventHandler(this.flipVButton_Click);
            // 
            // flipHbutton
            // 
            this.flipHbutton.Location = new System.Drawing.Point(0, 665);
            this.flipHbutton.Name = "flipHbutton";
            this.flipHbutton.Size = new System.Drawing.Size(141, 23);
            this.flipHbutton.TabIndex = 18;
            this.flipHbutton.Text = "Flip Horizontal";
            this.flipHbutton.UseVisualStyleBackColor = true;
            this.flipHbutton.Click += new System.EventHandler(this.flipHbutton_Click);
            // 
            // placeTileButton
            // 
            this.placeTileButton.Location = new System.Drawing.Point(0, 422);
            this.placeTileButton.Name = "placeTileButton";
            this.placeTileButton.Size = new System.Drawing.Size(141, 23);
            this.placeTileButton.TabIndex = 19;
            this.placeTileButton.Text = "Next Turn Test";
            this.placeTileButton.UseVisualStyleBackColor = true;
            this.placeTileButton.Click += new System.EventHandler(this.nextTurnButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(196, 451);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "Cannot play";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // matrx
            // 
            this.matrx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.matrx.BackColor = System.Drawing.Color.LightGray;
            this.matrx.Location = new System.Drawing.Point(147, 45);
            this.matrx.Name = "matrx";
            this.matrx.Size = new System.Drawing.Size(400, 400);
            this.matrx.TabIndex = 26;
            this.matrx.MouseEnter += new System.EventHandler(this.matrx_MouseEnter);
            this.matrx.MouseLeave += new System.EventHandler(this.matrx_Leave);
            // 
            // player2Control
            // 
            this.player2Control.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.player2Control.Location = new System.Drawing.Point(553, 351);
            this.player2Control.Name = "player2Control";
            this.player2Control.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.player2Control.Size = new System.Drawing.Size(201, 94);
            this.player2Control.TabIndex = 23;
            // 
            // player3Control
            // 
            this.player3Control.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.player3Control.Location = new System.Drawing.Point(553, 12);
            this.player3Control.Name = "player3Control";
            this.player3Control.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.player3Control.Size = new System.Drawing.Size(201, 94);
            this.player3Control.TabIndex = 24;
            // 
            // player4Control
            // 
            this.player4Control.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.player4Control.Location = new System.Drawing.Point(12, 12);
            this.player4Control.Name = "player4Control";
            this.player4Control.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.player4Control.Size = new System.Drawing.Size(129, 94);
            this.player4Control.TabIndex = 25;
            // 
            // pieceControl
            // 
            this.pieceControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.pieceControl.Location = new System.Drawing.Point(147, 480);
            this.pieceControl.Name = "pieceControl";
            this.pieceControl.Size = new System.Drawing.Size(213, 208);
            this.pieceControl.TabIndex = 20;
            // 
            // pieceSelectControl
            // 
            this.pieceSelectControl.Location = new System.Drawing.Point(366, 451);
            this.pieceSelectControl.Name = "pieceSelectControl";
            this.pieceSelectControl.Size = new System.Drawing.Size(400, 248);
            this.pieceSelectControl.TabIndex = 21;
            // 
            // currentPlayerControl
            // 
            this.currentPlayerControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.currentPlayerControl.Location = new System.Drawing.Point(0, 451);
            this.currentPlayerControl.Name = "currentPlayerControl";
            this.currentPlayerControl.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.currentPlayerControl.Size = new System.Drawing.Size(141, 96);
            this.currentPlayerControl.TabIndex = 22;
            // 
            // BlokusGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 700);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.matrx);
            this.Controls.Add(this.player2Control);
            this.Controls.Add(this.player3Control);
            this.Controls.Add(this.player4Control);
            this.Controls.Add(this.pieceControl);
            this.Controls.Add(this.pieceSelectControl);
            this.Controls.Add(this.placeTileButton);
            this.Controls.Add(this.rotateCWButton);
            this.Controls.Add(this.rotateCCWbutton);
            this.Controls.Add(this.flipVbutton);
            this.Controls.Add(this.flipHbutton);
            this.Controls.Add(this.currentPlayerControl);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "BlokusGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blokus";
            this.Load += new System.EventHandler(this.Blokus_Load);
            this.ResumeLayout(false);

        }

        #endregion

        // Players
        private Player player1;
        private Player player2;
        private Player player3;
        private Player player4;
        // NameTags
        private PlayerControl currentPlayerControl;
        private PlayerControl player2Control;
        private PlayerControl player3Control;
        private PlayerControl player4Control;
        // Buttons
        private Button rotateCWButton;
        private Button rotateCCWbutton;
        private Button flipVbutton;
        private Button flipHbutton;
        private Button placeTileButton;
        // Controls
        public SelectedPieceControl pieceControl;
        private SelectionControl pieceSelectControl;
        private BoardControl matrx;
        private Button button1;

    }
}