using System;
using System.Windows.Forms;

namespace method_of_pair_comparisons_winform
{
    public partial class InputCountOfExpertsForm : Form
    {
        private Int32 countOfExperts;

        public Int32 CountOfExperts
        {
            get
            {
                return countOfExperts;
            }
            set
            {
                if (value < 1)
                {
                    throw new Exception("Количество экспертов не может быть меньше одного");
                }
                if (value > 0)
                {
                    countOfExperts = value;
                }
            }
        }

        public InputCountOfExpertsForm()
        {
            InitializeComponent();
        }

        private void BtnCansel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSetCountOfExperts_Click(object sender, EventArgs e)
        {
            try
            {
                CountOfExperts = Convert.ToInt32(tbCountOfExperts.Text);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
