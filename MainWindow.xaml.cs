using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        float firstNumber, secondNumber; // firstNumber 儲存第一個數字，secondNumber 儲存第二個數字
        int operators = -1; // 記錄選擇哪一種運算符號？0:加、1:減、2:乘、3:除、-1:重新設定

        private void btnOne_Click(object sender, RoutedEventArgs e)
        {
            if (txtNumber.Text == "0")
            {
                txtNumber.Text = "";
            }

            txtNumber.Text = txtNumber.Text + "1";
            // txtNumber.Text += "1";  // 上面和下面的寫法意思是一樣的
        }

        private void btnTwo_Click(object sender, RoutedEventArgs e)
        {
            if (txtNumber.Text == "0")
            {
                txtNumber.Text = "";
            }

            txtNumber.Text = txtNumber.Text + "2";
            // txtNumber.Text += "1";  // 上面和下面的寫法意思是一樣的
        }

        private void btnThree_Click(object sender, RoutedEventArgs e)
        {
            if (txtNumber.Text == "0")
            {
                txtNumber.Text = "";
            }

            txtNumber.Text = txtNumber.Text + "3";
            // txtNumber.Text += "1";  // 上面和下面的寫法意思是一樣的
        }

        private void btnFour_Click(object sender, RoutedEventArgs e)
        {
            if (txtNumber.Text == "0")
            {
                txtNumber.Text = "";
            }

            txtNumber.Text = txtNumber.Text + "4";
            // txtNumber.Text += "1";  // 上面和下面的寫法意思是一樣的
        }

        private void btnFive_Click(object sender, RoutedEventArgs e)
        {
            if (txtNumber.Text == "0")
            {
                txtNumber.Text = "";
            }

            txtNumber.Text = txtNumber.Text + "5";
            // txtNumber.Text += "1";  // 上面和下面的寫法意思是一樣的
        }

        private void btnSix_Click(object sender, RoutedEventArgs e)
        {
            if (txtNumber.Text == "0")
            {
                txtNumber.Text = "";
            }

            txtNumber.Text = txtNumber.Text + "6";
            // txtNumber.Text += "1";  // 上面和下面的寫法意思是一樣的
        }

        private void btnSeven_Click(object sender, RoutedEventArgs e)
        {
            if (txtNumber.Text == "0")
            {
                txtNumber.Text = "";
            }

            txtNumber.Text = txtNumber.Text + "7";
            // txtNumber.Text += "1";  // 上面和下面的寫法意思是一樣的
        }

        private void btnEight_Click(object sender, RoutedEventArgs e)
        {
            if (txtNumber.Text == "0")
            {
                txtNumber.Text = "";
            }

            txtNumber.Text = txtNumber.Text + "8";
            // txtNumber.Text += "1";  // 上面和下面的寫法意思是一樣的
        }

        private void btnNine_Click(object sender, RoutedEventArgs e)
        {
            if (txtNumber.Text == "0")
            {
                txtNumber.Text = "";
            }

            txtNumber.Text = txtNumber.Text + "9";
            // txtNumber.Text += "1";  // 上面和下面的寫法意思是一樣的
        }

        private void btnZero_Click(object sender, RoutedEventArgs e)
        {
            if (txtNumber.Text == "0")
            {
                txtNumber.Text = "";
            }

            txtNumber.Text = txtNumber.Text + "0";
            // txtNumber.Text += "1";  // 上面和下面的寫法意思是一樣的
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            firstNumber = Convert.ToSingle(txtNumber.Text);
            txtNumber.Text = "0";
            operators = 0;
        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            firstNumber = Convert.ToSingle(txtNumber.Text);
            txtNumber.Text = "0";
            operators = 1;
        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            firstNumber = Convert.ToSingle(txtNumber.Text);
            txtNumber.Text = "0";
            operators = 2; 
        }

        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {
            firstNumber = Convert.ToSingle(txtNumber.Text);
            txtNumber.Text = "0";
            operators = 3;
        }

        
    }
}
