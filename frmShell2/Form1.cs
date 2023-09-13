using System;
using System.Windows.Forms;
namespace frmShell2
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Date:12/10/2023
        /// Team:Oscar David Ramoz, Emmanuel Cañas Cartagena
        ///Description: Implementation Shell
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }
        private void btnSort_Click_1(object sender, EventArgs e)
        {
          
            string[] inputNumbers = txtNumbers.Text.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            int[] numbers = new int[inputNumbers.Length];

            for (int i = 0; i < inputNumbers.Length; i++)
            {
                if (int.TryParse(inputNumbers[i], out int number))
                {
                    numbers[i] = number;
                }
                else
                {
                    MessageBox.Show("Ingrese números válidos separados por espacios o comas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            ShellSort(numbers);

          
            txtSortedNumbers.Text = string.Join(" ", numbers);
        }
        private void ShellSort(int[] arr)
        {
            int n = arr.Length;
            int gap = n / 2;

            while (gap > 0)
            {
                for (int i = gap; i < n; i++)
                {
                    int temp = arr[i];
                    int j = i;

                    while (j >= gap && arr[j - gap] > temp)
                    {
                        arr[j] = arr[j - gap];
                        j -= gap;
                    }

                    arr[j] = temp;
                }

                gap /= 2;
            }
        }

      
    }
}

