using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using org.mariuszgromada.math.mxparser;

namespace Test_mXParser___Windows_App
{
    public partial class frmMain : Form
    {
        List<Function> functions = new List<Function>();
        Dictionary<string, Expression> expressions = new Dictionary<string, Expression>();
        List<Argument> arguments = new List<Argument>();
        public frmMain()
        {
            InitializeComponent();

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void lstOperators_DoubleClick(object sender, EventArgs e)
        {
            txtFormula.Text += (txtFormula.Text.Length > 0 ? " " : "") + lstOperators.SelectedItem.ToString() + (lstOperators.SelectedItem.ToString() == "if" ? "(condition, trueResult, falseResult)" : "");
        }

        private void lstExpresions_DoubleClick(object sender, EventArgs e)
        {
            var selectedExpresion = expressions[lstExpresions.SelectedItem.ToString()];
            if (selectedExpresion != null)
            {
                txtFormula.Text += (txtFormula.Text.Length > 0 ? " " : "") + lstExpresions.SelectedItem;
            }
        }

        private void lstMathFunctions_DoubleClick(object sender, EventArgs e)
        {
            var selectedFunction = functions.Find(f => f.getFunctionName() == lstMathFunctions.SelectedItem.ToString());
            if (selectedFunction != null)
            {
                var parameters = new List<string>();
                for (var i = 0; i < selectedFunction.getParametersNumber(); i++)
                {
                    parameters.Add(selectedFunction.getParameterName(i));
                }
                txtFormula.Text += (txtFormula.Text.Length > 0 ? " " : "") + selectedFunction.getFunctionName() + "(" + String.Join(", ", parameters.ToArray()) + ")";
            }
        }

        private void btnAddFunction_Click(object sender, EventArgs e)
        {
            var inputFunction = Microsoft.VisualBasic.Interaction.InputBox("Function", "Add New Function", "Test(x) = 10 * x", -1, -1);
            if (!string.IsNullOrWhiteSpace(inputFunction))
            {
                Function x = new Function(inputFunction, arguments.Where(f => inputFunction.IndexOf(f.getArgumentName()) != -1).ToArray());
                if (x.checkSyntax())
                {
                    if (!isDuplicated(x.getFunctionName()))
                    {
                        lstMathFunctions.Items.Add(x.getFunctionName());
                        lstMathFunctions.Sorted = true;
                        functions.Add(x);
                    }
                }
                else
                {
                    MessageBox.Show(x.getErrorMessage());
                }
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Expression x = new Expression(ReplaceRegexs(txtFormula.Text), functions.ToArray());
            x.addArguments(arguments.ToArray());
            if (x.checkSyntax() && x.checkLexSyntax())
            {
                txtResult.Text = ReplaceLabels(x.getExpressionString()) + " = " + x.calculate();
                txtResult.Text += GetLabelsData(x.getExpressionString());
            }
            else
            {
                txtResult.Text = x.getErrorMessage();
            }

        }

        private void lstMathFunctions_Click(object sender, EventArgs e)
        {
            var selectedFunction = functions.Find(f => f.getFunctionName() == lstMathFunctions.SelectedItem.ToString());
            if (selectedFunction != null)
            {
                var parameters = new List<string>();
                for (var i = 0; i < selectedFunction.getParametersNumber(); i++)
                {
                    parameters.Add(selectedFunction.getParameterName(i));
                }
                lblFunctionHelper.Text = (parameters.Count == 0 ? "" : "Input" + (parameters.Count > 1 ? "s" : "") + "  =>  " + String.Join(", ", parameters.ToArray()) + Environment.NewLine) + "Return => " + selectedFunction.getFunctionExpressionString();
            }
        }

        private void txtFormula_TextChanged(object sender, EventArgs e)
        {
            if (IsValidFormula())
            {
                txtFormula.ForeColor = Color.Black;
            }
            else
            {
                txtFormula.ForeColor = Color.Red;
            }
        }

        private void btnAddExpersion_Click(object sender, EventArgs e)
        {
            var inputExpresion = Microsoft.VisualBasic.Interaction.InputBox("Expresion", "Add New Expresion", (!IsValidFormula()) ? "1 + 1" : txtFormula.Text, -1, -1);
            Expression x = new Expression(ReplaceRegexs(inputExpresion), functions.ToArray());
            x.addArguments(arguments.ToArray());
            if (x.checkSyntax() && x.checkLexSyntax())
            {
                var expresionName = Microsoft.VisualBasic.Interaction.InputBox("Expresion", "Choose a name for the Exprsion", "Test", -1, -1);
                while (isDuplicated(expresionName))
                {
                    expresionName = Microsoft.VisualBasic.Interaction.InputBox("Expresion", "Choose another name for the Exprsion", "Test", -1, -1);
                }
                lstExpresions.Items.Add(expresionName);
                lstExpresions.Sorted = true;
                expressions.Add(expresionName, x);
                txtFormula.Text = ReplaceLabels(txtFormula.Text);
            }
            else
            {
                MessageBox.Show(x.getErrorMessage());
            }
        }

        private bool IsValidFormula()
        {
            txtFormula.Text = ReplaceLabels(txtFormula.Text);
            Expression x = new Expression(ReplaceRegexs(txtFormula.Text), functions.ToArray());
            x.addArguments(arguments.ToArray());
            return x.checkSyntax();
        }

        private void lstExpresions_Click(object sender, EventArgs e)
        {
            if (lstExpresions.SelectedItem != null)
            {
                var selectedExpresion = expressions[lstExpresions.SelectedItem.ToString()];
                if (selectedExpresion != null)
                {
                    txtExpressionHelper.Text = "Return => " + selectedExpresion.getExpressionString();
                }
            }

        }

        private void btnAddArgumant_Click(object sender, EventArgs e)
        {
            var inputArgumant = Microsoft.VisualBasic.Interaction.InputBox("Argument", "Add New Argument", "Salary = 2000", -1, -1);
            if (!string.IsNullOrWhiteSpace(inputArgumant))
            {
                Argument x = new Argument(inputArgumant);

                if (x.checkSyntax())
                {
                    if (!isDuplicated(x.getArgumentName()))
                    {
                        lstArgumans.Items.Add(x.getArgumentName());
                        lstArgumans.Sorted = true;
                        arguments.Add(x);
                    }
                }
                else
                {
                    MessageBox.Show(x.getErrorMessage());
                }
            }
        }

        private void lstArgumans_DoubleClick(object sender, EventArgs e)
        {
            txtFormula.Text += (txtFormula.Text.Length > 0 ? " " : "") + lstArgumans.SelectedItem.ToString();
        }

        public bool isDuplicated(string checkString)
        {
            if (functions.Any(f => f.getFunctionName() == checkString))
            {
                MessageBox.Show("A function with the same name is already exist");
                return true;
            }
            else if (expressions.Any(f => f.Key == checkString))
            {
                MessageBox.Show("A Exprsion with the same name is already exist");
                return true;
            }
            else if (arguments.Any(f => f.getArgumentName() == checkString))
            {
                MessageBox.Show("A Argument with the same name is already exist");
                return true;
            }
            return false;

        }

        private void lstArgumans_MouseDown(object sender, MouseEventArgs e)
        {
            if (lstArgumans.SelectedItem != null)
            {
                var selectedArgumant = arguments.Find(f => f.getArgumentName() == lstArgumans.SelectedItem.ToString());
                if (e.Button == MouseButtons.Left)
                {
                    if (selectedArgumant != null)
                    {
                        lblArgumantHelper.Text = selectedArgumant.getArgumentName() + " = " + selectedArgumant.getArgumentValue();
                    }
                }
                else
                {
                    EditArgument(selectedArgumant.getArgumentName(), selectedArgumant.getArgumentValue());
                }
            }
        }

        private void EditArgument(string name, double value)
        {
            var inputArgumant = Microsoft.VisualBasic.Interaction.InputBox("Argumant", "Type Argument Value", value.ToString(), -1, -1);
            if (!string.IsNullOrWhiteSpace(inputArgumant))
            {
                Argument x = new Argument(name + " = " + inputArgumant);

                if (x.checkSyntax())
                {
                    var index = arguments.FindIndex(f => f.getArgumentName() == name);
                    if (index != -1)
                    {
                        arguments[index] = x;
                        lblArgumantHelper.Text = x.getArgumentName() + " = " + x.getArgumentValue();
                    }
                    else
                    {
                        MessageBox.Show("Can't edit argument");
                    }
                }
                else
                {
                    MessageBox.Show(x.getErrorMessage());
                }
            }
        }

        private string ReplaceLabels(string input)
        {
            foreach (var item in expressions.OrderBy(f => f.Key.Length))
            {
                input = input.Replace(item.Value.getExpressionString(), item.Key);
            }
            return input;
        }

        private string ReplaceRegexs(string input)
        {
            foreach (var item in expressions.OrderByDescending(f => f.Key.Length))
            {
                input = input.Replace(item.Key, item.Value.getExpressionString());
            }
            return input;
        }

        private string GetLabelsData(string input)
        {
            var result = new List<string>();
            foreach (var item in arguments)
            {
                if (input.IndexOf(item.getArgumentName()) > -1)
                {
                    result.Add(item.getArgumentName() + " = " + item.getArgumentValue());
                }
            }

            foreach (var item in functions)
            {
                if (input.IndexOf(item.getFunctionName()) > -1)
                {
                    var parameters = new List<string>();
                    for (var i = 0; i < item.getParametersNumber(); i++)
                    {
                        parameters.Add(item.getParameterName(i));
                    }

                    result.Add(item.getFunctionName() + "(" + String.Join(", ", parameters.ToArray()) + ") => " + item.getFunctionExpressionString());
                }
            }

            foreach (var item in expressions.OrderBy(f => f.Key.Length))
            {
                if (input.IndexOf(item.Value.getExpressionString()) > -1)
                {
                    Expression x = new Expression(item.Value.getExpressionString(), functions.ToArray());
                    x.addArguments(arguments.ToArray());
                    result.Add(item.Key + " => " + item.Value.getExpressionString() + " = " + x.calculate());
                }
            }
            return (result.Count > 0 ? Environment.NewLine + "------------------------------------" + Environment.NewLine : "") + string.Join(Environment.NewLine, result.ToArray());
        }
    }
}
