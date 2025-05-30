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
        string Aux_status = "", Aux_modo = "", Aux_dia = "", Aux_stts_ckt1 = "", Aux_stts_ckt2 = "";
        int controle, habilitado, alarme, modo, set_ptn, cap, stts, temp, data, dia, mes, ano, hora, minuto, cap_ckt1, stts_ckt1, cap_ckt2, stts_ckt2;

        private void btn_conect_Click(object sender, EventArgs e)
        {
            try
            {
                CLP.Connect("10.57.76.20", 502);
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
                int[] leitura = CLP.ReadHoldingRegisters(200, 25);
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
                cap_ckt1 = Convert.ToInt32(leitura[19]);
                stts_ckt1 = Convert.ToInt32(leitura[20]);
                cap_ckt2 = Convert.ToInt32(leitura[17]);
                stts_ckt2 = Convert.ToInt32(leitura[18]);


                lb_dia.Text = "Dia: " + Aux_dia;
                lb_temp.Text = "Temperatura: " + temp*0.1 + " °C";
                lb_data.Text = data + " / " + mes + " / " + ano;
                lb_hora.Text = hora + " : " + minuto;
                lb_capacity.Text = "Capacidade: " + cap*0.1 + " %";
                lb_set_point.Text = "Set point: " + set_ptn* 0.1 + " °C";
                lb_status.Text = "Status: " + Aux_status;
                lb_modo.Text = "Modo " + Aux_modo;
                lb_cap_ck1.Text = "Capacidade do circuito 1: " + cap_ckt1 * 0.1 + " %";
                lb_cap_ckt2.Text = "Capacidade do circuito 2: " + cap_ckt2 * 0.1 + " %";
                lb_stts_ckt1.Text = "Estatus do circuito 1: " + Aux_stts_ckt1;
                lb_stts_ckt2.Text = "Estatus do circuito 2: " + Aux_stts_ckt2;
            }
            else
            {
                MessageBox.Show("Conecte ao CLP!!");
            }
            
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

            if (controle == 0)
            {
                lb_controle.Text = "Controle: Remoto";
            }
            else
            {
                lb_controle.Text = "Controle: Local";
            }

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

            switch (dia)
            {
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
            switch (stts_ckt1)
            {
                case 0:
                    Aux_stts_ckt1 = "Stop";
                    break;
                case 1:
                    Aux_stts_ckt1 = "Run";
                    break;
                default:
                    Aux_stts_ckt1 = "Sem informação";
                    break;
                }
            switch (stts_ckt2)
            {
                case 0:
                    Aux_stts_ckt2 = "Stop";
                    break;
                case 1:
                    Aux_stts_ckt2 = "Run";
                    break;
                default:
                    Aux_stts_ckt2 = "Sem informação";
                    break;
                }

            }

        private void btn_disconnect_Click(object sender, EventArgs e)
        {
            if(CLP.Connected){ 
            CLP.Disconnect();
            lb_info_conect.Text = "Desconectado";
            }
        }
    }
}