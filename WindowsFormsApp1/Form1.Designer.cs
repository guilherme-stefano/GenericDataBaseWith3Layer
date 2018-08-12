using Entity;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.add_mysql = new System.Windows.Forms.Button();
            this.add_sqlServer = new System.Windows.Forms.Button();
            this.sqlserver_txt = new System.Windows.Forms.TextBox();
            this.list_mysql = new System.Windows.Forms.ListView();
            this.list_sqlServer = new System.Windows.Forms.ListView();
            this.label_mysql = new System.Windows.Forms.Label();
            this.label_sqlserver = new System.Windows.Forms.Label();
            this.mysql_txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // add_mysql
            // 
            this.add_mysql.Location = new System.Drawing.Point(83, 85);
            this.add_mysql.Name = "add_mysql";
            this.add_mysql.Size = new System.Drawing.Size(206, 23);
            this.add_mysql.TabIndex = 0;
            this.add_mysql.Text = "Adiciona MySql";
            this.add_mysql.UseVisualStyleBackColor = true;
            this.add_mysql.Click += new System.EventHandler(this.add_mysql_Click);
            // 
            // add_sqlServer
            // 
            this.add_sqlServer.Location = new System.Drawing.Point(315, 84);
            this.add_sqlServer.Name = "add_sqlServer";
            this.add_sqlServer.Size = new System.Drawing.Size(206, 23);
            this.add_sqlServer.TabIndex = 2;
            this.add_sqlServer.Text = "Adiciona SqlServer";
            this.add_sqlServer.UseVisualStyleBackColor = true;
            this.add_sqlServer.Click += new System.EventHandler(this.add_sqlServer_Click);
            // 
            // sqlserver_txt
            // 
            this.sqlserver_txt.Location = new System.Drawing.Point(315, 58);
            this.sqlserver_txt.Name = "sqlserver_txt";
            this.sqlserver_txt.Size = new System.Drawing.Size(206, 20);
            this.sqlserver_txt.TabIndex = 5;
            // 
            // list_mysql
            // 
            this.list_mysql.Location = new System.Drawing.Point(83, 114);
            this.list_mysql.Name = "list_mysql";
            this.list_mysql.Size = new System.Drawing.Size(206, 212);
            this.list_mysql.TabIndex = 6;
            this.list_mysql.UseCompatibleStateImageBehavior = false;
            this.list_mysql.View = System.Windows.Forms.View.List;
            // 
            // list_sqlServer
            // 
            this.list_sqlServer.Location = new System.Drawing.Point(315, 113);
            this.list_sqlServer.Name = "list_sqlServer";
            this.list_sqlServer.Size = new System.Drawing.Size(206, 213);
            this.list_sqlServer.TabIndex = 7;
            this.list_sqlServer.UseCompatibleStateImageBehavior = false;
            this.list_sqlServer.View = System.Windows.Forms.View.List;
            // 
            // label_mysql
            // 
            this.label_mysql.AutoSize = true;
            this.label_mysql.Location = new System.Drawing.Point(80, 35);
            this.label_mysql.Name = "label_mysql";
            this.label_mysql.Size = new System.Drawing.Size(35, 13);
            this.label_mysql.TabIndex = 8;
            this.label_mysql.Text = "Nome";
            // 
            // label_sqlserver
            // 
            this.label_sqlserver.AutoSize = true;
            this.label_sqlserver.Location = new System.Drawing.Point(312, 35);
            this.label_sqlserver.Name = "label_sqlserver";
            this.label_sqlserver.Size = new System.Drawing.Size(35, 13);
            this.label_sqlserver.TabIndex = 9;
            this.label_sqlserver.Text = "Nome";
            // 
            // mysql_txt
            // 
            this.mysql_txt.Location = new System.Drawing.Point(83, 58);
            this.mysql_txt.Name = "mysql_txt";
            this.mysql_txt.Size = new System.Drawing.Size(206, 20);
            this.mysql_txt.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 450);
            this.Controls.Add(this.label_sqlserver);
            this.Controls.Add(this.label_mysql);
            this.Controls.Add(this.list_sqlServer);
            this.Controls.Add(this.list_mysql);
            this.Controls.Add(this.sqlserver_txt);
            this.Controls.Add(this.mysql_txt);
            this.Controls.Add(this.add_sqlServer);
            this.Controls.Add(this.add_mysql);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add_mysql;
        private System.Windows.Forms.Button add_sqlServer;
        private System.Windows.Forms.TextBox sqlserver_txt;
        private System.Windows.Forms.ListView list_mysql;
        private System.Windows.Forms.ListView list_sqlServer;
        private System.Windows.Forms.Label label_mysql;
        private System.Windows.Forms.Label label_sqlserver;
        private System.Windows.Forms.TextBox mysql_txt;
    }
}

