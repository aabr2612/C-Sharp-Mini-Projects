﻿namespace Contact_App
{
    partial class MainForm
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
            this.Header = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.Label();
            this.BottomContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.Inputs = new System.Windows.Forms.TableLayoutPanel();
            this.ContactMngBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ExitBtn = new Guna.UI2.WinForms.Guna2Button();
            this.TopContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.MainPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.BottomContainer.SuspendLayout();
            this.Inputs.SuspendLayout();
            this.TopContainer.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Header.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
            this.Header.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(634, 150);
            this.Header.TabIndex = 2;
            this.Header.Text = "Contact Management";
            this.Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Logo
            // 
            this.Logo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Logo.Font = new System.Drawing.Font("Sitka Heading", 72F, System.Drawing.FontStyle.Bold);
            this.Logo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(144)))), ((int)(((byte)(231)))));
            this.Logo.Location = new System.Drawing.Point(0, 0);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(634, 150);
            this.Logo.TabIndex = 1;
            this.Logo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BottomContainer
            // 
            this.BottomContainer.Controls.Add(this.Inputs);
            this.BottomContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BottomContainer.Location = new System.Drawing.Point(0, 150);
            this.BottomContainer.Name = "BottomContainer";
            this.BottomContainer.Size = new System.Drawing.Size(634, 311);
            this.BottomContainer.TabIndex = 1;
            // 
            // Inputs
            // 
            this.Inputs.BackColor = System.Drawing.SystemColors.Control;
            this.Inputs.ColumnCount = 5;
            this.Inputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.56357F));
            this.Inputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.56357F));
            this.Inputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.74572F));
            this.Inputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.56357F));
            this.Inputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.56357F));
            this.Inputs.Controls.Add(this.ContactMngBtn, 2, 1);
            this.Inputs.Controls.Add(this.ExitBtn, 2, 3);
            this.Inputs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Inputs.ForeColor = System.Drawing.Color.Black;
            this.Inputs.Location = new System.Drawing.Point(0, 0);
            this.Inputs.Name = "Inputs";
            this.Inputs.RowCount = 5;
            this.Inputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.72155F));
            this.Inputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.13431F));
            this.Inputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.38998F));
            this.Inputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.13431F));
            this.Inputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.61984F));
            this.Inputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Inputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Inputs.Size = new System.Drawing.Size(634, 311);
            this.Inputs.TabIndex = 0;
            // 
            // ContactMngBtn
            // 
            this.ContactMngBtn.BorderRadius = 20;
            this.ContactMngBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ContactMngBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ContactMngBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ContactMngBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ContactMngBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContactMngBtn.FillColor = System.Drawing.Color.DimGray;
            this.ContactMngBtn.FocusedColor = System.Drawing.Color.Black;
            this.ContactMngBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactMngBtn.ForeColor = System.Drawing.Color.White;
            this.ContactMngBtn.HoverState.BorderColor = System.Drawing.Color.Orange;
            this.ContactMngBtn.HoverState.FillColor = System.Drawing.Color.Blue;
            this.ContactMngBtn.Location = new System.Drawing.Point(237, 70);
            this.ContactMngBtn.Name = "ContactMngBtn";
            this.ContactMngBtn.Size = new System.Drawing.Size(157, 59);
            this.ContactMngBtn.TabIndex = 0;
            this.ContactMngBtn.Text = "Manage Contacts";
            this.ContactMngBtn.Click += new System.EventHandler(this.ContactMngBtn_Click_1);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BorderRadius = 20;
            this.ExitBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ExitBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ExitBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ExitBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ExitBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExitBtn.FillColor = System.Drawing.Color.DimGray;
            this.ExitBtn.FocusedColor = System.Drawing.Color.Black;
            this.ExitBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.ForeColor = System.Drawing.Color.White;
            this.ExitBtn.HoverState.BorderColor = System.Drawing.Color.Orange;
            this.ExitBtn.HoverState.FillColor = System.Drawing.Color.Blue;
            this.ExitBtn.Location = new System.Drawing.Point(237, 167);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(157, 59);
            this.ExitBtn.TabIndex = 2;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // TopContainer
            // 
            this.TopContainer.BackColor = System.Drawing.Color.Transparent;
            this.TopContainer.Controls.Add(this.Header);
            this.TopContainer.Controls.Add(this.Logo);
            this.TopContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopContainer.Location = new System.Drawing.Point(0, 0);
            this.TopContainer.Name = "TopContainer";
            this.TopContainer.Size = new System.Drawing.Size(634, 150);
            this.TopContainer.TabIndex = 0;
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.BottomContainer);
            this.MainPanel.Controls.Add(this.TopContainer);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.FillColor = System.Drawing.Color.MidnightBlue;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(634, 461);
            this.MainPanel.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 461);
            this.Controls.Add(this.MainPanel);
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.BottomContainer.ResumeLayout(false);
            this.Inputs.ResumeLayout(false);
            this.TopContainer.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Header;
        private System.Windows.Forms.Label Logo;
        private Guna.UI2.WinForms.Guna2Panel BottomContainer;
        private System.Windows.Forms.TableLayoutPanel Inputs;
        private Guna.UI2.WinForms.Guna2Button ContactMngBtn;
        private Guna.UI2.WinForms.Guna2Button ExitBtn;
        private Guna.UI2.WinForms.Guna2Panel TopContainer;
        private Guna.UI2.WinForms.Guna2Panel MainPanel;
    }
}

