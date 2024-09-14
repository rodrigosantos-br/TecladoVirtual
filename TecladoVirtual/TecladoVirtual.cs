using System.Globalization;
using System.Text;

namespace TotemMuseuParaInteracaoDoPublico
{
    public partial class TecladoVirtual : Form
    {
        public TecladoVirtual()
        {
            InitializeComponent();
            //this.textBox = textBox;
            this.TopMost = true;
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams parametros = base.CreateParams;
                parametros.ExStyle |= 0x08000000; // Remover estilo WS_POPUP (tornar o controle uma janela filho)
                return parametros;
            }
        }

        private void btnEspaço_Click(object sender, EventArgs e)
        {
            SendKeys.Send(" ");
            //MessageBox.Show("Você clicou no espaço!");
        }

        private void Alfabeto(object sender, EventArgs e)
        {
            Button tecla = (Button)sender;

            if (chkCapsLock.Checked == true || chkShiftEsquerdo.Checked == true || chkShiftDireito.Checked == true)
            {
                SendKeys.Send((tecla.Text).ToUpper());
                chkShiftEsquerdo.Checked = false;
                chkShiftDireito.Checked = false;
            }
            else
            {
                SendKeys.Send((tecla.Text).ToLower());
            }

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{ENTER}");
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{BS}");
        }

        private void btnSinalDeIgualOuSinalDeMais_Click(object sender, EventArgs e)
        {
            if (chkShiftEsquerdo.Checked == true || chkShiftDireito.Checked == true)
            {
                SendKeys.Send("{+}");
                chkShiftEsquerdo.Checked = false;
                chkShiftDireito.Checked = false;
            }
            else
            {
                SendKeys.Send("{=}");
            }

        }

        private void btnHifenOuUnderline_Click(object sender, EventArgs e)
        {
            if (chkShiftEsquerdo.Checked == true || chkShiftDireito.Checked == true)
            {
                SendKeys.Send("{_}");
                chkShiftEsquerdo.Checked = false;
                chkShiftDireito.Checked = false;
            }
            else
            {
                SendKeys.Send("{-}");
            }

        }

        private void btnZeroOuFechaParenteses_Click(object sender, EventArgs e)
        {
            if (chkShiftEsquerdo.Checked == true || chkShiftDireito.Checked == true)
            {
                SendKeys.Send("{)}");
                chkShiftEsquerdo.Checked = false;
                chkShiftDireito.Checked = false;
            }
            else
            {
                SendKeys.Send("{0}");
            }

        }

        private void btnNoveOuAbreParenteses_Click(object sender, EventArgs e)
        {
            if (chkShiftEsquerdo.Checked == true || chkShiftDireito.Checked == true)
            {
                SendKeys.Send("{(}");
                chkShiftEsquerdo.Checked = false;
                chkShiftDireito.Checked = false;
            }
            else
            {
                SendKeys.Send("{9}");
            }

        }

        private void btnOitoOuAsteristico_Click(object sender, EventArgs e)
        {
            if (chkShiftEsquerdo.Checked == true || chkShiftDireito.Checked == true)
            {
                SendKeys.Send("{*}");
                chkShiftEsquerdo.Checked = false;
                chkShiftDireito.Checked = false;
            }
            else
            {
                SendKeys.Send("{8}");
            }

        }

        private void btnSeteOuEcomercial_Click(object sender, EventArgs e)
        {
            if (chkShiftEsquerdo.Checked == true || chkShiftDireito.Checked == true)
            {
                SendKeys.Send("{&}");
                chkShiftEsquerdo.Checked = false;
                chkShiftDireito.Checked = false;
            }
            else
            {
                SendKeys.Send("{7}");
            }

        }

        private void btnSeisOuTrema_Click(object sender, EventArgs e)
        {
            if (chkShiftEsquerdo.Checked == true || chkShiftDireito.Checked == true)
            {
                SendKeys.Send("{¨}");
                chkShiftEsquerdo.Checked = false;
                chkShiftDireito.Checked = false;
            }
            else
            {
                SendKeys.Send("{6}");
            }

        }

        private void btnCincoOuPorcento_Click(object sender, EventArgs e)
        {
            if (chkShiftEsquerdo.Checked == true || chkShiftDireito.Checked == true)
            {
                SendKeys.Send("{%}");
                chkShiftEsquerdo.Checked = false;
                chkShiftDireito.Checked = false;
            }
            else
            {
                SendKeys.Send("{5}");
            }

        }

        private void btnQuatroOuSifrao_Click(object sender, EventArgs e)
        {
            if (chkShiftEsquerdo.Checked == true || chkShiftDireito.Checked == true)
            {
                SendKeys.Send("{$}");
                chkShiftEsquerdo.Checked = false;
                chkShiftDireito.Checked = false;
            }
            else
            {
                SendKeys.Send("{4}");
            }

        }

        private void btnTresOuJogoDaVelha_Click(object sender, EventArgs e)
        {
            if (chkShiftEsquerdo.Checked == true || chkShiftDireito.Checked == true)
            {
                SendKeys.Send("{#}");
                chkShiftEsquerdo.Checked = false;
                chkShiftDireito.Checked = false;
            }
            else
            {
                SendKeys.Send("{3}");
            }

        }

        private void btnDoisOuArroba_Click(object sender, EventArgs e)
        {
            if (chkShiftEsquerdo.Checked == true || chkShiftDireito.Checked == true)
            {
                SendKeys.Send("{@}");
                chkShiftEsquerdo.Checked = false;
                chkShiftDireito.Checked = false;
            }
            else
            {
                SendKeys.Send("{2}");
            }

        }

        private void btnUmOuExclamacao_Click(object sender, EventArgs e)
        {
            if (chkShiftEsquerdo.Checked == true || chkShiftDireito.Checked == true)
            {
                SendKeys.Send("{!}");
                chkShiftEsquerdo.Checked = false;
                chkShiftDireito.Checked = false;
            }
            else
            {
                SendKeys.Send("{1}");
            }

        }

        private void btnAspasSimplesOuDuplas_Click(object sender, EventArgs e)
        {
            if (chkShiftEsquerdo.Checked == true || chkShiftDireito.Checked == true)
            {
                SendKeys.Send("{\"}");
                chkShiftEsquerdo.Checked = false;
                chkShiftDireito.Checked = false;
            }
            else
            {
                SendKeys.Send("{'}");
            }

        }

        private void btnAbreColchetesOuAbreChaves_Click(object sender, EventArgs e)
        {
            if (chkShiftEsquerdo.Checked == true || chkShiftDireito.Checked == true)
            {
                SendKeys.Send("{{}");
                chkShiftEsquerdo.Checked = false;
                chkShiftDireito.Checked = false;
            }
            else
            {
                SendKeys.Send("{[}");
            }

        }

        private void btnAcentoAgudoOuCraze_Click(object sender, EventArgs e)
        {
            if (chkShiftEsquerdo.Checked == true || chkShiftDireito.Checked == true)
            {
                SendKeys.Send("{`}");
                chkShiftEsquerdo.Checked = false;
                chkShiftDireito.Checked = false;
            }
            else
            {
                SendKeys.Send("{´}");
            }

        }

        private void btnFechaColchetesOuFechaChaves_Click(object sender, EventArgs e)
        {
            if (chkShiftEsquerdo.Checked == true || chkShiftDireito.Checked == true)
            {
                SendKeys.Send("{}}");
                chkShiftEsquerdo.Checked = false;
                chkShiftDireito.Checked = false;
            }
            else
            {
                SendKeys.Send("{]}");
            }

        }

        private void btnTilOuAcentoCircunflexo_Click(object sender, EventArgs e)
        {
            if (chkShiftEsquerdo.Checked == true || chkShiftDireito.Checked == true)
            {
                SendKeys.Send("{^}");
                chkShiftEsquerdo.Checked = false;
                chkShiftDireito.Checked = false;
            }
            else
            {
                SendKeys.Send("{~}");
            }

        }

        private void btnBarraOuInterrogacao_Click(object sender, EventArgs e)
        {
            if (chkShiftEsquerdo.Checked == true || chkShiftDireito.Checked == true)
            {
                SendKeys.Send("{?}");
                chkShiftEsquerdo.Checked = false;
                chkShiftDireito.Checked = false;
            }
            else
            {
                SendKeys.Send("{/}");
            }

        }

        private void btnPontoEVirgulaOuDoisPontos_Click(object sender, EventArgs e)
        {
            if (chkShiftEsquerdo.Checked == true || chkShiftDireito.Checked == true)
            {
                SendKeys.Send("{:}");
                chkShiftEsquerdo.Checked = false;
                chkShiftDireito.Checked = false;
            }
            else
            {
                SendKeys.Send("{;}");
            }

        }

        private void btnPontoFinalOuSinalDeMaior_Click(object sender, EventArgs e)
        {
            if (chkShiftEsquerdo.Checked == true || chkShiftDireito.Checked == true)
            {
                SendKeys.Send("{>}");
                chkShiftEsquerdo.Checked = false;
                chkShiftDireito.Checked = false;
            }
            else
            {
                SendKeys.Send("{.}");
            }

        }

        private void btnVirgulaOuSinalDeMenor_Click(object sender, EventArgs e)
        {
            if (chkShiftEsquerdo.Checked == true || chkShiftDireito.Checked == true)
            {
                SendKeys.Send("{<}");
                chkShiftEsquerdo.Checked = false;
                chkShiftDireito.Checked = false;
            }
            else
            {
                SendKeys.Send("{,}");
            }

        }

        private void btnContraBarraOuBarraVertical_Click(object sender, EventArgs e)
        {
            if (chkShiftEsquerdo.Checked == true || chkShiftDireito.Checked == true)
            {
                SendKeys.Send("{|}");
                chkShiftEsquerdo.Checked = false;
                chkShiftDireito.Checked = false;
            }
            else
            {
                SendKeys.Send("{\\}");
            }

        }

        private void btnTab_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{TAB}");
        }
    }
}
