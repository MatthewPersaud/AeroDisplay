﻿
namespace AerodisplayHMI
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tempcontrol = new System.Windows.Forms.ComboBox();
            this.pressuremode = new System.Windows.Forms.ListBox();
            this.pressuredisplay = new System.Windows.Forms.Label();
            this.kollsmanwindow = new System.Windows.Forms.TextBox();
            this.altitude = new System.Windows.Forms.Label();
            this.rampressure = new System.Windows.Forms.NumericUpDown();
            this.staticpressure = new System.Windows.Forms.NumericUpDown();
            this.airspeedindicator = new System.Windows.Forms.Label();
            this.ailabel = new System.Windows.Forms.Label();
            this.temperaturelabel = new System.Windows.Forms.Label();
            this.kwlabel = new System.Windows.Forms.Label();
            this.altitudelabel = new System.Windows.Forms.Label();
            this.powerbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rampressure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staticpressure)).BeginInit();
            this.SuspendLayout();
            // 
            // tempcontrol
            // 
            this.tempcontrol.FormattingEnabled = true;
            this.tempcontrol.Location = new System.Drawing.Point(38, 384);
            this.tempcontrol.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tempcontrol.Name = "tempcontrol";
            this.tempcontrol.Size = new System.Drawing.Size(180, 33);
            this.tempcontrol.TabIndex = 1;
            // 
            // pressuremode
            // 
            this.pressuremode.FormattingEnabled = true;
            this.pressuremode.ItemHeight = 25;
            this.pressuremode.Location = new System.Drawing.Point(38, 229);
            this.pressuremode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pressuremode.Name = "pressuremode";
            this.pressuremode.Size = new System.Drawing.Size(178, 104);
            this.pressuremode.TabIndex = 2;
            this.pressuremode.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // pressuredisplay
            // 
            this.pressuredisplay.AutoSize = true;
            this.pressuredisplay.Location = new System.Drawing.Point(96, 200);
            this.pressuredisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pressuredisplay.Name = "pressuredisplay";
            this.pressuredisplay.Size = new System.Drawing.Size(64, 25);
            this.pressuredisplay.TabIndex = 3;
            this.pressuredisplay.Text = "label1";
            this.pressuredisplay.Click += new System.EventHandler(this.label1_Click);
            // 
            // kollsmanwindow
            // 
            this.kollsmanwindow.Location = new System.Drawing.Point(718, 331);
            this.kollsmanwindow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.kollsmanwindow.Name = "kollsmanwindow";
            this.kollsmanwindow.Size = new System.Drawing.Size(103, 30);
            this.kollsmanwindow.TabIndex = 4;
            this.kollsmanwindow.Text = "29.92";
            this.kollsmanwindow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.kollsmanwindow.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // altitude
            // 
            this.altitude.AutoSize = true;
            this.altitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.altitude.Location = new System.Drawing.Point(710, 238);
            this.altitude.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.altitude.MinimumSize = new System.Drawing.Size(50, 50);
            this.altitude.Name = "altitude";
            this.altitude.Size = new System.Drawing.Size(125, 50);
            this.altitude.TabIndex = 5;
            this.altitude.Text = "00000";
            // 
            // rampressure
            // 
            this.rampressure.Location = new System.Drawing.Point(406, 469);
            this.rampressure.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rampressure.Maximum = new decimal(new int[] {
            105,
            0,
            0,
            0});
            this.rampressure.Minimum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.rampressure.Name = "rampressure";
            this.rampressure.Size = new System.Drawing.Size(100, 30);
            this.rampressure.TabIndex = 6;
            this.rampressure.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.rampressure.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // staticpressure
            // 
            this.staticpressure.Location = new System.Drawing.Point(406, 509);
            this.staticpressure.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.staticpressure.Maximum = new decimal(new int[] {
            105,
            0,
            0,
            0});
            this.staticpressure.Minimum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.staticpressure.Name = "staticpressure";
            this.staticpressure.Size = new System.Drawing.Size(100, 30);
            this.staticpressure.TabIndex = 7;
            this.staticpressure.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.staticpressure.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // airspeedindicator
            // 
            this.airspeedindicator.AutoSize = true;
            this.airspeedindicator.BackColor = System.Drawing.Color.Transparent;
            this.airspeedindicator.Location = new System.Drawing.Point(546, 491);
            this.airspeedindicator.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.airspeedindicator.Name = "airspeedindicator";
            this.airspeedindicator.Size = new System.Drawing.Size(75, 25);
            this.airspeedindicator.TabIndex = 8;
            this.airspeedindicator.Text = "0 knots";
            this.airspeedindicator.Click += new System.EventHandler(this.airspeedindicator_Click);
            // 
            // ailabel
            // 
            this.ailabel.AutoSize = true;
            this.ailabel.BackColor = System.Drawing.Color.Transparent;
            this.ailabel.Location = new System.Drawing.Point(366, 430);
            this.ailabel.Name = "ailabel";
            this.ailabel.Size = new System.Drawing.Size(169, 25);
            this.ailabel.TabIndex = 12;
            this.ailabel.Text = "Airspeed Indicator";
            // 
            // temperaturelabel
            // 
            this.temperaturelabel.AutoSize = true;
            this.temperaturelabel.Location = new System.Drawing.Point(54, 354);
            this.temperaturelabel.Name = "temperaturelabel";
            this.temperaturelabel.Size = new System.Drawing.Size(151, 25);
            this.temperaturelabel.TabIndex = 13;
            this.temperaturelabel.Text = "Set temperature\r\n";
            // 
            // kwlabel
            // 
            this.kwlabel.AutoSize = true;
            this.kwlabel.Location = new System.Drawing.Point(692, 301);
            this.kwlabel.Name = "kwlabel";
            this.kwlabel.Size = new System.Drawing.Size(169, 25);
            this.kwlabel.TabIndex = 14;
            this.kwlabel.Text = "Kollsman Window";
            // 
            // altitudelabel
            // 
            this.altitudelabel.AutoSize = true;
            this.altitudelabel.Location = new System.Drawing.Point(727, 200);
            this.altitudelabel.Name = "altitudelabel";
            this.altitudelabel.Size = new System.Drawing.Size(77, 25);
            this.altitudelabel.TabIndex = 15;
            this.altitudelabel.Text = "Altitude";
            // 
            // powerbutton
            // 
            this.powerbutton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.powerbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.powerbutton.Location = new System.Drawing.Point(75, 449);
            this.powerbutton.Name = "powerbutton";
            this.powerbutton.Size = new System.Drawing.Size(100, 68);
            this.powerbutton.TabIndex = 16;
            this.powerbutton.Text = "Take Off";
            this.powerbutton.UseVisualStyleBackColor = false;
            this.powerbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(265, 468);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Ram Pressure:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(257, 509);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Static Pressure:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(890, 553);
            this.Controls.Add(this.staticpressure);
            this.Controls.Add(this.rampressure);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.powerbutton);
            this.Controls.Add(this.altitudelabel);
            this.Controls.Add(this.kwlabel);
            this.Controls.Add(this.temperaturelabel);
            this.Controls.Add(this.ailabel);
            this.Controls.Add(this.airspeedindicator);
            this.Controls.Add(this.altitude);
            this.Controls.Add(this.kollsmanwindow);
            this.Controls.Add(this.pressuredisplay);
            this.Controls.Add(this.pressuremode);
            this.Controls.Add(this.tempcontrol);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.rampressure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staticpressure)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox tempcontrol;
        private System.Windows.Forms.ListBox pressuremode;
        private System.Windows.Forms.Label pressuredisplay;
        private System.Windows.Forms.TextBox kollsmanwindow;
        private System.Windows.Forms.Label altitude;
        private System.Windows.Forms.NumericUpDown rampressure;
        private System.Windows.Forms.NumericUpDown staticpressure;
        private System.Windows.Forms.Label airspeedindicator;
        private System.Windows.Forms.Label ailabel;
        private System.Windows.Forms.Label temperaturelabel;
        private System.Windows.Forms.Label kwlabel;
        private System.Windows.Forms.Label altitudelabel;
        private System.Windows.Forms.Button powerbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

