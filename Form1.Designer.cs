namespace TypicalYasuo
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
            this.pbTeemo = new System.Windows.Forms.PictureBox();
            this.pbYasuo = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pbTornado = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnOpet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbTeemo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbYasuo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTornado)).BeginInit();
            this.SuspendLayout();
            // 
            // pbTeemo
            // 
            this.pbTeemo.BackColor = System.Drawing.Color.Transparent;
            this.pbTeemo.Enabled = false;
            this.pbTeemo.Image = global::TypicalYasuo.Properties.Resources.teemo1;
            this.pbTeemo.Location = new System.Drawing.Point(336, 459);
            this.pbTeemo.Name = "pbTeemo";
            this.pbTeemo.Size = new System.Drawing.Size(97, 105);
            this.pbTeemo.TabIndex = 0;
            this.pbTeemo.TabStop = false;
            // 
            // pbYasuo
            // 
            this.pbYasuo.BackColor = System.Drawing.Color.Transparent;
            this.pbYasuo.Enabled = false;
            this.pbYasuo.Image = global::TypicalYasuo.Properties.Resources.yas_1;
            this.pbYasuo.Location = new System.Drawing.Point(336, 0);
            this.pbYasuo.Name = "pbYasuo";
            this.pbYasuo.Size = new System.Drawing.Size(97, 105);
            this.pbYasuo.TabIndex = 1;
            this.pbYasuo.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pbTornado
            // 
            this.pbTornado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbTornado.Image = global::TypicalYasuo.Properties.Resources.tornado_1;
            this.pbTornado.Location = new System.Drawing.Point(336, 111);
            this.pbTornado.Name = "pbTornado";
            this.pbTornado.Size = new System.Drawing.Size(101, 109);
            this.pbTornado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTornado.TabIndex = 2;
            this.pbTornado.TabStop = false;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // btnOpet
            // 
            this.btnOpet.Location = new System.Drawing.Point(12, 48);
            this.btnOpet.Name = "btnOpet";
            this.btnOpet.Size = new System.Drawing.Size(116, 39);
            this.btnOpet.TabIndex = 5;
            this.btnOpet.Text = "Pokušaj ponovo";
            this.btnOpet.UseVisualStyleBackColor = true;
            this.btnOpet.Click += new System.EventHandler(this.btnOpet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TypicalYasuo.Properties.Resources.teren;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnOpet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbTornado);
            this.Controls.Add(this.pbYasuo);
            this.Controls.Add(this.pbTeemo);
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Typical Yasuo Tornadoes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbTeemo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbYasuo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTornado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbTeemo;
        private System.Windows.Forms.PictureBox pbYasuo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pbTornado;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOpet;

    }
}

