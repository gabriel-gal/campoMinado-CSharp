using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CampoMinado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TelaInicial();     //Primeira Interface, aonde o jogaro apenas vai clicar para jogar

            



        }

        private void TelaInicial()
        {
            Label lab = new Label();
            Button but = new Button();

            lab = new Label();
            lab.AutoSize = true;
            lab.Font = new System.Drawing.Font("Mongolian Baiti", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lab.Location = new System.Drawing.Point(124, 392);
            lab.Name = "label1";
            lab.Size = new System.Drawing.Size(405, 50);
            lab.TabIndex = 1;
            lab.Text = "CAMPO MINADO";
            Controls.Add(lab);

            but = new Button();
            but.Cursor = System.Windows.Forms.Cursors.Hand;
            but.Font = new System.Drawing.Font("Mongolian Baiti", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            but.Location = new System.Drawing.Point(209, 492);
            but.Name = "button2";
            but.Size = new System.Drawing.Size(227, 62);
            but.TabIndex = 2;
            but.Text = "Iniciar";
            but.UseVisualStyleBackColor = true;
            Controls.Add(but);

            but = new Button();
            but.Cursor = System.Windows.Forms.Cursors.Default;
            but.Font = new System.Drawing.Font("Mongolian Baiti", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            but.Image = global::CampoMinado.Properties.Resources.paginaInicial;
            but.Location = new System.Drawing.Point(209, 138);
            but.Name = "button1";
            but.Size = new System.Drawing.Size(227, 220);
            but.TabIndex = 3;
            but.UseVisualStyleBackColor = true;
            Controls.Add(but);

        }
    }
}
