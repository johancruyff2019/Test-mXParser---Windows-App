namespace Test_mXParser___Windows_App
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtFormula = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstMathFunctions = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lstOperators = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lstExpresions = new System.Windows.Forms.ListBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnAddExpersion = new System.Windows.Forms.Button();
            this.btnAddFunction = new System.Windows.Forms.Button();
            this.lblFunctionHelper = new System.Windows.Forms.Label();
            this.txtExpressionHelper = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lstArgumans = new System.Windows.Forms.ListBox();
            this.btnAddArgumant = new System.Windows.Forms.Button();
            this.lblArgumantHelper = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFormula
            // 
            this.txtFormula.Location = new System.Drawing.Point(44, 32);
            this.txtFormula.Name = "txtFormula";
            this.txtFormula.Size = new System.Drawing.Size(811, 20);
            this.txtFormula.TabIndex = 0;
            this.txtFormula.TextChanged += new System.EventHandler(this.txtFormula_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Formula";
            // 
            // lstMathFunctions
            // 
            this.lstMathFunctions.FormattingEnabled = true;
            this.lstMathFunctions.Location = new System.Drawing.Point(325, 80);
            this.lstMathFunctions.Name = "lstMathFunctions";
            this.lstMathFunctions.Size = new System.Drawing.Size(253, 186);
            this.lstMathFunctions.TabIndex = 2;
            this.lstMathFunctions.Click += new System.EventHandler(this.lstMathFunctions_Click);
            this.lstMathFunctions.DoubleClick += new System.EventHandler(this.lstMathFunctions_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(322, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Math functions";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(604, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Operators";
            // 
            // lstOperators
            // 
            this.lstOperators.FormattingEnabled = true;
            this.lstOperators.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/",
            "^",
            "!",
            "&",
            "|",
            "(",
            ")",
            "~",
            ">",
            "<",
            "==",
            "=",
            "<>",
            "!=",
            "<=",
            ">=",
            "if"});
            this.lstOperators.Location = new System.Drawing.Point(607, 80);
            this.lstOperators.Name = "lstOperators";
            this.lstOperators.Size = new System.Drawing.Size(95, 186);
            this.lstOperators.TabIndex = 4;
            this.lstOperators.DoubleClick += new System.EventHandler(this.lstOperators_DoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Expersions";
            // 
            // lstExpresions
            // 
            this.lstExpresions.FormattingEnabled = true;
            this.lstExpresions.Location = new System.Drawing.Point(44, 80);
            this.lstExpresions.Name = "lstExpresions";
            this.lstExpresions.Size = new System.Drawing.Size(253, 186);
            this.lstExpresions.TabIndex = 6;
            this.lstExpresions.Click += new System.EventHandler(this.lstExpresions_Click);
            this.lstExpresions.DoubleClick += new System.EventHandler(this.lstExpresions_DoubleClick);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(44, 377);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(811, 155);
            this.txtResult.TabIndex = 8;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(44, 336);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(811, 23);
            this.btnCalculate.TabIndex = 9;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnAddExpersion
            // 
            this.btnAddExpersion.Location = new System.Drawing.Point(276, 57);
            this.btnAddExpersion.Name = "btnAddExpersion";
            this.btnAddExpersion.Size = new System.Drawing.Size(21, 23);
            this.btnAddExpersion.TabIndex = 10;
            this.btnAddExpersion.Text = "+";
            this.btnAddExpersion.UseVisualStyleBackColor = true;
            this.btnAddExpersion.Click += new System.EventHandler(this.btnAddExpersion_Click);
            // 
            // btnAddFunction
            // 
            this.btnAddFunction.Location = new System.Drawing.Point(558, 57);
            this.btnAddFunction.Name = "btnAddFunction";
            this.btnAddFunction.Size = new System.Drawing.Size(21, 23);
            this.btnAddFunction.TabIndex = 12;
            this.btnAddFunction.Text = "+";
            this.btnAddFunction.UseVisualStyleBackColor = true;
            this.btnAddFunction.Click += new System.EventHandler(this.btnAddFunction_Click);
            // 
            // lblFunctionHelper
            // 
            this.lblFunctionHelper.Location = new System.Drawing.Point(322, 269);
            this.lblFunctionHelper.Name = "lblFunctionHelper";
            this.lblFunctionHelper.Size = new System.Drawing.Size(256, 64);
            this.lblFunctionHelper.TabIndex = 13;
            // 
            // txtExpressionHelper
            // 
            this.txtExpressionHelper.Location = new System.Drawing.Point(41, 269);
            this.txtExpressionHelper.Name = "txtExpressionHelper";
            this.txtExpressionHelper.Size = new System.Drawing.Size(256, 64);
            this.txtExpressionHelper.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(727, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Argumants";
            // 
            // lstArgumans
            // 
            this.lstArgumans.FormattingEnabled = true;
            this.lstArgumans.Location = new System.Drawing.Point(730, 80);
            this.lstArgumans.Name = "lstArgumans";
            this.lstArgumans.Size = new System.Drawing.Size(125, 186);
            this.lstArgumans.TabIndex = 15;
            this.lstArgumans.DoubleClick += new System.EventHandler(this.lstArgumans_DoubleClick);
            this.lstArgumans.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstArgumans_MouseDown);
            // 
            // btnAddArgumant
            // 
            this.btnAddArgumant.Location = new System.Drawing.Point(835, 57);
            this.btnAddArgumant.Name = "btnAddArgumant";
            this.btnAddArgumant.Size = new System.Drawing.Size(21, 23);
            this.btnAddArgumant.TabIndex = 17;
            this.btnAddArgumant.Text = "+";
            this.btnAddArgumant.UseVisualStyleBackColor = true;
            this.btnAddArgumant.Click += new System.EventHandler(this.btnAddArgumant_Click);
            // 
            // lblArgumantHelper
            // 
            this.lblArgumantHelper.Location = new System.Drawing.Point(727, 269);
            this.lblArgumantHelper.Name = "lblArgumantHelper";
            this.lblArgumantHelper.Size = new System.Drawing.Size(129, 64);
            this.lblArgumantHelper.TabIndex = 18;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 544);
            this.Controls.Add(this.lblArgumantHelper);
            this.Controls.Add(this.btnAddArgumant);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lstArgumans);
            this.Controls.Add(this.txtExpressionHelper);
            this.Controls.Add(this.lblFunctionHelper);
            this.Controls.Add(this.btnAddFunction);
            this.Controls.Add(this.btnAddExpersion);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstExpresions);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstOperators);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstMathFunctions);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFormula);
            this.Name = "frmMain";
            this.Text = "Test mXparser";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFormula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstMathFunctions;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstOperators;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstExpresions;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnAddExpersion;
        private System.Windows.Forms.Button btnAddFunction;
        private System.Windows.Forms.Label lblFunctionHelper;
        private System.Windows.Forms.Label txtExpressionHelper;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstArgumans;
        private System.Windows.Forms.Button btnAddArgumant;
        private System.Windows.Forms.Label lblArgumantHelper;
    }
}

