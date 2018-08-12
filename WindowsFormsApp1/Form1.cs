using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void add_mysql_Click(object sender, EventArgs e)
        {
            string name = this.mysql_txt.Text;
            PessoaBLL pessoaBll = new PessoaBLL(DAL.Type.Base.MySql);
            Pessoa pessoa = new Pessoa();
            pessoa.Name = name;
            pessoaBll.insert(pessoa);

            List<Pessoa> pessoas = new List<Pessoa>();
            pessoas = pessoaBll.getAll();
            this.list_mysql.Items.Clear();
            foreach (Pessoa pessoaNode in pessoas)
            {
                ListViewItem listViewItem1 = new ListViewItem();
                listViewItem1.Text = pessoaNode.Name;
                this.list_mysql.Items.Add(listViewItem1);
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Pessoa> pessoas = new List<Pessoa>();
            PessoaBLL pessoaBllSqlMySql = new PessoaBLL(DAL.Type.Base.MySql);
            pessoas = pessoaBllSqlMySql.getAll();
            foreach (Pessoa pessoaNode in pessoas)
            {
                ListViewItem listViewItem1 = new ListViewItem();
                listViewItem1.Text = pessoaNode.Name;
                this.list_mysql.Items.Add(listViewItem1);
            }

            List<Pessoa> pessoasSqlServer = new List<Pessoa>();
            PessoaBLL pessoaBllSqlServer = new PessoaBLL(DAL.Type.Base.SqlServer);
            pessoas = pessoaBllSqlServer.getAll();
            foreach (Pessoa pessoaNode in pessoas)
            {
                ListViewItem listViewItem1 = new ListViewItem();
                listViewItem1.Text = pessoaNode.Name;
                this.list_sqlServer.Items.Add(listViewItem1);
            }
        }

        private void add_sqlServer_Click(object sender, EventArgs e)
        {
            string name = this.sqlserver_txt.Text;
            PessoaBLL pessoaBll = new PessoaBLL(DAL.Type.Base.SqlServer);
            Pessoa pessoa = new Pessoa();
            pessoa.Name = name;
            pessoaBll.insert(pessoa);

            List<Pessoa> pessoas = new List<Pessoa>();
            pessoas = pessoaBll.getAll();
            this.list_sqlServer.Items.Clear();
            foreach (Pessoa pessoaNode in pessoas)
            {
                ListViewItem listViewItem1 = new ListViewItem();
                listViewItem1.Text = pessoaNode.Name;
                this.list_sqlServer.Items.Add(listViewItem1);
            }
        }
    }
}
