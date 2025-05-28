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
            gb_Leitura = new GroupBox();
            lb_stts_ckt2 = new Label();
            lb_cap_ckt2 = new Label();
            lb_stts_ckt1 = new Label();
            lb_cap_ck1 = new Label();
            lb_temp = new Label();
            lb_status = new Label();
            lb_capacity = new Label();
            lb_set_point = new Label();
            lb_modo = new Label();
            lb_alarme = new Label();
            lb_enable = new Label();
            lb_controle = new Label();
            gp_escrita = new GroupBox();
            btn_rst = new Button();
            btn_enable = new Button();
            gb_Leitura.SuspendLayout();
            gp_escrita.SuspendLayout();
            SuspendLayout();
            // 
            // btn_conect
            // 
            btn_conect.Location = new Point(161, 399);
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
            lb_info_conect.Location = new Point(161, 425);
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
            lb_data.Click += lb_data_Click;
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
            lb_mes.Click += lb_mes_Click;
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
            lb_ano.Click += lb_ano_Click;
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
            lb_minuto.Click += lb_minuto_Click;
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
            lb_hora.Click += lb_hora_Click;
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
            // gb_Leitura
            // 
            gb_Leitura.Controls.Add(lb_stts_ckt2);
            gb_Leitura.Controls.Add(lb_cap_ckt2);
            gb_Leitura.Controls.Add(lb_stts_ckt1);
            gb_Leitura.Controls.Add(lb_cap_ck1);
            gb_Leitura.Controls.Add(lb_temp);
            gb_Leitura.Controls.Add(lb_status);
            gb_Leitura.Controls.Add(lb_capacity);
            gb_Leitura.Controls.Add(lb_set_point);
            gb_Leitura.Controls.Add(lb_modo);
            gb_Leitura.Controls.Add(lb_alarme);
            gb_Leitura.Controls.Add(lb_enable);
            gb_Leitura.Controls.Add(lb_controle);
            gb_Leitura.Location = new Point(12, 67);
            gb_Leitura.Name = "gb_Leitura";
            gb_Leitura.Size = new Size(370, 245);
            gb_Leitura.TabIndex = 11;
            gb_Leitura.TabStop = false;
            gb_Leitura.Text = "Leitura";
            gb_Leitura.Enter += groupBox1_Enter;
            // 
            // lb_stts_ckt2
            // 
            lb_stts_ckt2.AutoSize = true;
            lb_stts_ckt2.Location = new Point(183, 111);
            lb_stts_ckt2.Name = "lb_stts_ckt2";
            lb_stts_ckt2.Size = new Size(104, 15);
            lb_stts_ckt2.TabIndex = 11;
            lb_stts_ckt2.Text = "Estatus Circuito 2: ";
            // 
            // lb_cap_ckt2
            // 
            lb_cap_ckt2.AutoSize = true;
            lb_cap_ckt2.Location = new Point(182, 82);
            lb_cap_ckt2.Name = "lb_cap_ckt2";
            lb_cap_ckt2.Size = new Size(129, 15);
            lb_cap_ckt2.TabIndex = 10;
            lb_cap_ckt2.Text = "Capacidade Circuito 2: ";
            // 
            // lb_stts_ckt1
            // 
            lb_stts_ckt1.AutoSize = true;
            lb_stts_ckt1.Location = new Point(182, 57);
            lb_stts_ckt1.Name = "lb_stts_ckt1";
            lb_stts_ckt1.Size = new Size(104, 15);
            lb_stts_ckt1.TabIndex = 9;
            lb_stts_ckt1.Text = "Estatus Circuito 1: ";
            // 
            // lb_cap_ck1
            // 
            lb_cap_ck1.AutoSize = true;
            lb_cap_ck1.Location = new Point(181, 28);
            lb_cap_ck1.Name = "lb_cap_ck1";
            lb_cap_ck1.Size = new Size(129, 15);
            lb_cap_ck1.TabIndex = 8;
            lb_cap_ck1.Text = "Capacidade Circuito 1: ";
            // 
            // lb_temp
            // 
            lb_temp.AutoSize = true;
            lb_temp.Location = new Point(6, 209);
            lb_temp.Name = "lb_temp";
            lb_temp.Size = new Size(80, 15);
            lb_temp.TabIndex = 7;
            lb_temp.Text = "Temperatura: ";
            lb_temp.Click += lb_temp_Click;
            // 
            // lb_status
            // 
            lb_status.AutoSize = true;
            lb_status.Location = new Point(6, 185);
            lb_status.Name = "lb_status";
            lb_status.Size = new Size(45, 15);
            lb_status.TabIndex = 6;
            lb_status.Text = "Status: ";
            lb_status.Click += lb_status_Click;
            // 
            // lb_capacity
            // 
            lb_capacity.AutoSize = true;
            lb_capacity.Location = new Point(6, 160);
            lb_capacity.Name = "lb_capacity";
            lb_capacity.Size = new Size(72, 15);
            lb_capacity.TabIndex = 5;
            lb_capacity.Text = "Capacidade:";
            lb_capacity.Click += lb_capacity_Click;
            // 
            // lb_set_point
            // 
            lb_set_point.AutoSize = true;
            lb_set_point.Location = new Point(6, 135);
            lb_set_point.Name = "lb_set_point";
            lb_set_point.Size = new Size(60, 15);
            lb_set_point.TabIndex = 4;
            lb_set_point.Text = "Set point: ";
            lb_set_point.Click += lb_set_point_Click;
            // 
            // lb_modo
            // 
            lb_modo.AutoSize = true;
            lb_modo.Location = new Point(6, 110);
            lb_modo.Name = "lb_modo";
            lb_modo.Size = new Size(45, 15);
            lb_modo.TabIndex = 3;
            lb_modo.Text = "Modo: ";
            lb_modo.Click += lb_modo_Click;
            // 
            // lb_alarme
            // 
            lb_alarme.AutoSize = true;
            lb_alarme.Location = new Point(6, 82);
            lb_alarme.Name = "lb_alarme";
            lb_alarme.Size = new Size(45, 15);
            lb_alarme.TabIndex = 2;
            lb_alarme.Text = "Alarme";
            lb_alarme.Click += lb_alarme_Click;
            // 
            // lb_enable
            // 
            lb_enable.AutoSize = true;
            lb_enable.Location = new Point(6, 57);
            lb_enable.Name = "lb_enable";
            lb_enable.Size = new Size(62, 15);
            lb_enable.TabIndex = 1;
            lb_enable.Text = "Habilitado";
            lb_enable.Click += lb_enable_Click;
            // 
            // lb_controle
            // 
            lb_controle.AutoSize = true;
            lb_controle.Location = new Point(6, 28);
            lb_controle.Name = "lb_controle";
            lb_controle.Size = new Size(59, 15);
            lb_controle.TabIndex = 0;
            lb_controle.Text = "Controle: ";
            lb_controle.Click += lb_controle_Click;
            // 
            // gp_escrita
            // 
            gp_escrita.Controls.Add(btn_rst);
            gp_escrita.Controls.Add(btn_enable);
            gp_escrita.Location = new Point(12, 318);
            gp_escrita.Name = "gp_escrita";
            gp_escrita.Size = new Size(370, 70);
            gp_escrita.TabIndex = 12;
            gp_escrita.TabStop = false;
            gp_escrita.Text = "Escrita";
            // 
            // btn_rst
            // 
            btn_rst.Location = new Point(278, 30);
            btn_rst.Name = "btn_rst";
            btn_rst.Size = new Size(75, 23);
            btn_rst.TabIndex = 1;
            btn_rst.Text = "Reset";
            btn_rst.UseVisualStyleBackColor = true;
            // 
            // btn_enable
            // 
            btn_enable.Location = new Point(15, 30);
            btn_enable.Name = "btn_enable";
            btn_enable.Size = new Size(75, 23);
            btn_enable.TabIndex = 0;
            btn_enable.Text = "Acionar ";
            btn_enable.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(392, 450);
            Controls.Add(gp_escrita);
            Controls.Add(gb_Leitura);
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
            gb_Leitura.ResumeLayout(false);
            gb_Leitura.PerformLayout();
            gp_escrita.ResumeLayout(false);
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
        private GroupBox gb_Leitura;
        private GroupBox gp_escrita;
        private Button btn_rst;
        private Button btn_enable;
        private Label lb_controle;
        private Label lb_enable;
        private Label lb_modo;
        private Label lb_alarme;
        private Label lb_stts_ckt1;
        private Label lb_cap_ck1;
        private Label lb_temp;
        private Label lb_status;
        private Label lb_capacity;
        private Label lb_set_point;
        private Label lb_stts_ckt2;
        private Label lb_cap_ckt2;
    }
}
