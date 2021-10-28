using Domain.ActivoFijo.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TareaProgramacion.Formulario
{
    public partial class FrmRegistrar : Form
    {
        public FrmRegistrar()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void CmbTipoActivo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void FrmRegistrar_Load(object sender, EventArgs e)
        {
            cmbTipoActivo.Items.AddRange(Enum.GetValues(typeof(EnumsTipoActivo)).Cast<object>().ToArray());
            cmbMetodoDepreciacion.Items.AddRange(Enum.GetValues(typeof(EnumsTipoActivo)).Cast<object>().ToArray());
        }

        private void BtnEnviar_Click(object sender, EventArgs e)
        {

        }
    }
}
