using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Abstract;

namespace DormitoryAutomation
{
    public partial class Form1 : Form
    {
        private ISchoolService _schoolService;
        public Form1(ISchoolService schoolService)
        {
            _schoolService = schoolService;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add(_schoolService.GetAll());
        }
    }
}
