using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqGUIApp
{
    public partial class Form1 : Form
    {
        static private List<Product> products = new List<Product>()
        {
            new Product(){ Name = "버니 인형", Price = 48000},
            new Product(){ Name = "분홍색 형광펜", Price = 1200},
            new Product(){ Name = "르쿠르제 머그컵", Price = 25000},
            new Product(){ Name = "리콜라 캔디", Price = 2000},
            new Product(){ Name = "샌드위치 식기", Price = 50000},
            new Product(){ Name = "리본 노트", Price = 1500},
            new Product(){ Name = "네이비색 원피스", Price = 30000},
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) //화면이 불러와지기 직전
        {

        }
    }
}
