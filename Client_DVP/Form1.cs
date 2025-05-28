using EasyModbus; // É a biblioteca EasyModbusTCP.NETCore
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
    }
}
