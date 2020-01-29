using System;
using System.Windows.Forms;

namespace method_of_pair_comparisons_winform
{
    class AlgorithmSaati
    {
        private Boolean isValideVerification = false;
        private Double[] alternativeEvaluations = null;
        private Double[] alternativeWeight = null;
        private Double sumAlternativeEvaluations = 0;

        private Double additionalValue = 0;
        private Double consistencyIndex = 0;
        private Double consistencyRelation = 0;
        private Double[] columnSum = null;

        public Boolean IsValideVerification { get => isValideVerification; set => isValideVerification = value; }
        public Double[] AlternativeEvaluations { get => alternativeEvaluations; set => alternativeEvaluations = value; }
        public Double[] AlternativeWeight { get => alternativeWeight; set => alternativeWeight = value; }
        public Double SumAlternativeEvaluations { get => sumAlternativeEvaluations; set => sumAlternativeEvaluations = value; }

        public Double AdditionalValue { get => additionalValue; set => additionalValue = value; }
        public Double ConsistencyIndex { get => consistencyIndex; set => consistencyIndex = value; }
        public Double ConsistencyRelation { get => consistencyRelation; set => consistencyRelation = value; }
        public Double[] ColumnSum { get => columnSum; set => columnSum = value; }

        public AlgorithmSaati(DataGridView dataGrid)
        {
            try
            {
                alternativeEvaluations = GetAlternativeEvaluations(dataGrid);
                sumAlternativeEvaluations = GetSumAlternativeEvaluations(alternativeEvaluations);
                alternativeWeight = GetAlternativeWeight(alternativeEvaluations, sumAlternativeEvaluations);

                columnSum = CalcColumnsSum(dataGrid);
                additionalValue = GetAdditionalValue(columnSum, alternativeWeight);
                consistencyIndex = GetConsistencyIndex(additionalValue, dataGrid.RowCount);
                consistencyRelation = GetConsistencyRelation(consistencyIndex);
                isValideVerification = VerificationOfExpertEvaluations(dataGrid);
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
                result[i] = 1;
                for (Int32 j = 0; j < dataGrid.ColumnCount; ++j)
                {
                    result[i] *= Convert.ToDouble(dataGrid.Rows[i].Cells[j].Value);
                }
            }
            return result;
        }

        private Double[] CalcColumnsSum(DataGridView dataGrid)
        {
            Double[] result = new Double[dataGrid.ColumnCount];
            for (Int32 i = 0; i < dataGrid.RowCount; ++i)
            {
                for (Int32 j = 0; j < dataGrid.ColumnCount; ++j)
                {
                    result[i] += Convert.ToDouble(dataGrid.Rows[j].Cells[i].Value);
                }
            }
            return result;
        }

        private Double GetAdditionalValue(Double[] columnSum, Double[] alternativeWeight)
        {
            Double result = 0;
            for (Int32 i = 0; i < columnSum.Length; ++i)
            {
                result += columnSum[i] * alternativeWeight[i];
            }
            return result;
        }

        private Double[] GetAlternativeEvaluations(DataGridView dataGrid)
        {
            Double[] result = new Double[dataGrid.RowCount];
            try
            {
                result = CalcAlternativeEvaluations(dataGrid);
                result = ExtractTheRoot(result, dataGrid.ColumnCount);
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

        private Double GetConsistencyIndex(Double additionalValue, Double size)
        {
            Double result = 0;
            result = (additionalValue - size) / (size - 1);
            return result;
        }

        private Double GetConsistencyRelation(Double consistencyIndex)
        {
            Double result = 0;
            result = consistencyIndex / 0.9;
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

        private Double[] ExtractTheRoot(Double[] root, Int32 degree)
        {
            Double[] result = new Double[root.Length];
            for (Int32 i = 0; i < root.Length; ++i)
            {
                result[i] = Math.Pow(root[i], 1.0 / degree);
            }
            return result;
        }

        private Boolean VerificationOfExpertEvaluations(DataGridView dataGrid)
        {
            Boolean result = false;
            if (consistencyRelation < 0.2)
            {
                result = true;
            }
            return result;
        }
    }
}