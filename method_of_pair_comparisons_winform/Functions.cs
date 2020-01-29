using System;
using System.Windows.Forms;

namespace method_of_pair_comparisons_winform
{
    public partial class MethodOfPairComparisons : Form
    {
        private void CallAlgorithmSaati(DataGridView dataGrid)
        {
            tbOutput.AppendText("Алгоримт Саати" + NewLine);
            AlgorithmSaati algorithmSaati = new AlgorithmSaati(dataGrid);

            alternativeEvaluations = algorithmSaati.AlternativeEvaluations;
            sumAlternativeEvaluations = algorithmSaati.SumAlternativeEvaluations;
            alternativeWeight = algorithmSaati.AlternativeWeight;

            columnSum = algorithmSaati.ColumnSum;
            additionalValue = algorithmSaati.AdditionalValue;
            consistencyIndex = algorithmSaati.ConsistencyIndex;
            consistencyRelation = algorithmSaati.ConsistencyRelation;
            isValideVerification = algorithmSaati.IsValideVerification;

            CallAlgorithmSaatiOutputReport();
        }

        private void CallAlgorithmSaatiOutputReport()
        {
            OutputComparisonMatrix();
            OutputAlternativeEvaluations();
            OutputSumAlternativeEvaluations();
            OutputAlternativeWeight();
            OutputColumnSum();
            OutputAdditionalValue();
            OutputConsistencyIndex();
            OutputConsistencyRelation();
            OutputIsValideVerification();
        }

        private void CallMethodOfPairComparisons(DataGridView dataGrid)
        {
            tbOutput.AppendText("Алгоритм парных сравнений для группы экспертов" + NewLine);
            AlgorithmPairComparisonsForGroupOfExperts methodPairComparisons = new AlgorithmPairComparisonsForGroupOfExperts(dataGrid);

            alternativeEvaluations = methodPairComparisons.AlternativeEvaluations;
            sumAlternativeEvaluations = methodPairComparisons.SumAlternativeEvaluations;
            alternativeWeight = methodPairComparisons.AlternativeWeight;

            CallMethodOfPairComparisonsOutputReport();
        }

        private void CallMethodOfPairComparisonsOutputReport()
        {
            OutputComparisonMatrix();
            OutputAlternativeEvaluations();
            OutputSumAlternativeEvaluations();
            OutputAlternativeWeight();
        }

        private void ChangeElementsEnabled(Control control)
        {
            control.Enabled = !control.Enabled;
        }

        private void ChangeEnabled()
        {
            ChangeElementsEnabled(btnStartExpertsPoll);
            ChangeElementsEnabled(btnEndExpertsPoll);
            ChangeElementsEnabled(btnReset);
            ChangeElementsEnabled(dgvComparisonMatrix);
        }

        private void CreateGrid(DataGridView dataGrid, Int32 row, Int32 col)
        {
            for (int i = 0; i < col; ++i)
            {
                dataGrid.Columns.Add(new DataGridViewTextBoxColumn());
            }

            for (int i = 0; i < row; ++i)
            {
                dataGrid.Rows.Add();
            }
        }

        private Int32 GetCountOfExperts()
        {
            Int32 result = 0;
            inputCountOfExpertsForm = new InputCountOfExpertsForm();
            ShowForm(inputCountOfExpertsForm);
            result = inputCountOfExpertsForm.CountOfExperts;
            return result;
        }

        private void OutputAdditionalValue()
        {
            tbOutput.AppendText("Вспомогательная величина L:" + NewLine);
            tbOutput.AppendText(additionalValue.ToString() + NewLine);
        }

        private void OutputAlternativeEvaluations()
        {
            // Цены альтернатив
            tbOutput.AppendText("Цены альтернатив:" + NewLine);
            for (Int32 i = 0; i < dgvComparisonMatrix.RowCount; ++i)
            {
                tbOutput.AppendText("Альтернатива № " + (i + 1) + ": " + alternativeEvaluations[i].ToString() + NewLine);
            }
        }

        private void OutputAlternativeWeight()
        {
            // Вес альтернатив
            tbOutput.AppendText("Вес альтернатив:" + NewLine);
            for (Int32 i = 0; i < dgvComparisonMatrix.RowCount; ++i)
            {
                tbOutput.AppendText("Альтернатива № " + (i + 1) + ": " + alternativeWeight[i].ToString() + NewLine);
            }
        }

        private void OutputComparisonMatrix()
        {
            // Вывод матрицы сравнений
            tbOutput.AppendText("Матрица сравнений:" + NewLine);
            ReadGrid(dgvComparisonMatrix, tbOutput);
        }

        private void OutputColumnSum()
        {
            tbOutput.AppendText("Сумма строк:" + NewLine);
            for (Int32 i = 0; i < dgvComparisonMatrix.ColumnCount; ++i)
            {
                tbOutput.AppendText("Строка № " + (i + 1) + ": " + columnSum[i].ToString() + NewLine);
            }
        }

        private void OutputConsistencyIndex()
        {
            tbOutput.AppendText("Индекс согласованности:" + NewLine);
            tbOutput.AppendText(consistencyIndex.ToString() + NewLine);
        }

        private void OutputConsistencyRelation()
        {
            tbOutput.AppendText("Отношение согласованности:" + NewLine);
            tbOutput.AppendText(consistencyRelation.ToString() + NewLine);
        }

        private void OutputIsValideVerification()
        {
            if (isValideVerification)
            {
                tbOutput.AppendText("Поскольку отношение согласованности не превышает 0.2, то уточнение матрицы не требуется" + NewLine);
            }
            if (!isValideVerification)
            {
                tbOutput.AppendText("Поскольку отношение согласованности превышает 0.2, то уточнение матрицы требуется" + NewLine);
            }
        }

        private void OutputSumAlternativeEvaluations()
        {
            // Сумма цен альтернатив
            tbOutput.AppendText("Сумма цен альтернатив:" + NewLine);
            tbOutput.AppendText(sumAlternativeEvaluations.ToString() + NewLine);
        }

        private void ReadGrid(DataGridView dataGrid, TextBox textBox)
        {
            for (Int32 i = 0; i < dataGrid.RowCount; ++i)
            {
                for (Int32 j = 0; j < dataGrid.ColumnCount; ++j)
                {
                    textBox.AppendText(String.Format("{0}\t", dataGrid.Rows[i].Cells[j].Value));
                }
                textBox.AppendText(NewLine.ToString());
            }
        }

        private void Reset(Object obj)
        {
            if ((obj is Int32) || (obj is Double))
                obj = 0;
        }

        private void ResetAllData()
        {
            ResetGrid(dgvComparisonMatrix);
            Reset(countOfExperts);
        }

        private void ResetGrid(DataGridView dataGrid)
        {
            while (dataGrid.Columns.GetColumnCount(0) != 0)
                dataGrid.Columns.RemoveAt(0);

            while (dataGrid.Rows.GetRowCount(0) != 0)
                dataGrid.Rows.RemoveAt(0);
        }

        private void SetTextCondition()
        {
            tbTextCondition.Text = "Вариант 13" + NewLine +
                "Иностранная фирма инвестировала деньги предприятию." + NewLine +
                "Руководство предприятия собрало группу экспертов для выбора наилучшего варианта:" + NewLine +
                "1. Вложить деньги в рекламу продукции;" + NewLine +
                "2. Закупить новую технику;" + NewLine +
                "3. Отремонтировать износившееся оборудование;" + NewLine +
                "4. Повысить зарплату руководящему составу.";
        }

        private void ShowForm(Form form)
        {
            form.ShowDialog();
        }
    }
}