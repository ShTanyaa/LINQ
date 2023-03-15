
namespace Collection
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.задание1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выполнитьВозврастаМеньше40ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выполнитьДляВоврастаБольше40ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.задание2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выполнитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.регионНачинаетсяНаИToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.задание1ToolStripMenuItem,
            this.задание2ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // задание1ToolStripMenuItem
            // 
            this.задание1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выполнитьВозврастаМеньше40ToolStripMenuItem,
            this.выполнитьДляВоврастаБольше40ToolStripMenuItem});
            this.задание1ToolStripMenuItem.Name = "задание1ToolStripMenuItem";
            this.задание1ToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.задание1ToolStripMenuItem.Text = "Задание1";
            // 
            // выполнитьВозврастаМеньше40ToolStripMenuItem
            // 
            this.выполнитьВозврастаМеньше40ToolStripMenuItem.Name = "выполнитьВозврастаМеньше40ToolStripMenuItem";
            this.выполнитьВозврастаМеньше40ToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.выполнитьВозврастаМеньше40ToolStripMenuItem.Text = "Выполнить возвраста меньше 40";
            this.выполнитьВозврастаМеньше40ToolStripMenuItem.Click += new System.EventHandler(this.выполнитьВозврастаМеньше40ToolStripMenuItem_Click);
            // 
            // выполнитьДляВоврастаБольше40ToolStripMenuItem
            // 
            this.выполнитьДляВоврастаБольше40ToolStripMenuItem.Name = "выполнитьДляВоврастаБольше40ToolStripMenuItem";
            this.выполнитьДляВоврастаБольше40ToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.выполнитьДляВоврастаБольше40ToolStripMenuItem.Text = "Выполнить для вовраста больше 40";
            this.выполнитьДляВоврастаБольше40ToolStripMenuItem.Click += new System.EventHandler(this.выполнитьДляВоврастаБольше40ToolStripMenuItem_Click);
            // 
            // задание2ToolStripMenuItem
            // 
            this.задание2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выполнитьToolStripMenuItem});
            this.задание2ToolStripMenuItem.Name = "задание2ToolStripMenuItem";
            this.задание2ToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.задание2ToolStripMenuItem.Text = "Задание 2";
            // 
            // выполнитьToolStripMenuItem
            // 
            this.выполнитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.регионНачинаетсяНаИToolStripMenuItem});
            this.выполнитьToolStripMenuItem.Name = "выполнитьToolStripMenuItem";
            this.выполнитьToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.выполнитьToolStripMenuItem.Text = "Выполнить";
            this.выполнитьToolStripMenuItem.Click += new System.EventHandler(this.выполнитьToolStripMenuItem_Click);
            // 
            // регионНачинаетсяНаИToolStripMenuItem
            // 
            this.регионНачинаетсяНаИToolStripMenuItem.Name = "регионНачинаетсяНаИToolStripMenuItem";
            this.регионНачинаетсяНаИToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.регионНачинаетсяНаИToolStripMenuItem.Text = "Регион начинается на и";
            this.регионНачинаетсяНаИToolStripMenuItem.Click += new System.EventHandler(this.регионНачинаетсяНаИToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(283, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem задание1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выполнитьВозврастаМеньше40ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выполнитьДляВоврастаБольше40ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem задание2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выполнитьToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem регионНачинаетсяНаИToolStripMenuItem;
        private System.Windows.Forms.Label label2;
    }
}

