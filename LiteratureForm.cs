using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trial1KayPro
{
    public partial class LiteratureForm : Form
    {
        public LiteratureForm()
        {
            InitializeComponent();
            this.axAcroPDF1.LoadFile("journal.pdf");
        }
    }
}
