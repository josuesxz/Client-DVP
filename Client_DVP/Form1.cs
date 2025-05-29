using EasyModbus;
using System.Diagnostics; // É a biblioteca EasyModbusTCP.NETCore
namespace Client_DVP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ModbusClient CLP = new ModbusClient();
        int controle, habilitado, alarme, modo, set_ptn, cap, stts, temp, data, dia, mes, ano, hora, minuto;

        private void btn_conect_Click(object sender, EventArgs e)
        {
            try
            {
                CLP.Connect("192.168.30.5", 502);
                lb_info_conect.Text = "CLP conectado";
            }
            catch
            {
                lb_info_conect.Text = "Erro na conexão do CLP";
            }

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (CLP.Connected)
            {
                int[] leitura = CLP.ReadHoldingRegisters(200, 12);
                controle = Convert.ToInt32(leitura[0]);
                habilitado = Convert.ToInt32(leitura[1]);
                alarme = Convert.ToInt32(leitura[2]);
                modo = Convert.ToInt32(leitura[5]);
                set_ptn = Convert.ToInt32(leitura[6]);
                cap = Convert.ToInt32(leitura[7]);
                stts = Convert.ToInt32(leitura[8]);
                temp = Convert.ToInt32(leitura[9]);
                ano = Convert.ToInt32(leitura[10]);
                mes = Convert.ToInt32(leitura[11]);
                data = Convert.ToInt32(leitura[12]);
                dia = Convert.ToInt32(leitura[13]);
                hora = Convert.ToInt32(leitura[14]);
                minuto = Convert.ToInt32(leitura[15]);
            }
            lb_temp.Text = "Temperatura: " + temp + " °C";
            lb_data.Text = data + " / " + mes + " / " + ano;
            lb_hora.Text = hora + " : " + minuto;
            lb_capacity.Text = "Capacidade: " + cap + " %";
            lb_set_point.Text = "Set point: " + set_ptn + " °C";

            string Aux_status;
            switch (stts)
            {
                case 0:
                    Aux_status = "Off";
                    break;
                case 1:
                    Aux_status = "Start";
                    break;
                case 2:
                    Aux_status = "Run";
                    break;
                case 3:
                    Aux_status = "PressShutdown";
                    break;
                case 4:
                    Aux_status = "Service";
                    break;
                default:
                    Aux_status = "Desconhecido";
                    break;

            }

            lb_status.Text = "Status: " + Aux_status;

            if (controle == 1)
            {
                lb_controle.Text = "Controle: Remoto";
            }
            else
            {
                lb_controle.Text = "Controle: Local";
            }

            string Aux_modo;
            switch (modo)
            {
                case 0:
                    Aux_modo = "Ice";
                    break;
                case 1:
                    Aux_modo = "Cool";
                    break;
                case 2:
                    Aux_modo = "Heat";
                    break;
                case 3:
                    Aux_modo = "Heat/Cool";
                    break;
                default:
                    Aux_modo = "Desconhecido";
                    break;
            }

            lb_modo.Text = "Modo " + Aux_modo;

            if (alarme == 0)
            {
                lb_alarme.Text = "Sem alarme";
            }
            if (alarme == 1)
            {
                lb_alarme.Text = "Com alarme";
            }

            if (habilitado == 0)
            {
                lb_enable.Text = "Desabilitado";
            }
            if (habilitado == 1)
            {
                lb_enable.Text = "Habilitado";
            }

            string Aux_dia;
            switch (dia) {
                case 0:
                    Aux_dia = "Segunda";
                    break;
                case 1:
                    Aux_dia = "Terça";
                    break;
                case 2:
                    Aux_dia = "Quarta";
                    break;
                case 3:
                    Aux_dia = "Quinta";
                    break;
                case 4:
                    Aux_dia = "Sexta";
                    break;
                case 5:
                    Aux_dia = "Sabado";
                    break;
                case 6:
                    Aux_dia = "Domingo";
                    break;
                default:
                    Aux_dia = "Sem informação";
                    break;
            }
            lb_dia.Text = "Dia: " + Aux_dia;
        }
    }
}