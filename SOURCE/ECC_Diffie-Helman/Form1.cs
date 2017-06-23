using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ECC_Diffie_Helman
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Width = 312;
        }

        int Gx, Gy, module, factorA, factorB;
        bool signal = false;
        List<PointECC> BPs = new List<PointECC>();
        
        struct PointECC
        {
            public int x;
            public int y;
        }

        private int module_denominator(int denominator, int module) // denominator là mẫu số
        {
            for (int i = 1; i <= module; i++)
            {
                for (int j = 1; j <= denominator * i; j++)
                {
                    if (((denominator * i) - (module * j)) == 1)
                    {
                        return i;
                    }
                }
            }
            return 0;
        }

        private PointECC P_add_Q(int xp, int yp, int xq, int yq)
        {
            int s = 0, s_tu = 0, s_mau = 1;
            PointECC RP = new PointECC();
            s_tu = yp - yq;
            if (s_tu > module)
            {
                s_tu = s_tu % module;
            }
            s_mau = xp - xq;
            if (s_mau == 0)
            {
                signal = true;
                return RP;
            }
            if (Math.Abs(s_mau) != 1)
            {
                if (s_mau < 0)
                {
                    s_mau = - module_denominator(Math.Abs(s_mau), module);
                }
                else
                {
                    s_mau = module_denominator(Math.Abs(s_mau), module);
                }
            }
            s = (s_tu * s_mau);
            RP.x = (s*s - (xp + xq)) % module;
            if (RP.x < 0)
            {
                RP.x = module + RP.x;
            }
            RP.y = (s * (xp - RP.x) - yp) % module;
            if (RP.y < 0)
            {
                RP.y = module + RP.y;
            }
            return RP;
        }

        private PointECC PointDouble(int x, int y)
        {
            int s = 0, s_tu = 0, s_mau = 1;
            PointECC RP = new PointECC();
            s_tu = 3 * x * x + factorA;
            if (s_tu > module)
            {
                s_tu %= module;
            }
            s_mau = 2 * y;
            if (s_mau == 0)
            {
                signal = true;
                return RP;
            }
            if (Math.Abs(s_mau) != 1)
            {
                if (s_mau < 0)
                {
                    s_mau = - module_denominator(Math.Abs(s_mau), module);
                }
                else
                {
                    s_mau = module_denominator(Math.Abs(s_mau), module);
                }
            } 
            s = (s_tu * s_mau);
            if (s > module)
            {
                s %= module;
            }
            RP.x = (s * s - 2 * x) % module;
            if (RP.x < 0)
            {
                RP.x = module + RP.x;
            }
            RP.y = (s * (x - RP.x) - y) % module;
            if (RP.y < 0)
            {
                RP.y = module + RP.y;
            }
            return RP;
        }

        private List<PointECC> compute()
        {
            List<PointECC> RPs = new List<PointECC>();
            PointECC R = new PointECC();

            R.x = Gx;
            R.y = Gy;
            lsb_points.Items.Add(" G = (" + R.x.ToString() + ", " + R.y.ToString() + ")");
            RPs.Add(R);
            R = PointDouble(R.x,R.y);
            lsb_points.Items.Add("2G = (" + R.x.ToString() + ", " + R.y.ToString() + ")");
            RPs.Add(R);
            for (int i = 3; ; i++)
            {
                R = P_add_Q(R.x, R.y, Gx, Gy);
                //R.x = int.PositiveInfinity;
                if (signal)
                {
                    signal = false;
                    lsb_points.Items.Add(i.ToString() + "G = Infinity");
                    return RPs;
                }
                lsb_points.Items.Add(i.ToString() + "G = (" + R.x.ToString() + ", " + R.y.ToString() + ")");
                RPs.Add(R);
            }
        }

        bool _init()
        {
            if (txt_basepointx.Text == string.Empty || txt_basepointy.Text == string.Empty
                || txt_module.Text == string.Empty || txt_hesoa.Text == string.Empty
                || txt_hesob.Text == string.Empty)
            {
                MessageBox.Show("Empty!\nEnter a number, plz");
                return false;
            }
            if (!checkisNumber(this))
            {
                MessageBox.Show("invalid value!\nValue must be number");
                return false;
            }
            Gx = int.Parse(txt_basepointx.Text);
            Gy = int.Parse(txt_basepointy.Text);
            module = int.Parse(txt_module.Text);
            factorA = int.Parse(txt_hesoa.Text);
            factorB = int.Parse(txt_hesob.Text);

            label_a.Text = txt_hesoa.Text;
            label_b.Text = txt_hesob.Text;
            return true;
        }

        private async void simulation(int prB, int prA, int numberofBPs, int time)
        {
            //bob picks
            await Task.Delay(time);
            label_bobpicks.Visible = true;
            label_privatekeyb.Text = "b = " + txt_privatekeyBob.Text;
            await Task.Delay(time - 200);
            label_privatekeyb.Visible = true;

            //alice picks
            await Task.Delay(time);
            label_privatekeya.Text = "a = " + txt_privatekeyAlice.Text;
            label_alicepicks.Visible = true;
            await Task.Delay(time - 200);
            label_privatekeya.Visible = true;

            //computes bob
            await Task.Delay(time);
            label_computesB.Visible = true;
            label_computesBetaBasePoint.Text = "B = " + txt_privatekeyBob.Text + "G = (" + BPs[prB - 1].x.ToString() + ", " + BPs[prB - 1].y.ToString() + ")";
            await Task.Delay(time - 200);
            label_computesBetaBasePoint.Visible = true;

            //computes Alice
            await Task.Delay(time);
            label_computesA.Visible = true;
            label_computesAlphaBasePoint.Text = "A = " + txt_privatekeyAlice.Text + "G = (" + BPs[prA - 1].x.ToString() + ", " + BPs[prA - 1].y.ToString() + ")";
            await Task.Delay(time - 200);
            label_computesAlphaBasePoint.Visible = true;

            //receives bob
            await Task.Delay(time);
            label_receivesb.Visible = true;
            label_receivesfromA.Text = label_computesAlphaBasePoint.Text.Remove(1, txt_privatekeyAlice.Text.Length + 4);
            await Task.Delay(time - 200);
            label_receivesfromA.Visible = true;

            //receives alice
            await Task.Delay(time);
            label_receivesa.Visible = true;
            label_receivesfromB.Text = label_computesBetaBasePoint.Text.Remove(1, txt_privatekeyAlice.Text.Length + 4);
            await Task.Delay(time - 200);
            label_receivesfromB.Visible = true;

            //secret bob
            int var1 = prA*prB;
            int var2 = var1 % numberofBPs;
            await Task.Delay(time);
            label_computesSecretb.Visible = true;
            label_secretkeyb1.Text = "bA = " + txt_privatekeyBob.Text + "A = " + txt_privatekeyBob.Text + "(" + txt_privatekeyAlice.Text + "G) ";
            label_secretkeyb2.Text = "= ";
            if (var1 < numberofBPs)
            {
                label_secretkeyb2.Text += var1 + "G = (" + BPs[var1 - 1].x.ToString() + ", " + BPs[var1 - 1].y.ToString() + ")";
            }
            else
            {
                label_secretkeyb2.Text += var1 + "G = " + var2 + "G = (" + BPs[var2 - 1].x.ToString() + ", " + BPs[var2 - 1].y.ToString() + ")";
            }
            await Task.Delay(time - 200);
            label_secretkeyb1.Visible = true;
            label_secretkeyb2.Visible = true;

            //secret alice
            await Task.Delay(time);
            label_computesSecreta.Visible = true;
            label_secretkeya1.Text = "aB = " + txt_privatekeyAlice.Text + "B = " + txt_privatekeyAlice.Text + "(" + txt_privatekeyBob.Text + "G)";
            label_secretkeya2.Text = "= ";
            if (var1 < numberofBPs)
            {
                label_secretkeya2.Text += var1 + "G = (" + BPs[var1 - 1].x.ToString() + ", " + BPs[var1 - 1].y.ToString() + ")";
            }
            else
            {
                label_secretkeya2.Text += var1 + "G = " + var2 + "G = (" + BPs[var2 - 1].x.ToString() + ", " + BPs[var2 - 1].y.ToString() + ")";
            }
            await Task.Delay(time - 200);
            label_secretkeya1.Visible = true;
            label_secretkeya2.Visible = true;
            
        }

        void ClearAllText(Control con)
        {
            foreach (Control c in con.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
                else
                {
                    ClearAllText(c);
                }
            }
        }

        void hidden_simulation()
        {
            label_alicepicks.Visible = false;
            label_bobpicks.Visible = false;
            label_privatekeya.Visible = false;
            label_privatekeyb.Visible = false;
            label_computesA.Visible = false;
            label_computesB.Visible = false;
            label_computesBetaBasePoint.Visible = false;
            label_computesAlphaBasePoint.Visible = false;
            label_receivesa.Visible = false;
            label_receivesb.Visible = false;
            label_receivesfromA.Visible = false;
            label_receivesfromB.Visible = false;
            label_computesSecreta.Visible = false;
            label_computesSecretb.Visible = false;
            label_secretkeya1.Visible = false;
            label_secretkeya2.Visible = false;
            label_secretkeyb1.Visible = false;
            label_secretkeyb2.Visible = false;
        }

        bool checkisNumber(Control con)
        {
            int n = 0;
            if (!int.TryParse(txt_hesoa.Text, out n))
            {
                return false;
            }
            if (!int.TryParse(txt_hesob.Text, out n))
            {
                return false;
            }
            if (!int.TryParse(txt_module.Text, out n))
            {
                return false;
            }
            if (!int.TryParse(txt_basepointx.Text, out n))
            {
                return false;
            }
            if (!int.TryParse(txt_basepointy.Text, out n))
            {
                return false;
            }
            return true;
        }

        private void btn_compute_Click(object sender, EventArgs e)
        {
            if (!_init())
            {
                return;
            }
            txt_hesoa.Enabled = false;
            txt_hesob.Enabled = false;
            txt_module.Enabled = false;
            txt_basepointx.Enabled = false;
            txt_basepointy.Enabled = false;
            if (!BPs.Any())
            {
                BPs = compute();
            }
        }

        private void btn_simulation_Click(object sender, EventArgs e)
        {
            int n = 0;
            if (!_init())
            {
                return;
            }
            txt_hesoa.Enabled = false;
            txt_hesob.Enabled = false;
            txt_module.Enabled = false;
            txt_basepointx.Enabled = false;
            txt_basepointy.Enabled = false;
            if (!BPs.Any())
            {
                BPs = compute();
            }
            int numberofBPs = BPs.Count + 1; // tính cả infinity
            if (txt_privatekeyAlice.Text == string.Empty || txt_privatekeyBob.Text == string.Empty)
            {
                MessageBox.Show("Empty!\nEnter a number, plz");
                return;
            }
            if (!int.TryParse(txt_privatekeyAlice.Text, out n))
            {
                MessageBox.Show("invalid value!\nValue must be number");
                return;
            }
            if (!int.TryParse(txt_privatekeyBob.Text, out n))
            {
                MessageBox.Show("invalid value!\nValue must be number");
                return;
            }
            int privatekeyBob = int.Parse(txt_privatekeyBob.Text);
            int privatekeyAlice = int.Parse(txt_privatekeyAlice.Text);
            if (privatekeyBob > numberofBPs || privatekeyAlice > numberofBPs || privatekeyBob < 0 || privatekeyAlice < 0)
            {
                MessageBox.Show("invalid value\n0 >= value <= " + numberofBPs.ToString());
                return;
            }
            txt_privatekeyAlice.Enabled = false;
            txt_privatekeyBob.Enabled = false;
            this.Width = 887;
            simulation(privatekeyBob, privatekeyAlice, numberofBPs, 850);
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            this.Width = 312;
            label_a.Text = "a";
            label_b.Text = "b";
            ClearAllText(this);
            lsb_points.Items.Clear();
            foreach(var clear in BPs.OfType<IDisposable>())
            {
                clear.Dispose();
            }
            hidden_simulation();
            txt_hesoa.Enabled = true;
            txt_hesob.Enabled = true;
            txt_module.Enabled = true;
            txt_basepointx.Enabled = true;
            txt_basepointy.Enabled = true;
            txt_privatekeyAlice.Enabled = true;
            txt_privatekeyBob.Enabled = true;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }    
    }
}
