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
            TelaInicial();     //Primeira Interface, onde o jogaro apenas vai clicar para jogar
        }

        private void Criador()      //Colocando meus creditos no programa
        {
            Label lab = new Label();
            lab.AutoSize = true;
            lab.Location = new System.Drawing.Point(514, 719);
            lab.Name = "label1";
            lab.Size = new System.Drawing.Size(143, 13);
            lab.TabIndex = 0;
            lab.Text = "Criador : Gabriel Alves Lopes";
            Controls.Add(lab);
        }

        private void TelaInicial()
        {
            Criador();

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
            but.Click += new System.EventHandler(TelaNivel);      
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

        private void TelaNivel(object sender, EventArgs e)
        {
            Controls.Clear();       //Limpar os Objetos da Tela
            Criador();

            Label lab = new Label();
            Button but = new Button();

            lab = new Label();
            lab.AutoSize = true;
            lab.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lab.Location = new System.Drawing.Point(69, 76);
            lab.Name = "label2";
            lab.Size = new System.Drawing.Size(506, 76);
            lab.TabIndex = 1;
            lab.Text = "Escolha o nivel de dificuldade\r\n do jogo:";
            lab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            Controls.Add(lab);

            lab = new Label();     
            lab.AutoSize = true;
            lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lab.Location = new System.Drawing.Point(233, 291);
            lab.Name = "label3";
            lab.Size = new System.Drawing.Size(189, 25);
            lab.TabIndex = 3;
            lab.Text = "8x8 - 10 Bombas";
            lab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            Controls.Add(lab);

            lab = new Label();
            lab.AutoSize = true;
            lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lab.Location = new System.Drawing.Point(217, 440);
            lab.Name = "label4";
            lab.Size = new System.Drawing.Size(215, 25);
            lab.TabIndex = 6;
            lab.Text = "14x14 - 40 Bombas";
            lab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            Controls.Add(lab);

            lab = new Label();
            lab.AutoSize = true;
            lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lab.Location = new System.Drawing.Point(217, 583);
            lab.Name = "label5";
            lab.Size = new System.Drawing.Size(215, 25);
            lab.TabIndex = 7;
            lab.Text = "20x20 - 99 Bombas";
            lab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            Controls.Add(lab);

            but = new Button();
            but.Cursor = System.Windows.Forms.Cursors.Hand;
            but.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            but.Location = new System.Drawing.Point(221, 226);
            but.Name = "button1";
            but.Size = new System.Drawing.Size(211, 62);
            but.TabIndex = 2;
            but.Text = "Facil";
            but.UseVisualStyleBackColor = true;
            Controls.Add(but);

            but = new Button();
            but.Cursor = System.Windows.Forms.Cursors.Hand;
            but.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            but.Location = new System.Drawing.Point(221, 375);
            but.Name = "button2";
            but.Size = new System.Drawing.Size(211, 62);
            but.TabIndex = 4;
            but.Text = "Medio";
            but.UseVisualStyleBackColor = true;
            Controls.Add(but);

            but = new Button();
            but.Cursor = System.Windows.Forms.Cursors.Hand;
            but.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            but.Location = new System.Drawing.Point(221, 518);
            but.Name = "button3";
            but.Size = new System.Drawing.Size(211, 62);
            but.TabIndex = 5;
            but.Text = "Dificil";
            but.UseVisualStyleBackColor = true;
            Controls.Add(but);
        }

        
    }
}
