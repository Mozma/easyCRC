using System;
using System.Linq;
using System.Windows.Forms;

namespace EasyCRC
{
    public partial class MainForm : BorderlessWinForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
       
        private void btnDivide_Click(object sender, EventArgs e)
        {
            try
            {
                tbResult.Text = tbFirstPolynom.Text.getReminder(tbSecondPolynom.Text);

                lbFirstPolynom.Text = polynomToString(tbFirstPolynom.Text);
                lbSecondPolynom.Text = polynomToString(tbSecondPolynom.Text);
                lbResultPolynom.Text = polynomToString(tbResult.Text);
            }
            catch (ArithmeticException exp) 
            {
                MessageBox.Show(exp.Message, "Ошибка ввода!");
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Ошибка ввода!");
            }
               

        }

        private void tbFirstPolynom_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ( number != 48 && number != 49 && number != 8) // 1, 0, BackSpace
            {
                e.Handled = true;
            }
        }
        // Метод для красивого вывода полинома. Преобразует бинарную строку в полином.
        public string polynomToString( string arr)
        {
            // Символы степеней.
            const string SuperscriptDigits = "\u2070\u00b9\u00b2\u00b3\u2074\u2075\u2076\u2077\u2078\u2079";

            string str = "";
            for (int i = 0; i < arr.Length; i++)
            {
                if (!arr[i].Equals('0'))
                {
                    if(arr[arr.Length-i-1] >= 0 && str.Length != 0)
                    {
                        str += "+";
                    }
       
                    str += $"x{new string((arr.Length - i - 1).ToString().Select(x => SuperscriptDigits[x - '0']).ToArray())}";
       
                }

            }
            return str;
        }
    }
}
