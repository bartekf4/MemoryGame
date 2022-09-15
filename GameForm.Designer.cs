namespace MemoryGame
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
            this.components = new System.ComponentModel.Container();
            this.main_tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.cards_tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.time_label = new System.Windows.Forms.Label();
            this.btnSett = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.score_label = new System.Windows.Forms.Label();
            this.pause_button = new System.Windows.Forms.Button();
            this.init_visibility_timer = new System.Windows.Forms.Timer(this.components);
            this.bad_guess_timer = new System.Windows.Forms.Timer(this.components);
            this.good_guess_timer = new System.Windows.Forms.Timer(this.components);
            this.time_timer = new System.Windows.Forms.Timer(this.components);
            this.main_tableLayoutPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_tableLayoutPanel
            // 
            this.main_tableLayoutPanel.ColumnCount = 1;
            this.main_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.main_tableLayoutPanel.Controls.Add(this.cards_tableLayoutPanel, 0, 1);
            this.main_tableLayoutPanel.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.main_tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.main_tableLayoutPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.main_tableLayoutPanel.Name = "main_tableLayoutPanel";
            this.main_tableLayoutPanel.RowCount = 2;
            this.main_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.main_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.main_tableLayoutPanel.Size = new System.Drawing.Size(600, 366);
            this.main_tableLayoutPanel.TabIndex = 0;
            // 
            // cards_tableLayoutPanel
            // 
            this.cards_tableLayoutPanel.ColumnCount = 1;
            this.cards_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.cards_tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cards_tableLayoutPanel.Location = new System.Drawing.Point(2, 43);
            this.cards_tableLayoutPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cards_tableLayoutPanel.Name = "cards_tableLayoutPanel";
            this.cards_tableLayoutPanel.RowCount = 1;
            this.cards_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.cards_tableLayoutPanel.Size = new System.Drawing.Size(596, 321);
            this.cards_tableLayoutPanel.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.18447F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.81554F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.time_label, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSett, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.score_label, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.pause_button, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(596, 37);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(472, 4);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Score";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // time_label
            // 
            this.time_label.AutoSize = true;
            this.time_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.time_label.Location = new System.Drawing.Point(397, 4);
            this.time_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.time_label.Name = "time_label";
            this.time_label.Size = new System.Drawing.Size(71, 29);
            this.time_label.TabIndex = 4;
            this.time_label.Text = "time";
            this.time_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSett
            // 
            this.btnSett.Location = new System.Drawing.Point(6, 6);
            this.btnSett.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSett.Name = "btnSett";
            this.btnSett.Size = new System.Drawing.Size(84, 23);
            this.btnSett.TabIndex = 1;
            this.btnSett.Text = "Settings";
            this.btnSett.UseVisualStyleBackColor = true;
            this.btnSett.Click += new System.EventHandler(this.btnSett_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label1.Location = new System.Drawing.Point(332, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Time";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // score_label
            // 
            this.score_label.AutoSize = true;
            this.score_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.score_label.Location = new System.Drawing.Point(543, 4);
            this.score_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.score_label.Name = "score_label";
            this.score_label.Size = new System.Drawing.Size(47, 29);
            this.score_label.TabIndex = 5;
            this.score_label.Text = "score";
            this.score_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pause_button
            // 
            this.pause_button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pause_button.Location = new System.Drawing.Point(94, 6);
            this.pause_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pause_button.Name = "pause_button";
            this.pause_button.Size = new System.Drawing.Size(234, 25);
            this.pause_button.TabIndex = 7;
            this.pause_button.Text = "Pause";
            this.pause_button.UseVisualStyleBackColor = true;
            this.pause_button.Click += new System.EventHandler(this.pause_button_Click);
            // 
            // init_visibility_timer
            // 
            this.init_visibility_timer.Tick += new System.EventHandler(this.init_visibility_timer_Tick);
            // 
            // bad_guess_timer
            // 
            this.bad_guess_timer.Tick += new System.EventHandler(this.bad_guess_timer_Tick);
            // 
            // good_guess_timer
            // 
            this.good_guess_timer.Tick += new System.EventHandler(this.good_guess_timer_Tick);
            // 
            // time_timer
            // 
            this.time_timer.Tick += new System.EventHandler(this.time_timer_Tick);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.main_tableLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "GameForm";
            this.Text = "Memory Game";
            this.Shown += new System.EventHandler(this.GameForm_Shown);
            this.main_tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel main_tableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel cards_tableLayoutPanel;
        private System.Windows.Forms.Timer init_visibility_timer;
        private System.Windows.Forms.Timer bad_guess_timer;
        private System.Windows.Forms.Timer good_guess_timer;
        private System.Windows.Forms.Button btnSett;
        private System.Windows.Forms.Timer time_timer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label time_label;
        private System.Windows.Forms.Label score_label;
        private System.Windows.Forms.Button pause_button;
    }
}