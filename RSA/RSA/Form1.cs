﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
namespace RSA
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        KhoaCongKhai a = new KhoaCongKhai();
        KhoaBiMat b = new KhoaBiMat();
        public Form1()
        {
            InitializeComponent();
        }

        BigInteger RANDBIG()
        {
            string result = "";
            for (int i = 0; i < 30; i++)
            {
                BigInteger rand = rnd.Next(0, 9);
                result = String.Concat(result, rand.ToString());
            }
            BigInteger a = BigInteger.Parse(result);
            return a;
        }
        BigInteger gcd_extend(BigInteger a, BigInteger b, ref BigInteger x, ref BigInteger y)
        {
            if (b == 0)
            {
                x = 1;
                y = 0;
                return a;
            }
            BigInteger x1 = 0, y1 = 0;
            BigInteger gcd = gcd_extend(b, a % b, ref x1, ref y1);
            x = y1;
            y = x1 - (a / b) * y1;
            return gcd;
        }
        BigInteger modulo_inverse_euclidean(BigInteger n, BigInteger m)
        {
            BigInteger x = 0, y = 0;
            if (gcd_extend(n, m, ref x, ref y) != 1) return -1;
            return (x % m + m) % m;
        }
        int gcd(int a, int b)
        {
            if (b == 0) return a;
            return gcd(b, a % b);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ChooseBigInteger rabin = new ChooseBigInteger();
            bool Flag = false;
            BigInteger p = 0, q = 0;
            while (Flag == false)
            {
                BigInteger k = RANDBIG();
                if (rabin.miller(k) == true)
                {
                    p = k;
                    Flag = true;
                }
            }
            Flag = false;
            while (Flag == false)
            {
                BigInteger t = RANDBIG();
                if (rabin.miller(t) == true)
                {
                    q = t;
                    Flag = true;
                }
            }
            Flag = false;
            MessageBox.Show("Số p: " + p + "\n" + "Số q: " + q);
            BigInteger phi_n, n;
            BigInteger rsa_e = 2;
            while (Flag == false)
            {
                BigInteger t = rnd.Next(2, 999999);
                if (rabin.miller(t) == true)
                {
                    rsa_e = t;
                    Flag = true;
                }
            }
            phi_n = (p - 1) * (q - 1);
            n = p * q;
            BigInteger d = modulo_inverse_euclidean(rsa_e, phi_n);
            textBox3.Text = textBox3.Text = n.ToString();
            textBox5.Text = rsa_e.ToString();
            textBox6.Text = d.ToString();

            a.n = BigInteger.Parse(textBox3.Text.Trim());
            a.e = BigInteger.Parse(textBox5.Text.Trim());

            b.n = BigInteger.Parse(textBox3.Text.Trim());
            b.d = BigInteger.Parse(textBox6.Text.Trim());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RSA RSA = new RSA();
            BigInteger P = BigInteger.Parse(textBox7.Text.Trim());
            BigInteger C = RSA.MaHoaRSA(P, a);
            textBox8.Text = C.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RSA RSA = new RSA();
            BigInteger C = BigInteger.Parse(textBox7.Text.Trim());
            BigInteger P = RSA.GiaiMaRSA(C, b);
            textBox8.Text = P.ToString();
        }
    }
}