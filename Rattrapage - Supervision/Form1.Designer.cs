using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Net.Sockets;

namespace Rattrapage___Supervision
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.label65 = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.label67 = new System.Windows.Forms.Label();
            this.label68 = new System.Windows.Forms.Label();
            this.label69 = new System.Windows.Forms.Label();
            this.label70 = new System.Windows.Forms.Label();
            this.label71 = new System.Windows.Forms.Label();
            this.label72 = new System.Windows.Forms.Label();
            this.label73 = new System.Windows.Forms.Label();
            this.label74 = new System.Windows.Forms.Label();
            this.label75 = new System.Windows.Forms.Label();
            this.label76 = new System.Windows.Forms.Label();
            this.label77 = new System.Windows.Forms.Label();
            this.label78 = new System.Windows.Forms.Label();
            this.label79 = new System.Windows.Forms.Label();
            this.label80 = new System.Windows.Forms.Label();
            this.label81 = new System.Windows.Forms.Label();
            this.label82 = new System.Windows.Forms.Label();
            this.label83 = new System.Windows.Forms.Label();
            this.label84 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Table 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Table 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Table 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Table 4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Table 5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(62, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Table 6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(62, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Table 7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(62, 301);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Table 8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(62, 340);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Table 9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(62, 378);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "Table 10";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(62, 417);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 17);
            this.label11.TabIndex = 10;
            this.label11.Text = "Table 11";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(62, 456);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 17);
            this.label12.TabIndex = 11;
            this.label12.Text = "Table 12";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(62, 494);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 17);
            this.label13.TabIndex = 12;
            this.label13.Text = "Table 13";
            this.label13.Click += new System.EventHandler(this.Label13_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(62, 529);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 17);
            this.label14.TabIndex = 13;
            this.label14.Text = "Table 14";

            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(891, 107);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(36, 17);
            this.label17.TabIndex = 16;
            this.label17.Text = "Riz :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(891, 147);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(52, 17);
            this.label18.TabIndex = 17;
            this.label18.Text = "Pates :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(890, 186);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(57, 17);
            this.label19.TabIndex = 18;
            this.label19.Text = "Crème :";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(890, 225);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(71, 17);
            this.label20.TabIndex = 19;
            this.label20.Text = "Tomates :";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(891, 264);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(89, 17);
            this.label21.TabIndex = 20;
            this.label21.Text = "Mozzarella :";
            this.label21.Click += new System.EventHandler(this.Label21_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(890, 301);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(56, 17);
            this.label22.TabIndex = 21;
            this.label22.Text = "Poulet :";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(891, 340);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(53, 17);
            this.label23.TabIndex = 22;
            this.label23.Text = "Boeuf :";
            this.label23.Click += new System.EventHandler(this.Label23_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(891, 378);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(44, 17);
            this.label24.TabIndex = 23;
            this.label24.Text = "Pain :";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(891, 417);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(71, 17);
            this.label25.TabIndex = 24;
            this.label25.Text = "Chocolat :";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(891, 456);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(58, 17);
            this.label26.TabIndex = 25;
            this.label26.Text = "Vanille :";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(891, 494);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(54, 17);
            this.label27.TabIndex = 26;
            this.label27.Text = "Oeufs :";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(891, 529);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(103, 17);
            this.label28.TabIndex = 27;
            this.label28.Text = "Sauce tomate :";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(193, 32);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(54, 17);
            this.label29.TabIndex = 28;
            if (Listener.dataReceived?.Any() != false)
            {
                this.label29.Text = Listener.dataReceived[0];
            }

            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(305, 32);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(54, 17);
            this.label30.TabIndex = 29;
            if (Listener.dataReceived?.Any() != false)
            {
                this.label30.Text = Listener.dataReceived[1];
            }
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(424, 32);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(54, 17);
            this.label31.TabIndex = 30;
            if (Listener.dataReceived?.Any() != false)
            {
                this.label31.Text = Listener.dataReceived[2];
            }
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(193, 70);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(54, 17);
            this.label32.TabIndex = 31;
            if (Listener.dataReceived?.Any() != false)
            {
                this.label32.Text = Listener.dataReceived[3];
            }
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(305, 70);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(54, 17);
            this.label33.TabIndex = 32;
            if (Listener.dataReceived?.Any() != false)
            {
                this.label33.Text = Listener.dataReceived[4];
            }
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(424, 70);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(54, 17);
            this.label34.TabIndex = 33;
            if (Listener.dataReceived?.Any() != false)
            {
                this.label34.Text = Listener.dataReceived[5];
            }
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(193, 107);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(54, 17);
            this.label35.TabIndex = 34;
            if (Listener.dataReceived?.Any() != false)
            {
                this.label35.Text = Listener.dataReceived[6];
            }
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(193, 147);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(54, 17);
            this.label36.TabIndex = 35;
            if (Listener.dataReceived?.Any() != false)
            {
                this.label36.Text = Listener.dataReceived[9];
            }
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(193, 186);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(54, 17);
            this.label37.TabIndex = 36;
            if (Listener.dataReceived?.Any() != false)
            {
                this.label37.Text = Listener.dataReceived[12];
            }
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(193, 225);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(54, 17);
            this.label38.TabIndex = 37;
            if (Listener.dataReceived?.Any() != false)
            {
                this.label38.Text = Listener.dataReceived[15];
            }
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(193, 264);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(54, 17);
            this.label39.TabIndex = 38;
            if (Listener.dataReceived?.Any() != false)
            {
                this.label39.Text = Listener.dataReceived[18];
            }
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(193, 301);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(54, 17);
            this.label40.TabIndex = 39;
            if (Listener.dataReceived?.Any() != false)
            {
                this.label40.Text = Listener.dataReceived[21];
            }
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(193, 340);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(54, 17);
            this.label41.TabIndex = 40;
            if (Listener.dataReceived?.Any() != false)
            {
                this.label41.Text = Listener.dataReceived[24];
            }
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(193, 378);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(54, 17);
            this.label42.TabIndex = 41;
            if (Listener.dataReceived?.Any() != false)
            {
                this.label42.Text = Listener.dataReceived[27];
            }
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(193, 417);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(54, 17);
            this.label43.TabIndex = 42;
            if (Listener.dataReceived?.Any() != false)
            {
                this.label43.Text = Listener.dataReceived[30];
            }
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(193, 456);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(54, 17);
            this.label44.TabIndex = 43;
            if (Listener.dataReceived?.Any() != false)
            {
                this.label44.Text = Listener.dataReceived[33];
            }
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(193, 494);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(54, 17);
            this.label45.TabIndex = 44;
            if (Listener.dataReceived?.Any() != false)
            {
                this.label45.Text = Listener.dataReceived[36];
            }
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(193, 529);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(54, 17);
            this.label46.TabIndex = 45;
            if (Listener.dataReceived?.Any() != false)
            {
                this.label46.Text = Listener.dataReceived[39];
            }
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(305, 107);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(54, 17);
            this.label47.TabIndex = 46;
            if (Listener.dataReceived?.Any() != false)
            {
                this.label47.Text = Listener.dataReceived[7];
            }
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(305, 147);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(54, 17);
            this.label48.TabIndex = 47;
            if (Listener.dataReceived?.Any() != false)
            {
                this.label48.Text = Listener.dataReceived[10];
            }
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(305, 186);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(54, 17);
            this.label49.TabIndex = 48;
            if (Listener.dataReceived?.Any() != false)
            {
                this.label49.Text = Listener.dataReceived[13];
            }
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(305, 225);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(54, 17);
            this.label50.TabIndex = 49;
            if (Listener.dataReceived?.Any() != false)
            {
                this.label50.Text = Listener.dataReceived[16];
            }
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(305, 264);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(54, 17);
            this.label51.TabIndex = 50;
            if (Listener.dataReceived?.Any() != false)
            {
                this.label51.Text = Listener.dataReceived[19];
            }
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(305, 301);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(54, 17);
            this.label52.TabIndex = 51;
            if (Listener.dataReceived?.Any() != false)
            {
                this.label52.Text = Listener.dataReceived[22];
            }
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(305, 340);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(54, 17);
            this.label53.TabIndex = 52;
            if (Listener.dataReceived?.Any() != false)
            {
                this.label53.Text = Listener.dataReceived[25];
            }
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(305, 378);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(54, 17);
            this.label54.TabIndex = 53;
            if (Listener.dataReceived?.Any() != false)
            {
                this.label54.Text = Listener.dataReceived[28];
            }
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(305, 417);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(54, 17);
            this.label55.TabIndex = 54;
            if (Listener.dataReceived?.Any() != false)
            {
                this.label55.Text = Listener.dataReceived[31];
            }
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(305, 456);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(54, 17);
            this.label56.TabIndex = 55;
            if (Listener.dataReceived?.Any() != false)
            {
                this.label56.Text = Listener.dataReceived[34];
            }
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(305, 494);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(54, 17);
            this.label57.TabIndex = 56;
            if (Listener.dataReceived?.Any() != false)
            {
                this.label57.Text = Listener.dataReceived[37];
            }
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(305, 529);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(54, 17);
            this.label58.TabIndex = 57;
            if (Listener.dataReceived?.Any() != false)
            {
                this.label58.Text = Listener.dataReceived[40];
            }
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(424, 107);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(54, 17);
            this.label59.TabIndex = 58;
            if (Listener.dataReceived?.Any() != false)
            {
                this.label59.Text = Listener.dataReceived[8];
            }
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(424, 147);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(54, 17);
            this.label60.TabIndex = 59;
            if (Listener.dataReceived?.Any() != false)
            {
                this.label60.Text = Listener.dataReceived[11];
            }
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(424, 186);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(54, 17);
            this.label61.TabIndex = 60;
            if (Listener.dataReceived?.Any() != false)
            {
                this.label61.Text = Listener.dataReceived[14];
            }
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Location = new System.Drawing.Point(424, 225);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(54, 17);
            this.label62.TabIndex = 61;
            if (Listener.dataReceived?.Any() != false)
            {
                this.label62.Text = Listener.dataReceived[17];
            }
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Location = new System.Drawing.Point(424, 264);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(54, 17);
            this.label63.TabIndex = 62;
            if (Listener.dataReceived?.Any() != false)
            {
                this.label63.Text = Listener.dataReceived[20];
            }
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Location = new System.Drawing.Point(424, 301);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(54, 17);
            this.label64.TabIndex = 63;
            if (Listener.dataReceived?.Any() != false)
            {
                this.label64.Text = Listener.dataReceived[23];
            }
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Location = new System.Drawing.Point(424, 340);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(54, 17);
            this.label65.TabIndex = 64;
            if (Listener.dataReceived?.Any() != false)
            {
                this.label65.Text = Listener.dataReceived[26];
            }
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Location = new System.Drawing.Point(424, 378);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(54, 17);
            this.label66.TabIndex = 65;
            if (Listener.dataReceived?.Any() != false)
            {
                this.label66.Text = Listener.dataReceived[29];
            }
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Location = new System.Drawing.Point(424, 417);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(54, 17);
            this.label67.TabIndex = 66;
            if (Listener.dataReceived?.Any() != false)
            {
                this.label67.Text = Listener.dataReceived[32];
            }
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Location = new System.Drawing.Point(424, 456);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(54, 17);
            this.label68.TabIndex = 67;
            if (Listener.dataReceived?.Any() != false)
            {
                this.label68.Text = Listener.dataReceived[35];
            }
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Location = new System.Drawing.Point(424, 494);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(54, 17);
            this.label69.TabIndex = 68;
            if (Listener.dataReceived?.Any() != false)
            {
                this.label69.Text = Listener.dataReceived[38];
            }
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Location = new System.Drawing.Point(424, 529);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(54, 17);
            this.label70.TabIndex = 69;
            if (Listener.dataReceived?.Any() != false)
            {
                this.label70.Text = Listener.dataReceived[41];
            }
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.Location = new System.Drawing.Point(934, 107);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(54, 17);
            this.label73.TabIndex = 72;
            if (Listener.dataReceived?.Any() != false)
            {
                this.label73.Text = Listener.dataReceived[44];
            }
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.Location = new System.Drawing.Point(950, 147);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(54, 17);
            this.label74.TabIndex = 73;
            if (Listener.dataReceived?.Any() != false)
            {
                this.label74.Text = Listener.dataReceived[45];
            }
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.Location = new System.Drawing.Point(954, 186);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(54, 17);
            this.label75.TabIndex = 74;
            if (Listener.dataReceived?.Any() != false)
            {
                this.label75.Text = Listener.dataReceived[46];
            }
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.Location = new System.Drawing.Point(968, 225);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(54, 17);
            this.label76.TabIndex = 75;
            if (Listener.dataReceived?.Any() != false)
            {
                this.label76.Text = Listener.dataReceived[47];
            }
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.Location = new System.Drawing.Point(987, 264);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(54, 17);
            this.label77.TabIndex = 76;
            if (Listener.dataReceived?.Any() != false)
            {
                this.label77.Text = Listener.dataReceived[48];
            }
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.Location = new System.Drawing.Point(953, 301);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(54, 17);
            this.label78.TabIndex = 77;
            if (Listener.dataReceived?.Any() != false)
            {
                this.label78.Text = Listener.dataReceived[49];
            }
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.Location = new System.Drawing.Point(951, 340);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(54, 17);
            this.label79.TabIndex = 78;
            if (Listener.dataReceived?.Any() != false)
            {
                this.label79.Text = Listener.dataReceived[50];
            }
            // 
            // label80
            // 
            this.label80.AutoSize = true;
            this.label80.Location = new System.Drawing.Point(942, 378);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(54, 17);
            this.label80.TabIndex = 79;
            if (Listener.dataReceived?.Any() != false)
            {
                this.label80.Text = Listener.dataReceived[51];
            }
            // 
            // label81
            // 
            this.label81.AutoSize = true;
            this.label81.Location = new System.Drawing.Point(969, 417);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(54, 17);
            this.label81.TabIndex = 80;
            if (Listener.dataReceived?.Any() != false)
            {
                this.label81.Text = Listener.dataReceived[52];
            }
            // 
            // label82
            // 
            this.label82.AutoSize = true;
            this.label82.Location = new System.Drawing.Point(956, 456);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(54, 17);
            this.label82.TabIndex = 81;
            if (Listener.dataReceived?.Any() != false)
            {
                this.label82.Text = Listener.dataReceived[53];
            }
            // 
            // label83
            // 
            this.label83.AutoSize = true;
            this.label83.Location = new System.Drawing.Point(952, 494);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(54, 17);
            this.label83.TabIndex = 82;
            if (Listener.dataReceived?.Any() != false)
            {
                this.label83.Text = Listener.dataReceived[54];
            }
            // 
            // label84
            // 
            this.label84.AutoSize = true;
            this.label84.Location = new System.Drawing.Point(1001, 529);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(54, 17);
            this.label84.TabIndex = 83;
            if (Listener.dataReceived?.Any() != false)
            {
                this.label84.Text = Listener.dataReceived[55];
            }
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1114, 574);
            this.Controls.Add(this.label84);
            this.Controls.Add(this.label83);
            this.Controls.Add(this.label82);
            this.Controls.Add(this.label81);
            this.Controls.Add(this.label80);
            this.Controls.Add(this.label79);
            this.Controls.Add(this.label78);
            this.Controls.Add(this.label77);
            this.Controls.Add(this.label76);
            this.Controls.Add(this.label75);
            this.Controls.Add(this.label74);
            this.Controls.Add(this.label73);
            this.Controls.Add(this.label72);
            this.Controls.Add(this.label71);
            this.Controls.Add(this.label70);
            this.Controls.Add(this.label69);
            this.Controls.Add(this.label68);
            this.Controls.Add(this.label67);
            this.Controls.Add(this.label66);
            this.Controls.Add(this.label65);
            this.Controls.Add(this.label64);
            this.Controls.Add(this.label63);
            this.Controls.Add(this.label62);
            this.Controls.Add(this.label61);
            this.Controls.Add(this.label60);
            this.Controls.Add(this.label59);
            this.Controls.Add(this.label58);
            this.Controls.Add(this.label57);
            this.Controls.Add(this.label56);
            this.Controls.Add(this.label55);
            this.Controls.Add(this.label54);
            this.Controls.Add(this.label53);
            this.Controls.Add(this.label52);
            this.Controls.Add(this.label51);
            this.Controls.Add(this.label50);
            this.Controls.Add(this.label49);
            this.Controls.Add(this.label48);
            this.Controls.Add(this.label47);
            this.Controls.Add(this.label46);
            this.Controls.Add(this.label45);
            this.Controls.Add(this.label44);
            this.Controls.Add(this.label43);
            this.Controls.Add(this.label42);
            this.Controls.Add(this.label41);
            this.Controls.Add(this.label40);
            this.Controls.Add(this.label39);
            this.Controls.Add(this.label38);
            this.Controls.Add(this.label37);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.Label label72;
        private System.Windows.Forms.Label label73;
        private System.Windows.Forms.Label label74;
        private System.Windows.Forms.Label label75;
        private System.Windows.Forms.Label label76;
        private System.Windows.Forms.Label label77;
        private System.Windows.Forms.Label label78;
        private System.Windows.Forms.Label label79;
        private System.Windows.Forms.Label label80;
        private System.Windows.Forms.Label label81;
        private System.Windows.Forms.Label label82;
        private System.Windows.Forms.Label label83;
        private System.Windows.Forms.Label label84;
    }
}

