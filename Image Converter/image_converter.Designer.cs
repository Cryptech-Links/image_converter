namespace Image_Converter
{
    partial class image_converter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(image_converter));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.selected_images_textBox = new System.Windows.Forms.TextBox();
            this.browse_images = new System.Windows.Forms.Button();
            this.imageFormats_dropdown = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.convert_images_but = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.width_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.height_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.process_info = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Image Files (*.jpg, *.jpeg, *.jpe, *.tfif, *.png) | *.jpg; *.jpeg; *.jpe; *.tiff;" +
    " *.png";
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.Title = "Select Images";
            // 
            // selected_images_textBox
            // 
            this.selected_images_textBox.BackColor = System.Drawing.Color.Gainsboro;
            this.selected_images_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selected_images_textBox.Location = new System.Drawing.Point(16, 39);
            this.selected_images_textBox.Name = "selected_images_textBox";
            this.selected_images_textBox.ReadOnly = true;
            this.selected_images_textBox.Size = new System.Drawing.Size(255, 20);
            this.selected_images_textBox.TabIndex = 0;
            // 
            // browse_images
            // 
            this.browse_images.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browse_images.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browse_images.Location = new System.Drawing.Point(291, 37);
            this.browse_images.Name = "browse_images";
            this.browse_images.Size = new System.Drawing.Size(92, 22);
            this.browse_images.TabIndex = 1;
            this.browse_images.Text = "select images";
            this.browse_images.UseVisualStyleBackColor = true;
            this.browse_images.Click += new System.EventHandler(this.browse_images_Click);
            // 
            // imageFormats_dropdown
            // 
            this.imageFormats_dropdown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imageFormats_dropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.imageFormats_dropdown.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imageFormats_dropdown.FormattingEnabled = true;
            this.imageFormats_dropdown.Items.AddRange(new object[] {
            "BMP",
            "TIFF",
            "PNG",
            "JPG / JPEG"});
            this.imageFormats_dropdown.Location = new System.Drawing.Point(197, 77);
            this.imageFormats_dropdown.Name = "imageFormats_dropdown";
            this.imageFormats_dropdown.Size = new System.Drawing.Size(147, 22);
            this.imageFormats_dropdown.TabIndex = 2;
            this.imageFormats_dropdown.SelectedIndexChanged += new System.EventHandler(this.imageFormats_dropdown_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Covert Selected Images to:";
            // 
            // convert_images_but
            // 
            this.convert_images_but.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.convert_images_but.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convert_images_but.Location = new System.Drawing.Point(156, 212);
            this.convert_images_but.Name = "convert_images_but";
            this.convert_images_but.Size = new System.Drawing.Size(92, 29);
            this.convert_images_but.TabIndex = 1;
            this.convert_images_but.Text = "convert";
            this.convert_images_but.UseVisualStyleBackColor = true;
            this.convert_images_but.Click += new System.EventHandler(this.convert_images_but_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Width:";
            // 
            // width_textBox
            // 
            this.width_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.width_textBox.Location = new System.Drawing.Point(68, 32);
            this.width_textBox.Name = "width_textBox";
            this.width_textBox.Size = new System.Drawing.Size(67, 22);
            this.width_textBox.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(158, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "x";
            // 
            // height_textBox
            // 
            this.height_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.height_textBox.Location = new System.Drawing.Point(234, 33);
            this.height_textBox.Name = "height_textBox";
            this.height_textBox.Size = new System.Drawing.Size(67, 22);
            this.height_textBox.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(184, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Height:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.width_textBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.height_textBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(37, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 75);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Tag = "";
            this.groupBox1.Text = "Output Size";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(401, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // process_info
            // 
            this.process_info.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.process_info.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.process_info.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.process_info.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.process_info.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.process_info.Location = new System.Drawing.Point(0, 257);
            this.process_info.Name = "process_info";
            this.process_info.Size = new System.Drawing.Size(401, 17);
            this.process_info.TabIndex = 3;
            this.process_info.Text = "Cryptech Links";
            this.process_info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // image_converter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 274);
            this.Controls.Add(this.process_info);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imageFormats_dropdown);
            this.Controls.Add(this.convert_images_but);
            this.Controls.Add(this.browse_images);
            this.Controls.Add(this.selected_images_textBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "image_converter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox selected_images_textBox;
        private System.Windows.Forms.Button browse_images;
        private System.Windows.Forms.ComboBox imageFormats_dropdown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button convert_images_but;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox width_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox height_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label process_info;
    }
}

