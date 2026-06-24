namespace AdvancedCompilerDesign
{
    partial class frmCompiler
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtSourceCode = new System.Windows.Forms.TextBox();
            this.lblSourceCode = new System.Windows.Forms.Label();
            this.btnLoadSample = new System.Windows.Forms.Button();
            this.btnLexical = new System.Windows.Forms.Button();
            this.btnSymbolTable = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.txtFollowSet = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtFirstSet = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvSymbolTable = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvTokens = new System.Windows.Forms.DataGridView();
            this.tabCompilerOutput = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.txtDFA = new System.Windows.Forms.TextBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.txtSLR = new System.Windows.Forms.TextBox();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.txtSemantic = new System.Windows.Forms.TextBox();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.txtIntermediate = new System.Windows.Forms.TextBox();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.txtOptimized = new System.Windows.Forms.TextBox();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.txtFinalCode = new System.Windows.Forms.TextBox();
            this.tabPage11 = new System.Windows.Forms.TabPage();
            this.txtParseTree = new System.Windows.Forms.TextBox();
            this.btnFollow = new System.Windows.Forms.Button();
            this.btnDFA = new System.Windows.Forms.Button();
            this.btnSLR = new System.Windows.Forms.Button();
            this.btnSemantic = new System.Windows.Forms.Button();
            this.btnIntermediate = new System.Windows.Forms.Button();
            this.btnOptimize = new System.Windows.Forms.Button();
            this.btnFinalCode = new System.Windows.Forms.Button();
            this.btnRunAll = new System.Windows.Forms.Button();
            this.btnParseTree = new System.Windows.Forms.Button();
            this.tabPage4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSymbolTable)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTokens)).BeginInit();
            this.tabCompilerOutput.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.tabPage9.SuspendLayout();
            this.tabPage10.SuspendLayout();
            this.tabPage11.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTitle.Location = new System.Drawing.Point(194, -1);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(572, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = " Advanced Compiler Design and Simulation";
            // 
            // txtSourceCode
            // 
            this.txtSourceCode.BackColor = System.Drawing.Color.Black;
            this.txtSourceCode.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSourceCode.ForeColor = System.Drawing.Color.White;
            this.txtSourceCode.Location = new System.Drawing.Point(3, 54);
            this.txtSourceCode.Multiline = true;
            this.txtSourceCode.Name = "txtSourceCode";
            this.txtSourceCode.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSourceCode.Size = new System.Drawing.Size(380, 453);
            this.txtSourceCode.TabIndex = 1;
            this.txtSourceCode.WordWrap = false;
            // 
            // lblSourceCode
            // 
            this.lblSourceCode.AutoSize = true;
            this.lblSourceCode.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSourceCode.Location = new System.Drawing.Point(78, 31);
            this.lblSourceCode.Name = "lblSourceCode";
            this.lblSourceCode.Size = new System.Drawing.Size(141, 20);
            this.lblSourceCode.TabIndex = 2;
            this.lblSourceCode.Text = "Source Code Editor";
            // 
            // btnLoadSample
            // 
            this.btnLoadSample.BackColor = System.Drawing.Color.DarkGreen;
            this.btnLoadSample.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadSample.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadSample.ForeColor = System.Drawing.Color.White;
            this.btnLoadSample.Location = new System.Drawing.Point(400, 52);
            this.btnLoadSample.Name = "btnLoadSample";
            this.btnLoadSample.Size = new System.Drawing.Size(110, 24);
            this.btnLoadSample.TabIndex = 4;
            this.btnLoadSample.Text = "Load Sample";
            this.btnLoadSample.UseVisualStyleBackColor = false;
            this.btnLoadSample.Click += new System.EventHandler(this.btnLoadSample_Click);
            // 
            // btnLexical
            // 
            this.btnLexical.BackColor = System.Drawing.Color.DarkGreen;
            this.btnLexical.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLexical.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLexical.ForeColor = System.Drawing.Color.White;
            this.btnLexical.Location = new System.Drawing.Point(400, 82);
            this.btnLexical.Name = "btnLexical";
            this.btnLexical.Size = new System.Drawing.Size(110, 24);
            this.btnLexical.TabIndex = 5;
            this.btnLexical.Text = "Lexical Analysis";
            this.btnLexical.UseVisualStyleBackColor = false;
            this.btnLexical.Click += new System.EventHandler(this.btnLexical_Click);
            // 
            // btnSymbolTable
            // 
            this.btnSymbolTable.BackColor = System.Drawing.Color.DarkGreen;
            this.btnSymbolTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSymbolTable.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSymbolTable.ForeColor = System.Drawing.Color.White;
            this.btnSymbolTable.Location = new System.Drawing.Point(400, 112);
            this.btnSymbolTable.Name = "btnSymbolTable";
            this.btnSymbolTable.Size = new System.Drawing.Size(110, 24);
            this.btnSymbolTable.TabIndex = 6;
            this.btnSymbolTable.Text = "Symbol Table";
            this.btnSymbolTable.UseVisualStyleBackColor = false;
            this.btnSymbolTable.Click += new System.EventHandler(this.btnSymbolTable_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Firebrick;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(400, 411);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(110, 24);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.BackColor = System.Drawing.Color.DarkGreen;
            this.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirst.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirst.ForeColor = System.Drawing.Color.White;
            this.btnFirst.Location = new System.Drawing.Point(400, 141);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(110, 24);
            this.btnFirst.TabIndex = 8;
            this.btnFirst.Text = "FIRST Set";
            this.btnFirst.UseVisualStyleBackColor = false;
            this.btnFirst.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.txtFollowSet);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(816, 429);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Follow Set";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // txtFollowSet
            // 
            this.txtFollowSet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFollowSet.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFollowSet.Location = new System.Drawing.Point(3, 3);
            this.txtFollowSet.Multiline = true;
            this.txtFollowSet.Name = "txtFollowSet";
            this.txtFollowSet.ReadOnly = true;
            this.txtFollowSet.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtFollowSet.Size = new System.Drawing.Size(810, 423);
            this.txtFollowSet.TabIndex = 0;
            this.txtFollowSet.WordWrap = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtFirstSet);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(816, 429);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "First Set";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtFirstSet
            // 
            this.txtFirstSet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFirstSet.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstSet.Location = new System.Drawing.Point(3, 3);
            this.txtFirstSet.Multiline = true;
            this.txtFirstSet.Name = "txtFirstSet";
            this.txtFirstSet.ReadOnly = true;
            this.txtFirstSet.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtFirstSet.Size = new System.Drawing.Size(810, 423);
            this.txtFirstSet.TabIndex = 0;
            this.txtFirstSet.WordWrap = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvSymbolTable);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(816, 429);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Symbol Table";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvSymbolTable
            // 
            this.dgvSymbolTable.AllowUserToAddRows = false;
            this.dgvSymbolTable.AllowUserToDeleteRows = false;
            this.dgvSymbolTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSymbolTable.BackgroundColor = System.Drawing.Color.White;
            this.dgvSymbolTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSymbolTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSymbolTable.Location = new System.Drawing.Point(3, 3);
            this.dgvSymbolTable.Name = "dgvSymbolTable";
            this.dgvSymbolTable.ReadOnly = true;
            this.dgvSymbolTable.Size = new System.Drawing.Size(810, 423);
            this.dgvSymbolTable.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvTokens);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(816, 429);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tokens";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvTokens
            // 
            this.dgvTokens.AllowUserToAddRows = false;
            this.dgvTokens.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTokens.BackgroundColor = System.Drawing.Color.White;
            this.dgvTokens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTokens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTokens.Location = new System.Drawing.Point(3, 3);
            this.dgvTokens.Name = "dgvTokens";
            this.dgvTokens.ReadOnly = true;
            this.dgvTokens.Size = new System.Drawing.Size(810, 423);
            this.dgvTokens.TabIndex = 0;
            // 
            // tabCompilerOutput
            // 
            this.tabCompilerOutput.Controls.Add(this.tabPage1);
            this.tabCompilerOutput.Controls.Add(this.tabPage2);
            this.tabCompilerOutput.Controls.Add(this.tabPage3);
            this.tabCompilerOutput.Controls.Add(this.tabPage4);
            this.tabCompilerOutput.Controls.Add(this.tabPage5);
            this.tabCompilerOutput.Controls.Add(this.tabPage6);
            this.tabCompilerOutput.Controls.Add(this.tabPage7);
            this.tabCompilerOutput.Controls.Add(this.tabPage8);
            this.tabCompilerOutput.Controls.Add(this.tabPage9);
            this.tabCompilerOutput.Controls.Add(this.tabPage10);
            this.tabCompilerOutput.Controls.Add(this.tabPage11);
            this.tabCompilerOutput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCompilerOutput.Location = new System.Drawing.Point(516, 54);
            this.tabCompilerOutput.Multiline = true;
            this.tabCompilerOutput.Name = "tabCompilerOutput";
            this.tabCompilerOutput.SelectedIndex = 0;
            this.tabCompilerOutput.Size = new System.Drawing.Size(824, 457);
            this.tabCompilerOutput.TabIndex = 3;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.txtDFA);
            this.tabPage5.Location = new System.Drawing.Point(4, 24);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(816, 429);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "DFA";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // txtDFA
            // 
            this.txtDFA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDFA.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDFA.Location = new System.Drawing.Point(3, 3);
            this.txtDFA.Multiline = true;
            this.txtDFA.Name = "txtDFA";
            this.txtDFA.ReadOnly = true;
            this.txtDFA.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDFA.Size = new System.Drawing.Size(810, 423);
            this.txtDFA.TabIndex = 0;
            this.txtDFA.WordWrap = false;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.txtSLR);
            this.tabPage6.Location = new System.Drawing.Point(4, 24);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(816, 429);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "SLR Parser";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // txtSLR
            // 
            this.txtSLR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSLR.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSLR.Location = new System.Drawing.Point(3, 3);
            this.txtSLR.Multiline = true;
            this.txtSLR.Name = "txtSLR";
            this.txtSLR.ReadOnly = true;
            this.txtSLR.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSLR.Size = new System.Drawing.Size(810, 423);
            this.txtSLR.TabIndex = 0;
            this.txtSLR.WordWrap = false;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.txtSemantic);
            this.tabPage7.Location = new System.Drawing.Point(4, 24);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(816, 429);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Semantic";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // txtSemantic
            // 
            this.txtSemantic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSemantic.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSemantic.Location = new System.Drawing.Point(3, 3);
            this.txtSemantic.Multiline = true;
            this.txtSemantic.Name = "txtSemantic";
            this.txtSemantic.ReadOnly = true;
            this.txtSemantic.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSemantic.Size = new System.Drawing.Size(810, 423);
            this.txtSemantic.TabIndex = 0;
            this.txtSemantic.WordWrap = false;
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.txtIntermediate);
            this.tabPage8.Location = new System.Drawing.Point(4, 24);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(816, 429);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "Intermediate Code";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // txtIntermediate
            // 
            this.txtIntermediate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtIntermediate.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIntermediate.Location = new System.Drawing.Point(3, 3);
            this.txtIntermediate.Multiline = true;
            this.txtIntermediate.Name = "txtIntermediate";
            this.txtIntermediate.ReadOnly = true;
            this.txtIntermediate.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtIntermediate.Size = new System.Drawing.Size(810, 423);
            this.txtIntermediate.TabIndex = 0;
            this.txtIntermediate.WordWrap = false;
            // 
            // tabPage9
            // 
            this.tabPage9.Controls.Add(this.txtOptimized);
            this.tabPage9.Location = new System.Drawing.Point(4, 24);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(816, 429);
            this.tabPage9.TabIndex = 8;
            this.tabPage9.Text = "Optimized Code";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // txtOptimized
            // 
            this.txtOptimized.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOptimized.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOptimized.Location = new System.Drawing.Point(3, 3);
            this.txtOptimized.Multiline = true;
            this.txtOptimized.Name = "txtOptimized";
            this.txtOptimized.ReadOnly = true;
            this.txtOptimized.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOptimized.Size = new System.Drawing.Size(810, 423);
            this.txtOptimized.TabIndex = 0;
            this.txtOptimized.WordWrap = false;
            // 
            // tabPage10
            // 
            this.tabPage10.Controls.Add(this.txtFinalCode);
            this.tabPage10.Location = new System.Drawing.Point(4, 24);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage10.Size = new System.Drawing.Size(816, 429);
            this.tabPage10.TabIndex = 9;
            this.tabPage10.Text = "Final Code";
            this.tabPage10.UseVisualStyleBackColor = true;
            // 
            // txtFinalCode
            // 
            this.txtFinalCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFinalCode.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFinalCode.Location = new System.Drawing.Point(3, 3);
            this.txtFinalCode.Multiline = true;
            this.txtFinalCode.Name = "txtFinalCode";
            this.txtFinalCode.ReadOnly = true;
            this.txtFinalCode.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtFinalCode.Size = new System.Drawing.Size(810, 423);
            this.txtFinalCode.TabIndex = 0;
            this.txtFinalCode.WordWrap = false;
            // 
            // tabPage11
            // 
            this.tabPage11.Controls.Add(this.txtParseTree);
            this.tabPage11.Location = new System.Drawing.Point(4, 24);
            this.tabPage11.Name = "tabPage11";
            this.tabPage11.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage11.Size = new System.Drawing.Size(816, 429);
            this.tabPage11.TabIndex = 10;
            this.tabPage11.Text = "Parse Tree";
            this.tabPage11.UseVisualStyleBackColor = true;
            // 
            // txtParseTree
            // 
            this.txtParseTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtParseTree.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParseTree.Location = new System.Drawing.Point(3, 3);
            this.txtParseTree.Multiline = true;
            this.txtParseTree.Name = "txtParseTree";
            this.txtParseTree.ReadOnly = true;
            this.txtParseTree.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtParseTree.Size = new System.Drawing.Size(810, 423);
            this.txtParseTree.TabIndex = 0;
            this.txtParseTree.WordWrap = false;
            // 
            // btnFollow
            // 
            this.btnFollow.BackColor = System.Drawing.Color.DarkGreen;
            this.btnFollow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFollow.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFollow.ForeColor = System.Drawing.Color.White;
            this.btnFollow.Location = new System.Drawing.Point(400, 171);
            this.btnFollow.Name = "btnFollow";
            this.btnFollow.Size = new System.Drawing.Size(110, 24);
            this.btnFollow.TabIndex = 9;
            this.btnFollow.Text = "Follow Set";
            this.btnFollow.UseVisualStyleBackColor = false;
            this.btnFollow.Click += new System.EventHandler(this.btnFollow_Click);
            // 
            // btnDFA
            // 
            this.btnDFA.BackColor = System.Drawing.Color.DarkGreen;
            this.btnDFA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDFA.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDFA.ForeColor = System.Drawing.Color.White;
            this.btnDFA.Location = new System.Drawing.Point(400, 201);
            this.btnDFA.Name = "btnDFA";
            this.btnDFA.Size = new System.Drawing.Size(110, 24);
            this.btnDFA.TabIndex = 10;
            this.btnDFA.Text = "Run DFA";
            this.btnDFA.UseVisualStyleBackColor = false;
            this.btnDFA.Click += new System.EventHandler(this.btnDFA_Click);
            // 
            // btnSLR
            // 
            this.btnSLR.BackColor = System.Drawing.Color.DarkGreen;
            this.btnSLR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSLR.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSLR.ForeColor = System.Drawing.Color.White;
            this.btnSLR.Location = new System.Drawing.Point(400, 231);
            this.btnSLR.Name = "btnSLR";
            this.btnSLR.Size = new System.Drawing.Size(110, 24);
            this.btnSLR.TabIndex = 11;
            this.btnSLR.Text = "SLR Parser";
            this.btnSLR.UseVisualStyleBackColor = false;
            this.btnSLR.Click += new System.EventHandler(this.btnSLR_Click);
            // 
            // btnSemantic
            // 
            this.btnSemantic.BackColor = System.Drawing.Color.DarkGreen;
            this.btnSemantic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSemantic.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSemantic.ForeColor = System.Drawing.Color.White;
            this.btnSemantic.Location = new System.Drawing.Point(400, 261);
            this.btnSemantic.Name = "btnSemantic";
            this.btnSemantic.Size = new System.Drawing.Size(110, 24);
            this.btnSemantic.TabIndex = 12;
            this.btnSemantic.Text = "Semantic";
            this.btnSemantic.UseVisualStyleBackColor = false;
            this.btnSemantic.Click += new System.EventHandler(this.btnSemantic_Click);
            // 
            // btnIntermediate
            // 
            this.btnIntermediate.BackColor = System.Drawing.Color.DarkGreen;
            this.btnIntermediate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIntermediate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIntermediate.ForeColor = System.Drawing.Color.White;
            this.btnIntermediate.Location = new System.Drawing.Point(400, 291);
            this.btnIntermediate.Name = "btnIntermediate";
            this.btnIntermediate.Size = new System.Drawing.Size(110, 24);
            this.btnIntermediate.TabIndex = 13;
            this.btnIntermediate.Text = "Intermediate";
            this.btnIntermediate.UseVisualStyleBackColor = false;
            this.btnIntermediate.Click += new System.EventHandler(this.btnIntermediate_Click);
            // 
            // btnOptimize
            // 
            this.btnOptimize.BackColor = System.Drawing.Color.DarkGreen;
            this.btnOptimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOptimize.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOptimize.ForeColor = System.Drawing.Color.White;
            this.btnOptimize.Location = new System.Drawing.Point(400, 321);
            this.btnOptimize.Name = "btnOptimize";
            this.btnOptimize.Size = new System.Drawing.Size(110, 24);
            this.btnOptimize.TabIndex = 14;
            this.btnOptimize.Text = "Optimize";
            this.btnOptimize.UseVisualStyleBackColor = false;
            this.btnOptimize.Click += new System.EventHandler(this.btnOptimize_Click);
            // 
            // btnFinalCode
            // 
            this.btnFinalCode.BackColor = System.Drawing.Color.DarkGreen;
            this.btnFinalCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalCode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalCode.ForeColor = System.Drawing.Color.White;
            this.btnFinalCode.Location = new System.Drawing.Point(400, 351);
            this.btnFinalCode.Name = "btnFinalCode";
            this.btnFinalCode.Size = new System.Drawing.Size(110, 24);
            this.btnFinalCode.TabIndex = 15;
            this.btnFinalCode.Text = "Final Code";
            this.btnFinalCode.UseVisualStyleBackColor = false;
            this.btnFinalCode.Click += new System.EventHandler(this.btnFinalCode_Click);
            // 
            // btnRunAll
            // 
            this.btnRunAll.BackColor = System.Drawing.Color.DarkGreen;
            this.btnRunAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRunAll.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRunAll.ForeColor = System.Drawing.Color.White;
            this.btnRunAll.Location = new System.Drawing.Point(400, 381);
            this.btnRunAll.Name = "btnRunAll";
            this.btnRunAll.Size = new System.Drawing.Size(110, 24);
            this.btnRunAll.TabIndex = 16;
            this.btnRunAll.Text = "Run All";
            this.btnRunAll.UseVisualStyleBackColor = false;
            this.btnRunAll.Click += new System.EventHandler(this.btnRunAll_Click);
            // 
            // btnParseTree
            // 
            this.btnParseTree.BackColor = System.Drawing.Color.DarkGreen;
            this.btnParseTree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParseTree.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParseTree.ForeColor = System.Drawing.Color.White;
            this.btnParseTree.Location = new System.Drawing.Point(400, 439);
            this.btnParseTree.Name = "btnParseTree";
            this.btnParseTree.Size = new System.Drawing.Size(110, 23);
            this.btnParseTree.TabIndex = 18;
            this.btnParseTree.Text = "Parse Tree";
            this.btnParseTree.UseVisualStyleBackColor = false;
            this.btnParseTree.Click += new System.EventHandler(this.btnParseTree_Click);
            // 
            // frmCompiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1370, 541);
            this.Controls.Add(this.btnParseTree);
            this.Controls.Add(this.btnRunAll);
            this.Controls.Add(this.btnFinalCode);
            this.Controls.Add(this.btnOptimize);
            this.Controls.Add(this.btnIntermediate);
            this.Controls.Add(this.btnSemantic);
            this.Controls.Add(this.btnSLR);
            this.Controls.Add(this.btnDFA);
            this.Controls.Add(this.btnFollow);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSymbolTable);
            this.Controls.Add(this.btnLexical);
            this.Controls.Add(this.btnLoadSample);
            this.Controls.Add(this.tabCompilerOutput);
            this.Controls.Add(this.lblSourceCode);
            this.Controls.Add(this.txtSourceCode);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmCompiler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Advanced Compiler Design and Simulation - HibbanScript";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSymbolTable)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTokens)).EndInit();
            this.tabCompilerOutput.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            this.tabPage9.ResumeLayout(false);
            this.tabPage9.PerformLayout();
            this.tabPage10.ResumeLayout(false);
            this.tabPage10.PerformLayout();
            this.tabPage11.ResumeLayout(false);
            this.tabPage11.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtSourceCode;
        private System.Windows.Forms.Label lblSourceCode;
        private System.Windows.Forms.Button btnLoadSample;
        private System.Windows.Forms.Button btnLexical;
        private System.Windows.Forms.Button btnSymbolTable;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtFirstSet;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvSymbolTable;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvTokens;
        private System.Windows.Forms.TabControl tabCompilerOutput;
        private System.Windows.Forms.TextBox txtFollowSet;
        private System.Windows.Forms.Button btnFollow;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TextBox txtDFA;
        private System.Windows.Forms.Button btnDFA;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TextBox txtSLR;
        private System.Windows.Forms.Button btnSLR;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TextBox txtSemantic;
        private System.Windows.Forms.Button btnSemantic;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.TextBox txtIntermediate;
        private System.Windows.Forms.Button btnIntermediate;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.TextBox txtOptimized;
        private System.Windows.Forms.Button btnOptimize;
        private System.Windows.Forms.TabPage tabPage10;
        private System.Windows.Forms.TextBox txtFinalCode;
        private System.Windows.Forms.Button btnFinalCode;
        private System.Windows.Forms.Button btnRunAll;
        private System.Windows.Forms.TabPage tabPage11;
        private System.Windows.Forms.TextBox txtParseTree;
        private System.Windows.Forms.Button btnParseTree;
    }
}

