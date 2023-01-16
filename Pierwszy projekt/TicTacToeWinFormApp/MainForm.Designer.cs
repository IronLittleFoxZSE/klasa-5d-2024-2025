
namespace TicTacToeWinFormApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelConfigGame = new System.Windows.Forms.Panel();
            this.labelWhoStartGame = new System.Windows.Forms.Label();
            this.comboBoxWhoStartGame = new System.Windows.Forms.ComboBox();
            this.buttonNewGame = new System.Windows.Forms.Button();
            this.tableLayoutPanelBoard = new System.Windows.Forms.TableLayoutPanel();
            this.buttonPosition00 = new System.Windows.Forms.Button();
            this.buttonPosition10 = new System.Windows.Forms.Button();
            this.buttonPosition20 = new System.Windows.Forms.Button();
            this.buttonPosition01 = new System.Windows.Forms.Button();
            this.buttonPosition11 = new System.Windows.Forms.Button();
            this.buttonPosition21 = new System.Windows.Forms.Button();
            this.buttonPosition22 = new System.Windows.Forms.Button();
            this.buttonPosition12 = new System.Windows.Forms.Button();
            this.buttonPosition02 = new System.Windows.Forms.Button();
            this.panelConfigGame.SuspendLayout();
            this.tableLayoutPanelBoard.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelConfigGame
            // 
            this.panelConfigGame.Controls.Add(this.labelWhoStartGame);
            this.panelConfigGame.Controls.Add(this.comboBoxWhoStartGame);
            this.panelConfigGame.Controls.Add(this.buttonNewGame);
            this.panelConfigGame.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelConfigGame.Location = new System.Drawing.Point(0, 0);
            this.panelConfigGame.Name = "panelConfigGame";
            this.panelConfigGame.Size = new System.Drawing.Size(335, 75);
            this.panelConfigGame.TabIndex = 4;
            // 
            // labelWhoStartGame
            // 
            this.labelWhoStartGame.AutoSize = true;
            this.labelWhoStartGame.Location = new System.Drawing.Point(12, 9);
            this.labelWhoStartGame.Name = "labelWhoStartGame";
            this.labelWhoStartGame.Size = new System.Drawing.Size(92, 15);
            this.labelWhoStartGame.TabIndex = 3;
            this.labelWhoStartGame.Text = "Kto zaczyna grę:";
            // 
            // comboBoxWhoStartGame
            // 
            this.comboBoxWhoStartGame.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxWhoStartGame.FormattingEnabled = true;
            this.comboBoxWhoStartGame.Items.AddRange(new object[] {
            "Kółko",
            "Krzyżyk"});
            this.comboBoxWhoStartGame.Location = new System.Drawing.Point(12, 30);
            this.comboBoxWhoStartGame.Name = "comboBoxWhoStartGame";
            this.comboBoxWhoStartGame.Size = new System.Drawing.Size(121, 23);
            this.comboBoxWhoStartGame.TabIndex = 2;
            // 
            // buttonNewGame
            // 
            this.buttonNewGame.Location = new System.Drawing.Point(161, 29);
            this.buttonNewGame.Name = "buttonNewGame";
            this.buttonNewGame.Size = new System.Drawing.Size(123, 23);
            this.buttonNewGame.TabIndex = 0;
            this.buttonNewGame.Text = "Nowa gra";
            this.buttonNewGame.UseVisualStyleBackColor = true;
            this.buttonNewGame.Click += new System.EventHandler(this.buttonNewGame_Click);
            // 
            // tableLayoutPanelBoard
            // 
            this.tableLayoutPanelBoard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tableLayoutPanelBoard.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanelBoard.ColumnCount = 3;
            this.tableLayoutPanelBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanelBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanelBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanelBoard.Controls.Add(this.buttonPosition00, 0, 0);
            this.tableLayoutPanelBoard.Controls.Add(this.buttonPosition10, 1, 0);
            this.tableLayoutPanelBoard.Controls.Add(this.buttonPosition20, 2, 0);
            this.tableLayoutPanelBoard.Controls.Add(this.buttonPosition01, 0, 1);
            this.tableLayoutPanelBoard.Controls.Add(this.buttonPosition11, 1, 1);
            this.tableLayoutPanelBoard.Controls.Add(this.buttonPosition21, 2, 1);
            this.tableLayoutPanelBoard.Controls.Add(this.buttonPosition22, 2, 2);
            this.tableLayoutPanelBoard.Controls.Add(this.buttonPosition12, 1, 2);
            this.tableLayoutPanelBoard.Controls.Add(this.buttonPosition02, 0, 2);
            this.tableLayoutPanelBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelBoard.Location = new System.Drawing.Point(0, 75);
            this.tableLayoutPanelBoard.Name = "tableLayoutPanelBoard";
            this.tableLayoutPanelBoard.RowCount = 3;
            this.tableLayoutPanelBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanelBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanelBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanelBoard.Size = new System.Drawing.Size(335, 260);
            this.tableLayoutPanelBoard.TabIndex = 5;
            this.tableLayoutPanelBoard.Visible = false;
            // 
            // buttonPosition00
            // 
            this.buttonPosition00.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonPosition00.Location = new System.Drawing.Point(13, 13);
            this.buttonPosition00.Margin = new System.Windows.Forms.Padding(10);
            this.buttonPosition00.Name = "buttonPosition00";
            this.buttonPosition00.Size = new System.Drawing.Size(86, 61);
            this.buttonPosition00.TabIndex = 0;
            this.buttonPosition00.UseVisualStyleBackColor = true;
            this.buttonPosition00.Click += new System.EventHandler(this.buttonPosition_Click);
            // 
            // buttonPosition10
            // 
            this.buttonPosition10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonPosition10.Location = new System.Drawing.Point(122, 13);
            this.buttonPosition10.Margin = new System.Windows.Forms.Padding(10);
            this.buttonPosition10.Name = "buttonPosition10";
            this.buttonPosition10.Size = new System.Drawing.Size(86, 61);
            this.buttonPosition10.TabIndex = 1;
            this.buttonPosition10.UseVisualStyleBackColor = true;
            this.buttonPosition10.Click += new System.EventHandler(this.buttonPosition_Click);
            // 
            // buttonPosition20
            // 
            this.buttonPosition20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonPosition20.Location = new System.Drawing.Point(231, 13);
            this.buttonPosition20.Margin = new System.Windows.Forms.Padding(10);
            this.buttonPosition20.Name = "buttonPosition20";
            this.buttonPosition20.Size = new System.Drawing.Size(91, 61);
            this.buttonPosition20.TabIndex = 2;
            this.buttonPosition20.UseVisualStyleBackColor = true;
            this.buttonPosition20.Click += new System.EventHandler(this.buttonPosition_Click);
            // 
            // buttonPosition01
            // 
            this.buttonPosition01.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonPosition01.Location = new System.Drawing.Point(13, 97);
            this.buttonPosition01.Margin = new System.Windows.Forms.Padding(10);
            this.buttonPosition01.Name = "buttonPosition01";
            this.buttonPosition01.Size = new System.Drawing.Size(86, 61);
            this.buttonPosition01.TabIndex = 3;
            this.buttonPosition01.UseVisualStyleBackColor = true;
            this.buttonPosition01.Click += new System.EventHandler(this.buttonPosition_Click);
            // 
            // buttonPosition11
            // 
            this.buttonPosition11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonPosition11.Location = new System.Drawing.Point(122, 97);
            this.buttonPosition11.Margin = new System.Windows.Forms.Padding(10);
            this.buttonPosition11.Name = "buttonPosition11";
            this.buttonPosition11.Size = new System.Drawing.Size(86, 61);
            this.buttonPosition11.TabIndex = 4;
            this.buttonPosition11.UseVisualStyleBackColor = true;
            this.buttonPosition11.Click += new System.EventHandler(this.buttonPosition_Click);
            // 
            // buttonPosition21
            // 
            this.buttonPosition21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonPosition21.Location = new System.Drawing.Point(231, 97);
            this.buttonPosition21.Margin = new System.Windows.Forms.Padding(10);
            this.buttonPosition21.Name = "buttonPosition21";
            this.buttonPosition21.Size = new System.Drawing.Size(91, 61);
            this.buttonPosition21.TabIndex = 5;
            this.buttonPosition21.UseVisualStyleBackColor = true;
            this.buttonPosition21.Click += new System.EventHandler(this.buttonPosition_Click);
            // 
            // buttonPosition22
            // 
            this.buttonPosition22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonPosition22.Location = new System.Drawing.Point(231, 181);
            this.buttonPosition22.Margin = new System.Windows.Forms.Padding(10);
            this.buttonPosition22.Name = "buttonPosition22";
            this.buttonPosition22.Size = new System.Drawing.Size(91, 66);
            this.buttonPosition22.TabIndex = 6;
            this.buttonPosition22.UseVisualStyleBackColor = true;
            this.buttonPosition22.Click += new System.EventHandler(this.buttonPosition_Click);
            // 
            // buttonPosition12
            // 
            this.buttonPosition12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonPosition12.Location = new System.Drawing.Point(122, 181);
            this.buttonPosition12.Margin = new System.Windows.Forms.Padding(10);
            this.buttonPosition12.Name = "buttonPosition12";
            this.buttonPosition12.Size = new System.Drawing.Size(86, 66);
            this.buttonPosition12.TabIndex = 7;
            this.buttonPosition12.UseVisualStyleBackColor = true;
            this.buttonPosition12.Click += new System.EventHandler(this.buttonPosition_Click);
            // 
            // buttonPosition02
            // 
            this.buttonPosition02.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonPosition02.Location = new System.Drawing.Point(13, 181);
            this.buttonPosition02.Margin = new System.Windows.Forms.Padding(10);
            this.buttonPosition02.Name = "buttonPosition02";
            this.buttonPosition02.Size = new System.Drawing.Size(86, 66);
            this.buttonPosition02.TabIndex = 8;
            this.buttonPosition02.UseVisualStyleBackColor = true;
            this.buttonPosition02.Click += new System.EventHandler(this.buttonPosition_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 335);
            this.Controls.Add(this.tableLayoutPanelBoard);
            this.Controls.Add(this.panelConfigGame);
            this.MinimumSize = new System.Drawing.Size(351, 374);
            this.Name = "MainForm";
            this.Text = "Gra \"Kółko i krzyżyk\"";
            this.panelConfigGame.ResumeLayout(false);
            this.panelConfigGame.PerformLayout();
            this.tableLayoutPanelBoard.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelConfigGame;
        private System.Windows.Forms.Label labelWhoStartGame;
        private System.Windows.Forms.ComboBox comboBoxWhoStartGame;
        private System.Windows.Forms.Button buttonNewGame;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBoard;
        private System.Windows.Forms.Button buttonPosition00;
        private System.Windows.Forms.Button buttonPosition10;
        private System.Windows.Forms.Button buttonPosition20;
        private System.Windows.Forms.Button buttonPosition01;
        private System.Windows.Forms.Button buttonPosition11;
        private System.Windows.Forms.Button buttonPosition21;
        private System.Windows.Forms.Button buttonPosition22;
        private System.Windows.Forms.Button buttonPosition12;
        private System.Windows.Forms.Button buttonPosition02;
    }
}

