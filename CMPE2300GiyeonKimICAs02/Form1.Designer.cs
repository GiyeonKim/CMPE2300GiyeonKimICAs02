namespace CMPE2300GiyeonKimICAs02
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
            this.components = new System.ComponentModel.Container();
            this.OpacityTrack = new System.Windows.Forms.TrackBar();
            this.YTrack = new System.Windows.Forms.TrackBar();
            this.XTrack = new System.Windows.Forms.TrackBar();
            this.All_checkBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._opacity_Label = new System.Windows.Forms.Label();
            this.X_label = new System.Windows.Forms.Label();
            this._Y_label = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.OpacityTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XTrack)).BeginInit();
            this.SuspendLayout();
            // 
            // OpacityTrack
            // 
            this.OpacityTrack.Location = new System.Drawing.Point(120, 21);
            this.OpacityTrack.Maximum = 255;
            this.OpacityTrack.Name = "OpacityTrack";
            this.OpacityTrack.Size = new System.Drawing.Size(366, 45);
            this.OpacityTrack.TabIndex = 0;
            this.OpacityTrack.TickFrequency = 10;
            this.OpacityTrack.Value = 128;
            this.OpacityTrack.Scroll += new System.EventHandler(this.OpacityTrack_Scroll);
            // 
            // YTrack
            // 
            this.YTrack.Location = new System.Drawing.Point(120, 135);
            this.YTrack.Maximum = 15;
            this.YTrack.Minimum = -15;
            this.YTrack.Name = "YTrack";
            this.YTrack.Size = new System.Drawing.Size(366, 45);
            this.YTrack.TabIndex = 1;
            this.YTrack.Scroll += new System.EventHandler(this.YTrack_Scroll);
            // 
            // XTrack
            // 
            this.XTrack.Location = new System.Drawing.Point(120, 84);
            this.XTrack.Maximum = 15;
            this.XTrack.Minimum = -15;
            this.XTrack.Name = "XTrack";
            this.XTrack.Size = new System.Drawing.Size(366, 45);
            this.XTrack.TabIndex = 2;
            this.XTrack.Scroll += new System.EventHandler(this.XTrack_Scroll);
            // 
            // All_checkBox
            // 
            this.All_checkBox.AutoSize = true;
            this.All_checkBox.Location = new System.Drawing.Point(235, 197);
            this.All_checkBox.Name = "All_checkBox";
            this.All_checkBox.Size = new System.Drawing.Size(37, 17);
            this.All_checkBox.TabIndex = 3;
            this.All_checkBox.Text = "All";
            this.All_checkBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Opacity:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "X:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Y:";
            // 
            // _opacity_Label
            // 
            this._opacity_Label.AutoSize = true;
            this._opacity_Label.Location = new System.Drawing.Point(76, 31);
            this._opacity_Label.Name = "_opacity_Label";
            this._opacity_Label.Size = new System.Drawing.Size(15, 13);
            this._opacity_Label.TabIndex = 7;
            this._opacity_Label.Text = "{}";
            // 
            // X_label
            // 
            this.X_label.AutoSize = true;
            this.X_label.Location = new System.Drawing.Point(70, 84);
            this.X_label.Name = "X_label";
            this.X_label.Size = new System.Drawing.Size(15, 13);
            this.X_label.TabIndex = 8;
            this.X_label.Text = "{}";
            // 
            // _Y_label
            // 
            this._Y_label.AutoSize = true;
            this._Y_label.Location = new System.Drawing.Point(73, 135);
            this._Y_label.Name = "_Y_label";
            this._Y_label.Size = new System.Drawing.Size(15, 13);
            this._Y_label.TabIndex = 9;
            this._Y_label.Text = "{}";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 255);
            this.Controls.Add(this._Y_label);
            this.Controls.Add(this.X_label);
            this.Controls.Add(this._opacity_Label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.All_checkBox);
            this.Controls.Add(this.XTrack);
            this.Controls.Add(this.YTrack);
            this.Controls.Add(this.OpacityTrack);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.OpacityTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XTrack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar OpacityTrack;
        private System.Windows.Forms.TrackBar YTrack;
        private System.Windows.Forms.TrackBar XTrack;
        private System.Windows.Forms.CheckBox All_checkBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label _opacity_Label;
        private System.Windows.Forms.Label X_label;
        private System.Windows.Forms.Label _Y_label;
        private System.Windows.Forms.Timer timer1;
    }
}

