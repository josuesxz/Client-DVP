namespace Client_DVP
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
            btn_conect = new Button();
            lb_info_conect = new Label();
            lb_data = new Label();
            lb_mes = new Label();
            lb_ano = new Label();
            lb_minuto = new Label();
            lb_hora = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lb_dia = new Label();
            SuspendLayout();
            // 
            // btn_conect
            // 
            btn_conect.Location = new Point(161, 391);
            btn_conect.Name = "btn_conect";
            btn_conect.Size = new Size(75, 23);
            btn_conect.TabIndex = 0;
            btn_conect.Text = "Conectar";
            btn_conect.UseVisualStyleBackColor = true;
            btn_conect.Click += btn_conect_Click;
            // 
            // lb_info_conect
            // 
            lb_info_conect.AutoSize = true;
            lb_info_conect.Location = new Point(161, 417);
            lb_info_conect.Name = "lb_info_conect";
            lb_info_conect.Size = new Size(82, 15);
            lb_info_conect.TabIndex = 1;
            lb_info_conect.Text = "Aguardando...";
            // 
            // lb_data
            // 
            lb_data.AutoSize = true;
            lb_data.ImageAlign = ContentAlignment.MiddleRight;
            lb_data.Location = new Point(12, 9);
            lb_data.Name = "lb_data";
            lb_data.Size = new Size(19, 15);
            lb_data.TabIndex = 2;
            lb_data.Text = "00";
            // 
            // lb_mes
            // 
            lb_mes.AutoSize = true;
            lb_mes.ImageAlign = ContentAlignment.MiddleRight;
            lb_mes.Location = new Point(37, 9);
            lb_mes.Name = "lb_mes";
            lb_mes.Size = new Size(19, 15);
            lb_mes.TabIndex = 3;
            lb_mes.Text = "00";
            // 
            // lb_ano
            // 
            lb_ano.AutoSize = true;
            lb_ano.ImageAlign = ContentAlignment.MiddleRight;
            lb_ano.Location = new Point(62, 9);
            lb_ano.Name = "lb_ano";
            lb_ano.Size = new Size(31, 15);
            lb_ano.TabIndex = 4;
            lb_ano.Text = "0000";
            // 
            // lb_minuto
            // 
            lb_minuto.AutoSize = true;
            lb_minuto.ImageAlign = ContentAlignment.MiddleRight;
            lb_minuto.Location = new Point(363, 9);
            lb_minuto.Name = "lb_minuto";
            lb_minuto.Size = new Size(19, 15);
            lb_minuto.TabIndex = 6;
            lb_minuto.Text = "00";
            // 
            // lb_hora
            // 
            lb_hora.AutoSize = true;
            lb_hora.ImageAlign = ContentAlignment.MiddleRight;
            lb_hora.Location = new Point(338, 9);
            lb_hora.Name = "lb_hora";
            lb_hora.Size = new Size(19, 15);
            lb_hora.TabIndex = 5;
            lb_hora.Text = "00";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 9);
            label1.Name = "label1";
            label1.Size = new Size(12, 15);
            label1.TabIndex = 7;
            label1.Text = "/";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 9);
            label2.Name = "label2";
            label2.Size = new Size(12, 15);
            label2.TabIndex = 8;
            label2.Text = "/";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(355, 9);
            label3.Name = "label3";
            label3.Size = new Size(10, 15);
            label3.TabIndex = 9;
            label3.Text = ":";
            // 
            // lb_dia
            // 
            lb_dia.AutoSize = true;
            lb_dia.Location = new Point(13, 35);
            lb_dia.Name = "lb_dia";
            lb_dia.Size = new Size(30, 15);
            lb_dia.TabIndex = 10;
            lb_dia.Text = "Dia: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(392, 450);
            Controls.Add(lb_dia);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lb_minuto);
            Controls.Add(lb_hora);
            Controls.Add(lb_ano);
            Controls.Add(lb_mes);
            Controls.Add(lb_data);
            Controls.Add(lb_info_conect);
            Controls.Add(btn_conect);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            Text = "Console Chiller - Daikin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_conect;
        private Label lb_info_conect;
        private Label lb_data;
        private Label lb_mes;
        private Label lb_ano;
        private Label lb_minuto;
        private Label lb_hora;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lb_dia;
    }
}
