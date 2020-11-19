namespace ProxyParser
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.OutputBox = new System.Windows.Forms.TextBox();
            this.SaveProxy = new System.Windows.Forms.Button();
            this.Output_label = new System.Windows.Forms.Label();
            this.Parse_button = new System.Windows.Forms.Button();
            this.ProxyCountry_label = new System.Windows.Forms.Label();
            this.CountriesList = new System.Windows.Forms.CheckedListBox();
            this.PortsBox = new System.Windows.Forms.TextBox();
            this.Ports_label = new System.Windows.Forms.Label();
            this.AnonymouseTypesList = new System.Windows.Forms.CheckedListBox();
            this.Anonymity_Label = new System.Windows.Forms.Label();
            this.MaxPing_label = new System.Windows.Forms.Label();
            this.MaxPingBox = new System.Windows.Forms.TextBox();
            this.Page_label = new System.Windows.Forms.Label();
            this.PageBox = new System.Windows.Forms.TextBox();
            this.UseOutputBox = new System.Windows.Forms.CheckBox();
            this.ProxyType_label = new System.Windows.Forms.Label();
            this.ProxyTypeList = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // OutputBox
            // 
            this.OutputBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.OutputBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OutputBox.ForeColor = System.Drawing.Color.Lime;
            this.OutputBox.Location = new System.Drawing.Point(13, 27);
            this.OutputBox.Multiline = true;
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.Size = new System.Drawing.Size(233, 274);
            this.OutputBox.TabIndex = 0;
            this.OutputBox.TextChanged += new System.EventHandler(this.OutputBox_TextChanged);
            // 
            // SaveProxy
            // 
            this.SaveProxy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveProxy.ForeColor = System.Drawing.Color.Lime;
            this.SaveProxy.Location = new System.Drawing.Point(13, 306);
            this.SaveProxy.Name = "SaveProxy";
            this.SaveProxy.Size = new System.Drawing.Size(75, 23);
            this.SaveProxy.TabIndex = 1;
            this.SaveProxy.Text = "Save";
            this.SaveProxy.UseVisualStyleBackColor = true;
            this.SaveProxy.Click += new System.EventHandler(this.SaveProxy_Click);
            // 
            // Output_label
            // 
            this.Output_label.AutoSize = true;
            this.Output_label.ForeColor = System.Drawing.Color.Lime;
            this.Output_label.Location = new System.Drawing.Point(10, 9);
            this.Output_label.Name = "Output_label";
            this.Output_label.Size = new System.Drawing.Size(42, 13);
            this.Output_label.TabIndex = 2;
            this.Output_label.Text = "Output:";
            // 
            // Parse_button
            // 
            this.Parse_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Parse_button.ForeColor = System.Drawing.Color.Lime;
            this.Parse_button.Location = new System.Drawing.Point(171, 306);
            this.Parse_button.Name = "Parse_button";
            this.Parse_button.Size = new System.Drawing.Size(75, 23);
            this.Parse_button.TabIndex = 3;
            this.Parse_button.Text = "Parse";
            this.Parse_button.UseVisualStyleBackColor = true;
            this.Parse_button.Click += new System.EventHandler(this.Parse_button_Click);
            // 
            // ProxyCountry_label
            // 
            this.ProxyCountry_label.AutoSize = true;
            this.ProxyCountry_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProxyCountry_label.ForeColor = System.Drawing.Color.Lime;
            this.ProxyCountry_label.Location = new System.Drawing.Point(267, 11);
            this.ProxyCountry_label.Name = "ProxyCountry_label";
            this.ProxyCountry_label.Size = new System.Drawing.Size(75, 13);
            this.ProxyCountry_label.TabIndex = 4;
            this.ProxyCountry_label.Tag = "";
            this.ProxyCountry_label.Text = "Proxy Country:";
            this.ProxyCountry_label.Click += new System.EventHandler(this.ProxyCountry_label_Click);
            // 
            // CountriesList
            // 
            this.CountriesList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.CountriesList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CountriesList.CheckOnClick = true;
            this.CountriesList.ForeColor = System.Drawing.Color.Lime;
            this.CountriesList.FormattingEnabled = true;
            this.CountriesList.Location = new System.Drawing.Point(270, 27);
            this.CountriesList.MultiColumn = true;
            this.CountriesList.Name = "CountriesList";
            this.CountriesList.Size = new System.Drawing.Size(345, 135);
            this.CountriesList.TabIndex = 6;
            this.CountriesList.ThreeDCheckBoxes = true;
            this.CountriesList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CountriesList_ItemCheck);
            // 
            // PortsBox
            // 
            this.PortsBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.PortsBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PortsBox.ForeColor = System.Drawing.Color.Lime;
            this.PortsBox.Location = new System.Drawing.Point(270, 185);
            this.PortsBox.Name = "PortsBox";
            this.PortsBox.Size = new System.Drawing.Size(72, 13);
            this.PortsBox.TabIndex = 8;
            this.PortsBox.Text = "80-90";
            this.PortsBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PortsBox_KeyPress);
            // 
            // Ports_label
            // 
            this.Ports_label.AutoSize = true;
            this.Ports_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Ports_label.ForeColor = System.Drawing.Color.Lime;
            this.Ports_label.Location = new System.Drawing.Point(267, 169);
            this.Ports_label.Name = "Ports_label";
            this.Ports_label.Size = new System.Drawing.Size(34, 13);
            this.Ports_label.TabIndex = 9;
            this.Ports_label.Text = "Ports:";
            this.Ports_label.Click += new System.EventHandler(this.Ports_label_Click);
            // 
            // AnonymouseTypesList
            // 
            this.AnonymouseTypesList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.AnonymouseTypesList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AnonymouseTypesList.CheckOnClick = true;
            this.AnonymouseTypesList.ForeColor = System.Drawing.Color.Lime;
            this.AnonymouseTypesList.FormattingEnabled = true;
            this.AnonymouseTypesList.Location = new System.Drawing.Point(371, 185);
            this.AnonymouseTypesList.Name = "AnonymouseTypesList";
            this.AnonymouseTypesList.Size = new System.Drawing.Size(86, 75);
            this.AnonymouseTypesList.TabIndex = 10;
            this.AnonymouseTypesList.ThreeDCheckBoxes = true;
            // 
            // Anonymity_Label
            // 
            this.Anonymity_Label.AutoSize = true;
            this.Anonymity_Label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Anonymity_Label.ForeColor = System.Drawing.Color.Lime;
            this.Anonymity_Label.Location = new System.Drawing.Point(368, 169);
            this.Anonymity_Label.Name = "Anonymity_Label";
            this.Anonymity_Label.Size = new System.Drawing.Size(58, 13);
            this.Anonymity_Label.TabIndex = 11;
            this.Anonymity_Label.Text = "Anonymity:";
            this.Anonymity_Label.Click += new System.EventHandler(this.Anonymity_Label_Click);
            // 
            // MaxPing_label
            // 
            this.MaxPing_label.AutoSize = true;
            this.MaxPing_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MaxPing_label.ForeColor = System.Drawing.Color.Lime;
            this.MaxPing_label.Location = new System.Drawing.Point(267, 203);
            this.MaxPing_label.Name = "MaxPing_label";
            this.MaxPing_label.Size = new System.Drawing.Size(72, 13);
            this.MaxPing_label.TabIndex = 13;
            this.MaxPing_label.Text = "Maximal Ping:";
            this.MaxPing_label.Click += new System.EventHandler(this.MaxPing_label_Click);
            // 
            // MaxPingBox
            // 
            this.MaxPingBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.MaxPingBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MaxPingBox.ForeColor = System.Drawing.Color.Lime;
            this.MaxPingBox.Location = new System.Drawing.Point(270, 219);
            this.MaxPingBox.Name = "MaxPingBox";
            this.MaxPingBox.Size = new System.Drawing.Size(72, 13);
            this.MaxPingBox.TabIndex = 12;
            this.MaxPingBox.Text = "200";
            this.MaxPingBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MaxPingBox_KeyPress);
            // 
            // Page_label
            // 
            this.Page_label.AutoSize = true;
            this.Page_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Page_label.ForeColor = System.Drawing.Color.Lime;
            this.Page_label.Location = new System.Drawing.Point(267, 235);
            this.Page_label.Name = "Page_label";
            this.Page_label.Size = new System.Drawing.Size(35, 13);
            this.Page_label.TabIndex = 15;
            this.Page_label.Text = "Page:";
            this.Page_label.Click += new System.EventHandler(this.Page_label_Click);
            // 
            // PageBox
            // 
            this.PageBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.PageBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PageBox.ForeColor = System.Drawing.Color.Lime;
            this.PageBox.Location = new System.Drawing.Point(270, 251);
            this.PageBox.Name = "PageBox";
            this.PageBox.Size = new System.Drawing.Size(72, 13);
            this.PageBox.TabIndex = 14;
            this.PageBox.Text = "0-5";
            this.PageBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PageBox_KeyPress);
            // 
            // UseOutputBox
            // 
            this.UseOutputBox.AccessibleDescription = "";
            this.UseOutputBox.AutoSize = true;
            this.UseOutputBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.UseOutputBox.Checked = true;
            this.UseOutputBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.UseOutputBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UseOutputBox.ForeColor = System.Drawing.Color.Lime;
            this.UseOutputBox.Location = new System.Drawing.Point(252, 284);
            this.UseOutputBox.Name = "UseOutputBox";
            this.UseOutputBox.Size = new System.Drawing.Size(78, 17);
            this.UseOutputBox.TabIndex = 16;
            this.UseOutputBox.Text = "Use Output";
            this.UseOutputBox.UseVisualStyleBackColor = false;
            // 
            // ProxyType_label
            // 
            this.ProxyType_label.AutoSize = true;
            this.ProxyType_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProxyType_label.ForeColor = System.Drawing.Color.Lime;
            this.ProxyType_label.Location = new System.Drawing.Point(472, 169);
            this.ProxyType_label.Name = "ProxyType_label";
            this.ProxyType_label.Size = new System.Drawing.Size(63, 13);
            this.ProxyType_label.TabIndex = 18;
            this.ProxyType_label.Text = "Proxy Type:";
            this.ProxyType_label.Click += new System.EventHandler(this.ProxyType_label_Click);
            // 
            // ProxyTypeList
            // 
            this.ProxyTypeList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ProxyTypeList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProxyTypeList.CheckOnClick = true;
            this.ProxyTypeList.ForeColor = System.Drawing.Color.Lime;
            this.ProxyTypeList.FormattingEnabled = true;
            this.ProxyTypeList.Location = new System.Drawing.Point(475, 185);
            this.ProxyTypeList.Name = "ProxyTypeList";
            this.ProxyTypeList.Size = new System.Drawing.Size(86, 75);
            this.ProxyTypeList.TabIndex = 17;
            this.ProxyTypeList.ThreeDCheckBoxes = true;
            // 
            // Main
            // 
            this.AccessibleDescription = "";
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(20)))), ((int)(((byte)(19)))));
            this.ClientSize = new System.Drawing.Size(627, 341);
            this.Controls.Add(this.ProxyType_label);
            this.Controls.Add(this.ProxyTypeList);
            this.Controls.Add(this.UseOutputBox);
            this.Controls.Add(this.Page_label);
            this.Controls.Add(this.PageBox);
            this.Controls.Add(this.MaxPing_label);
            this.Controls.Add(this.MaxPingBox);
            this.Controls.Add(this.Anonymity_Label);
            this.Controls.Add(this.AnonymouseTypesList);
            this.Controls.Add(this.Ports_label);
            this.Controls.Add(this.PortsBox);
            this.Controls.Add(this.CountriesList);
            this.Controls.Add(this.ProxyCountry_label);
            this.Controls.Add(this.Parse_button);
            this.Controls.Add(this.Output_label);
            this.Controls.Add(this.SaveProxy);
            this.Controls.Add(this.OutputBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "HideMy.Name Proxy Parser";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox OutputBox;
        private System.Windows.Forms.Button SaveProxy;
        private System.Windows.Forms.Label Output_label;
        private System.Windows.Forms.Button Parse_button;
        private System.Windows.Forms.Label ProxyCountry_label;
        private System.Windows.Forms.CheckedListBox CountriesList;
        private System.Windows.Forms.TextBox PortsBox;
        private System.Windows.Forms.Label Ports_label;
        private System.Windows.Forms.CheckedListBox AnonymouseTypesList;
        private System.Windows.Forms.Label Anonymity_Label;
        private System.Windows.Forms.Label MaxPing_label;
        private System.Windows.Forms.TextBox MaxPingBox;
        private System.Windows.Forms.Label Page_label;
        private System.Windows.Forms.TextBox PageBox;
        private System.Windows.Forms.CheckBox UseOutputBox;
        private System.Windows.Forms.Label ProxyType_label;
        private System.Windows.Forms.CheckedListBox ProxyTypeList;
    }
}

