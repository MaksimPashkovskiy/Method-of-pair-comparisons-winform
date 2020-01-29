using System;
using System.Windows.Forms;

namespace method_of_pair_comparisons_winform
{
    public partial class MethodOfPairComparisons : Form
    {
        InputCountOfExpertsForm inputCountOfExpertsForm = null;

        private const Int32 COUNT_OF_ALTERNATIVES = 4;

        private Int32 countOfExperts = 0;
        private Int32 columns = 0;
        private Int32 rows = 0;

        private Object NewLine = Environment.NewLine;

        private Double sumAlternativeEvaluations = 0;
        private Double[] alternativeEvaluations = null;
        private Double[] alternativeWeight = null;

        private Boolean isValideVerification = false;
        private Double additionalValue = 0;
        private Double consistencyIndex = 0;
        private Double consistencyRelation = 0;
        private Double[] columnSum = null;

        public MethodOfPairComparisons()
        {
            InitializeComponent();
        }

        private void BtnStartExpertsPoll_Click(object sender, EventArgs e)
        {
            try
            {
                ChangeEnabled();
                countOfExperts = GetCountOfExperts();
                columns = countOfExperts * COUNT_OF_ALTERNATIVES;
                rows = COUNT_OF_ALTERNATIVES;
                CreateGrid(dgvComparisonMatrix, rows, columns);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            try
            {
                ChangeEnabled();
                ResetAllData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnEndExpertsPoll_Click(object sender, EventArgs e)
        {
            try
            {
                alternativeEvaluations = new Double[dgvComparisonMatrix.RowCount];
                alternativeWeight = new Double[dgvComparisonMatrix.RowCount];

                if (countOfExperts == 1)
                {
                    CallAlgorithmSaati(dgvComparisonMatrix);
                }
                if (countOfExperts > 1)
                {
                    CallMethodOfPairComparisons(dgvComparisonMatrix);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                ChangeEnabled();
                ResetAllData();
            }
        }

        private void CleanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetAllData();
            tbOutput.Clear();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MethodOfPairComparisons_Load(object sender, EventArgs e)
        {
            SetTextCondition();
        }
    }
}