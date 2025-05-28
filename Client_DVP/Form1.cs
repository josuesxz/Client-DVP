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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lb_controle_Click(object sender, EventArgs e)
        {
            if (CLP.Connected)
            {
                int Fonte = Convert.ToInt32(CLP.ReadHoldingRegisters(200, 1)[0]);
                if (Fonte == 0)
                {
                    lb_controle.Text = "Controle: Local";
                }
                if (Fonte == 1)
                {
                    lb_controle.Text = "Controle: Remoto";
                }
            }

        }

        private void lb_enable_Click(object sender, EventArgs e)
        {
            if (CLP.Connected)
            {
                int Habilitado = Convert.ToInt32(CLP.ReadHoldingRegisters(201, 1)[0]);
                if (Habilitado == 0)
                {
                    lb_enable.Text = "Desabilitado";
                }
                if (Habilitado == 1)
                {
                    lb_enable.Text = "Habilitado";
                }
            }
        }

        private void lb_alarme_Click(object sender, EventArgs e)
        {
            if (CLP.Connected)
            {
                int Alarme = Convert.ToInt32(CLP.ReadHoldingRegisters(203, 1)[0]);
                if (Alarme == 0)
                {
                    lb_alarme.Text = "Sem alarme";
                }
                if (Alarme == 1)
                {
                    lb_alarme.Text = "Com alarme";
                }
            }
        }

        private void lb_modo_Click(object sender, EventArgs e)
        {
            if (CLP.Connected)
            {
                int Modo = Convert.ToInt32(CLP.ReadHoldingRegisters(205, 1)[0]);
                string Aux_modo;
                switch (Modo)
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
            }
        }

        private void lb_set_point_Click(object sender, EventArgs e)
        {
            if (CLP.Connected)
            {
                lb_set_point.Text = "Set point: " + CLP.ReadHoldingRegisters(206, 1)[0] + " °C";
            }
        }

        private void lb_capacity_Click(object sender, EventArgs e)
        {
            if (CLP.Connected)
            {
                lb_capacity.Text = "Capacidade: " + CLP.ReadHoldingRegisters(207, 1)[0] + " %";
            }
        }

        private void lb_status_Click(object sender, EventArgs e)
        {
            if (CLP.Connected)
            {
                int Status = Convert.ToInt32(CLP.ReadHoldingRegisters(208, 1)[0]);
                string Aux_status;
                switch (Status)
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
            }
        }

        private void lb_temp_Click(object sender, EventArgs e)
        {
            if (CLP.Connected)
            {
                lb_temp.Text = "Temperatura: " + CLP.ReadHoldingRegisters(209, 1)[0] + " °C";
            }
        }

        private void lb_data_Click(object sender, EventArgs e)
        {
            if (CLP.Connected)
            {
                lb_data.Text = Convert.ToString(CLP.ReadHoldingRegisters(212, 1)[0]);
            }
        }

        private void lb_mes_Click(object sender, EventArgs e)
        {
            if (CLP.Connected)
            {
                lb_mes.Text = Convert.ToString(CLP.ReadHoldingRegisters(211, 1)[0]);
            }
        }

        private void lb_ano_Click(object sender, EventArgs e)
        {
            if (CLP.Connected)
            {
                lb_ano.Text = Convert.ToString(CLP.ReadHoldingRegisters(210, 1)[0]);
            }
        }

        private void lb_hora_Click(object sender, EventArgs e)
        {
            if (CLP.Connected)
            {
                lb_hora.Text = Convert.ToString(CLP.ReadHoldingRegisters(214, 1)[0]);
            }
        }

        private void lb_minuto_Click(object sender, EventArgs e)
        {
            if (CLP.Connected)
            {
                lb_minuto.Text = Convert.ToString(CLP.ReadHoldingRegisters(215, 1)[0]);
            }
        }
    }
}

