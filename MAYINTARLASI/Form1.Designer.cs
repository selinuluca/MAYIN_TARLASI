namespace MAYINTARLASI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            label3 = new Label();
            btn_oyunabasla = new Button();
            lblskor = new Label();
            lblmayınskor = new Label();
            label4 = new Label();
            label5 = new Label();
            label2 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            resources.ApplyResources(flowLayoutPanel1, "flowLayoutPanel1");
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // btn_oyunabasla
            // 
            btn_oyunabasla.AutoEllipsis = true;
            btn_oyunabasla.BackColor = SystemColors.ActiveCaption;
            resources.ApplyResources(btn_oyunabasla, "btn_oyunabasla");
            btn_oyunabasla.Name = "btn_oyunabasla";
            btn_oyunabasla.UseVisualStyleBackColor = false;
            btn_oyunabasla.Click += btn_oyunabasla_Click;
            // 
            // lblskor
            // 
            resources.ApplyResources(lblskor, "lblskor");
            lblskor.Name = "lblskor";
            // 
            // lblmayınskor
            // 
            resources.ApplyResources(lblmayınskor, "lblmayınskor");
            lblmayınskor.ForeColor = Color.Red;
            lblmayınskor.Name = "lblmayınskor";
            lblmayınskor.Click += lblmayınskor_Click;
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.ForeColor = Color.FromArgb(192, 0, 192);
            label4.Name = "label4";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.ForeColor = Color.FromArgb(192, 0, 192);
            label5.Name = "label5";
            label5.Click += label5_Click;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.ForeColor = Color.Blue;
            label2.Name = "label2";
            label2.Click += label2_Click;
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.ForeColor = Color.Blue;
            label6.Name = "label6";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lblmayınskor);
            Controls.Add(lblskor);
            Controls.Add(btn_oyunabasla);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private Label label3;
        private Button btn_oyunabasla;
        private Label lblskor;
        private Label lblmayınskor;
        private Label label4;
        private Label label5;
        private Label label2;
        private Label label6;
    }
}