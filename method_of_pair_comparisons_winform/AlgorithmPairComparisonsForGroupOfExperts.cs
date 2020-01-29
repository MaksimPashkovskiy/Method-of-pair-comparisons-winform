using System;
using System.Windows.Forms;

namespace method_of_pair_comparisons_winform
{
    class AlgorithmPairComparisonsForGroupOfExperts
    {
        private Double[] alternativeEvaluations = null;
        private Double[] alternativeWeight = null;
        private Double sumAlternativeEvaluations = 0;

        public double[] AlternativeEvaluations { get => alternativeEvaluations; set => alternativeEvaluations = value; }
        public double[] AlternativeWeight { get => alternativeWeight; set => alternativeWeight = value; }
        public double SumAlternativeEvaluations { get => sumAlternativeEvaluations; set => sumAlternativeEvaluations = value; }

        public AlgorithmPairComparisonsForGroupOfExperts(DataGridView dataGrid)
        {
            try
            {
                alternativeEvaluations = GetAlternativeEvaluations(dataGrid);
                sumAlternativeEvaluations = GetSumAlternativeEvaluations(alternativeEvaluations);
                alternativeWeight = GetAlternativeWeight(alternativeEvaluations, sumAlternativeEvaluations);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private Double[] CalcAlternativeEvaluations(DataGridView dataGrid)
        {
            Double[] result = new Double[dataGrid.RowCount];
            for (Int32 i = 0; i < dataGrid.RowCount; ++i)
            {
                for (Int32 j = 0; j < dataGrid.ColumnCount; ++j)
                {
                    result[i] += Convert.ToDouble(dataGrid.Rows[i].Cells[j].Value);
                }
            }
            return result;
        }

        private Double[] GetAlternativeEvaluations(DataGridView dataGrid)
        {
            Double[] result = new Double[dataGrid.RowCount];
            try
            {
                result = CalcAlternativeEvaluations(dataGrid);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return result;
        }

        private Double[] GetAlternativeWeight(Double[] alternatives, Double sum)
        {
            Double[] result = new Double[alternatives.Length];
            try
            {
                for (Int32 i = 0; i < alternatives.Length; ++i)
                {
                    result[i] = alternatives[i] / sum;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return result;
        }

        private Double GetSumAlternativeEvaluations(Double[] alternatives)
        {
            Double result = 0;
            try
            {
                for (Int32 i = 0; i < alternatives.Length; ++i)
                {
                    result += alternatives[i];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return result;
        }
    }
}