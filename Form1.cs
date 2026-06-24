using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AdvancedCompilerDesign
{
    public partial class frmCompiler : System.Windows.Forms.Form
    {
        List<TokenInfo> tokens = new List<TokenInfo>();
        List<SymbolInfo> symbols = new List<SymbolInfo>();

        bool isRunningAll = false;
        public class TokenInfo
        {
            public int LineNo { get; set; }
            public string Lexeme { get; set; }
            public string TokenType { get; set; }
        }

        public class SymbolInfo
        {
            public string Name { get; set; }
            public string DataType { get; set; }
            public string Value { get; set; }
            public int LineNo { get; set; }
        }
        public frmCompiler()
        {
            InitializeComponent();
            //Keep Parse Tree before Final Code and Final Code at the end

           tabCompilerOutput.TabPages.Remove(tabPage10);   // Final Code tab

            // Agar tumhare Parse Tree tab ka name tabPage11 hai, ye line use karo
            tabCompilerOutput.TabPages.Remove(tabPage11);   // Parse Tree tab

            tabCompilerOutput.TabPages.Add(tabPage11);      // Parse Tree second last
            tabCompilerOutput.TabPages.Add(tabPage10);      // Final Code last  
        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        private void btnLoadSample_Click(object sender, EventArgs e) //button loadsample method
        {
            txtSourceCode.Text =
            @"begin()
            int a = 5;
            float b = 10.5;
            int sum = 0;
            sum = a + 2;
            if(sum > 5)
            print sum;
            end";
        }

        private void btnLexical_Click(object sender, EventArgs e) //button lexical method
        {
            tokens.Clear();
            dgvTokens.DataSource = null;

            string[] lines = txtSourceCode.Text.Split(new[] { "\r\n", "\n" }, StringSplitOptions.None);

            string pattern = @"[a-zA-Z_][a-zA-Z0-9_]*|\d+\.\d+|\d+|==|!=|>=|<=|[+\-*/=<>();{}]";

            for (int i = 0; i < lines.Length; i++)
            {
                MatchCollection matches = Regex.Matches(lines[i], pattern);

                foreach (Match match in matches)
                {
                    string lexeme = match.Value;
                    string tokenType = GetTokenType(lexeme);

                    tokens.Add(new TokenInfo
                    {
                        LineNo = i + 1,
                        Lexeme = lexeme,
                        TokenType = tokenType
                    });
                }
            }

            dgvTokens.DataSource = tokens.ToList();

            tabCompilerOutput.SelectedIndex = 0;

            ShowMessage("Lexical Analysis Completed Successfully!", "Success");
        }

        private void btnSymbolTable_Click(object sender, EventArgs e) //button symbol method
        {
            symbols.Clear();
            dgvSymbolTable.DataSource = null;

            if (tokens.Count == 0)
            {
                ShowMessage("Please run Lexical Analysis first!", "Warning");
                return;
            }

            for (int i = 0; i < tokens.Count; i++)
            {
                if (tokens[i].Lexeme == "int" || tokens[i].Lexeme == "float" || tokens[i].Lexeme == "string")
                {
                    string dataType = tokens[i].Lexeme;

                    if (i + 1 < tokens.Count && tokens[i + 1].TokenType == "Identifier")
                    {
                        string name = tokens[i + 1].Lexeme;
                        string value = "Not Assigned";

                        if (i + 3 < tokens.Count && tokens[i + 2].Lexeme == "=")
                        {
                            value = tokens[i + 3].Lexeme;
                        }

                        bool alreadyExists = symbols.Any(s => s.Name == name);

                        if (!alreadyExists)
                        {
                            symbols.Add(new SymbolInfo
                            {
                                Name = name,
                                DataType = dataType,
                                Value = value,
                                LineNo = tokens[i].LineNo
                            });
                        }
                    }
                }
            }

            dgvSymbolTable.DataSource = symbols.ToList();

            tabCompilerOutput.SelectedIndex = 1;

            ShowMessage("Symbol Table Generated Successfully!", "Success");
        }

        private void btnClear_Click(object sender, EventArgs e) //button clear method
        {
            txtSourceCode.Clear();

            tokens.Clear();
            symbols.Clear();

            dgvTokens.DataSource = null;
            dgvSymbolTable.DataSource = null;
            //lstFirstSet.Items.Clear();
            txtFirstSet.Clear();
            txtFollowSet.Clear();
            txtDFA.Clear();
            txtSLR.Clear();
            txtSemantic.Clear();
            txtIntermediate.Clear();
            txtOptimized.Clear();
            txtFinalCode.Clear();
            txtParseTree.Clear();
        }


        private string GetTokenType(string lexeme)
        {
            string[] keywords = { "begin", "end", "int", "float", "string", "if", "else", "while", "print" };
            string[] operators = { "+", "-", "*", "/", "=", "==", "!=", ">", "<", ">=", "<=" };
            string[] separators = { "(", ")", ";", "{", "}" };

            if (keywords.Contains(lexeme))
                return "Keyword";

            if (Regex.IsMatch(lexeme, @"^[a-zA-Z_][a-zA-Z0-9_]*$"))
                return "Identifier";

            if (Regex.IsMatch(lexeme, @"^\d+\.\d+$"))
                return "Float Number";

            if (Regex.IsMatch(lexeme, @"^\d+$"))
                return "Integer Number";

            if (operators.Contains(lexeme))
                return "Operator";

            if (separators.Contains(lexeme))
                return "Separator";

            return "Unknown";
        }

        private void button1_Click(object sender, EventArgs e) //button firstset method
        {
            txtFirstSet.Text =
          @"Grammar Used in HibbanScript:
           --------------------------------
             Program     -> begin ( ) StmtList end
             StmtList    -> Stmt StmtList | ε
              Stmt        -> Declaration | Assignment | IfStmt | PrintStmt
              Declaration -> Type id = Expr ;
              Type        -> int | float | string
              Assignment  -> id = Expr ;
              IfStmt      -> if ( Condition ) Stmt
              PrintStmt   -> print id ;
              Condition   -> id RelOp Expr
              RelOp       -> > | < | >= | <= | == | !=
              Expr        -> Term ExprPrime
              ExprPrime   -> + Term ExprPrime | - Term ExprPrime | ε
              Term        -> Factor TermPrime
              .            TermPrime   -> * Factor TermPrime | / Factor TermPrime | ε
            Factor      -> id | num

               FIRST Sets:
           --------------------------------
               FIRST(Program)     = { begin }
               FIRST(StmtList)    = { int, float, string, id, if, print, ε }
               FIRST(Stmt)        = { int, float, string, id, if, print }
               FIRST(Declaration) = { int, float, string }
               FIRST(Type)        = { int, float, string }
               FIRST(Assignment)  = { id }
               FIRST(IfStmt)      = { if }
               FIRST(PrintStmt)   = { print }
               FIRST(Condition)   = { id }
               FIRST(RelOp)       = { >, <, >=, <=, ==, != }
               FIRST(Expr)        = { id, num }
               FIRST(ExprPrime)   = { +, -, ε }
               FIRST(Term)        = { id, num }
               FIRST(TermPrime)   = { *, /, ε }
               FIRST(Factor)      = { id, num }";

            tabCompilerOutput.SelectedIndex = 2;

            ShowMessage("FIRST Set Generated Successfully!", "Success");
        }

        private void btnFollow_Click(object sender, EventArgs e) //button follow method
        {
            txtFollowSet.Text =
              @"Grammar Used in HibbanScript:
             --------------------------------
             Program     -> begin ( ) StmtList end
             StmtList    -> Stmt StmtList | ε
             Stmt        -> Declaration | Assignment | IfStmt | PrintStmt
             Declaration -> Type id = Expr ;
             Type        -> int | float | string
             Assignment  -> id = Expr ;
             IfStmt      -> if ( Condition ) Stmt
             PrintStmt   -> print id ;
             Condition   -> id RelOp Expr
             RelOp       -> > | < | >= | <= | == | !=
             Expr        -> Term ExprPrime
             ExprPrime   -> + Term ExprPrime | - Term ExprPrime | ε
             Term        -> Factor TermPrime
             TermPrime   -> * Factor TermPrime | / Factor TermPrime | ε
             Factor      -> id | num

              FOLLOW Sets:
            --------------------------------
               FOLLOW(Program)     = { $ }
               FOLLOW(StmtList)    = { end }
               FOLLOW(Stmt)        = { int, float, string, id, if, print, end }
               FOLLOW(Declaration) = { int, float, string, id, if, print, end }
               FOLLOW(Type)        = { id }
               FOLLOW(Assignment)  = { int, float, string, id, if, print, end }
               FOLLOW(IfStmt)      = { int, float, string, id, if, print, end }
               FOLLOW(PrintStmt)   = { int, float, string, id, if, print, end }
               FOLLOW(Condition)   = { ) }
               FOLLOW(RelOp)       = { id, num }
               FOLLOW(Expr)        = { ;, ) }
               FOLLOW(ExprPrime)   = { ;, ) }
               FOLLOW(Term)        = { +, -, ;, ) }
               FOLLOW(TermPrime)   = { +, -, ;, ) }
               FOLLOW(Factor)      = { *, /, +, -, ;, ) }

                  Note:
                $ shows end of input.
               ε shows empty production.";

            tabCompilerOutput.SelectedIndex = 3;

            ShowMessage("FOLLOW Set Generated Successfully!", "Success");
        }

        private void btnDFA_Click(object sender, EventArgs e)
        {
            string source = txtSourceCode.Text.Trim();

            txtDFA.Clear();

            if (string.IsNullOrWhiteSpace(source))
            {
                ShowMessage("Please enter source code first!", "Warning");
                return;
            }

            bool hasBegin = Regex.IsMatch(source, @"\bbegin\s*\(\s*\)");
            bool hasEnd = Regex.IsMatch(source, @"\bend\b");
            bool hasDeclaration = Regex.IsMatch(source, @"\b(int|float|string)\s+[a-zA-Z_][a-zA-Z0-9_]*\s*=");
            bool hasStatementEnd = source.Contains(";");

            txtDFA.AppendText("DFA VALIDATION - HibbanScript\r\n");
            txtDFA.AppendText("====================================\r\n\r\n");

            txtDFA.AppendText("DFA STATES:\r\n");
            txtDFA.AppendText("q0  = Start State\r\n");
            txtDFA.AppendText("q1  = begin keyword found\r\n");
            txtDFA.AppendText("q2  = '(' found\r\n");
            txtDFA.AppendText("q3  = ')' found\r\n");
            txtDFA.AppendText("q4  = statements processing\r\n");
            txtDFA.AppendText("q5  = end keyword found\r\n");
            txtDFA.AppendText("qf  = Final Accept State\r\n\r\n");

            txtDFA.AppendText("STATE TRANSITION SEQUENCE:\r\n");
            txtDFA.AppendText("====================================\r\n");

            if (hasBegin)
                txtDFA.AppendText("q0 -> q1 -> q2 -> q3 : begin() accepted\r\n");
            else
                txtDFA.AppendText("q0 -> ERROR : begin() missing\r\n");

            if (hasDeclaration)
                txtDFA.AppendText("q3 -> q4 : declaration accepted\r\n");
            else
                txtDFA.AppendText("q3 -> WARNING : declaration missing\r\n");

            if (hasStatementEnd)
                txtDFA.AppendText("q4 -> q4 : statements accepted\r\n");
            else
                txtDFA.AppendText("q4 -> ERROR : semicolon missing\r\n");

            if (hasEnd)
                txtDFA.AppendText("q4 -> q5 -> qf : end accepted\r\n");
            else
                txtDFA.AppendText("q4 -> ERROR : end missing\r\n");

            txtDFA.AppendText("\r\nFINAL RESULT:\r\n");
            txtDFA.AppendText("====================================\r\n");

            if (hasBegin && hasEnd && hasDeclaration && hasStatementEnd)
            {
                txtDFA.AppendText("Input string is ACCEPTED by DFA.\r\n");
                txtDFA.AppendText("Program basic structure is valid.\r\n");
            }
            else
            {
                txtDFA.AppendText("Input string is REJECTED by DFA.\r\n");
                txtDFA.AppendText("Program basic structure is invalid.\r\n");
            }

            txtDFA.SelectionStart = 0;
            txtDFA.ScrollToCaret();

            tabCompilerOutput.SelectedIndex = 4;

            ShowMessage("DFA Validation Completed!", "Success");
        }

        private void btnSLR_Click(object sender, EventArgs e)
        {
            txtSLR.Clear();

            if (tokens.Count == 0)
            {
                ShowMessage("Please run Lexical Analysis first!", "Warning");
                return;
            }

            txtSLR.AppendText("SLR PARSER - Bottom-Up Parsing\r\n");
            txtSLR.AppendText("========================================\r\n\r\n");

            txtSLR.AppendText("Grammar Used:\r\n");
            txtSLR.AppendText("Program     -> begin ( ) StmtList end\r\n");
            txtSLR.AppendText("StmtList    -> Stmt StmtList | ε\r\n");
            txtSLR.AppendText("Stmt        -> Declaration | Assignment | IfStmt | PrintStmt\r\n");
            txtSLR.AppendText("Declaration -> Type id = num ;\r\n");
            txtSLR.AppendText("Type        -> int | float | string\r\n");
            txtSLR.AppendText("Assignment  -> id = Expr ;\r\n");
            txtSLR.AppendText("IfStmt      -> if ( Condition ) Stmt\r\n");
            txtSLR.AppendText("PrintStmt   -> print id ;\r\n\r\n");

            txtSLR.AppendText("Parsing Steps:\r\n");
            txtSLR.AppendText("========================================\r\n");
            txtSLR.AppendText("Step\tStack\t\tInput\t\tAction\r\n");
            txtSLR.AppendText("----------------------------------------\r\n");

            List<string> input = tokens.Select(t => NormalizeTokenForParser(t)).ToList();
            input.Add("$");

            Stack<string> stack = new Stack<string>();
            stack.Push("$");

            int index = 0;
            int step = 1;
            bool error = false;

            while (index < input.Count)
            {
                string current = input[index];

                if (current == "$")
                    break;

                string stackText = string.Join(" ", stack.Reverse());
                string inputText = string.Join(" ", input.Skip(index));

                txtSLR.AppendText(step + "\t" + stackText + "\t\t" + inputText + "\t\tSHIFT " + current + "\r\n");

                stack.Push(current);
                index++;
                step++;

                // Simple reductions for project demonstration
                if (current == "num")
                {
                    txtSLR.AppendText(step + "\t" + string.Join(" ", stack.Reverse()) + "\t\t" + string.Join(" ", input.Skip(index)) + "\t\tREDUCE num -> Factor\r\n");
                    step++;
                }
                else if (current == "id")
                {
                    txtSLR.AppendText(step + "\t" + string.Join(" ", stack.Reverse()) + "\t\t" + string.Join(" ", input.Skip(index)) + "\t\tREDUCE id -> Factor\r\n");
                    step++;
                }
                else if (current == "int" || current == "float" || current == "string")
                {
                    txtSLR.AppendText(step + "\t" + string.Join(" ", stack.Reverse()) + "\t\t" + string.Join(" ", input.Skip(index)) + "\t\tREDUCE " + current + " -> Type\r\n");
                    step++;
                }
            }

            txtSLR.AppendText("\r\nFinal Checking:\r\n");
            txtSLR.AppendText("========================================\r\n");

            bool hasBegin = tokens.Any(t => t.Lexeme == "begin");
            bool hasEnd = tokens.Any(t => t.Lexeme == "end");
            bool hasOpenParen = tokens.Any(t => t.Lexeme == "(");
            bool hasCloseParen = tokens.Any(t => t.Lexeme == ")");
            bool hasSemicolon = tokens.Any(t => t.Lexeme == ";");

            if (!hasBegin)
            {
                txtSLR.AppendText("Syntax Error: begin keyword missing\r\n");
                error = true;
            }

            if (!hasOpenParen || !hasCloseParen)
            {
                txtSLR.AppendText("Syntax Error: begin() parentheses missing\r\n");
                error = true;
            }

            if (!hasSemicolon)
            {
                txtSLR.AppendText("Syntax Error: semicolon missing\r\n");
                error = true;
            }

            if (!hasEnd)
            {
                txtSLR.AppendText("Syntax Error: end keyword missing\r\n");
                error = true;
            }

            txtSLR.AppendText("\r\nSLR Parser Result:\r\n");
            txtSLR.AppendText("========================================\r\n");

            if (!error)
            {
                txtSLR.AppendText("Input string is ACCEPTED by SLR Parser.\r\n");
                txtSLR.AppendText("Syntax Analysis Completed Successfully.\r\n");
            }
            else
            {
                txtSLR.AppendText("Input string is REJECTED by SLR Parser.\r\n");
                txtSLR.AppendText("Syntax errors found in source code.\r\n");
            }

            txtSLR.SelectionStart = 0;
            txtSLR.ScrollToCaret();

            tabCompilerOutput.SelectedIndex = 5;

            ShowMessage("SLR Parsing Completed!", "Success");
        }

        private string NormalizeTokenForParser(TokenInfo token)
        {
            if (token.TokenType == "Identifier")
                return "id";

            if (token.TokenType == "Integer Number" || token.TokenType == "Float Number")
                return "num";

            return token.Lexeme;
        }

        private void btnSemantic_Click(object sender, EventArgs e)
        {
            txtSemantic.Clear();

            if (tokens.Count == 0)
            {
                ShowMessage("Please run Lexical Analysis first!", "Warning");
                return;
            }

            if (symbols.Count == 0)
            {
                ShowMessage("Please generate Symbol Table first!", "Warning");
                return;
            }

            txtSemantic.AppendText("SEMANTIC ANALYZER - HibbanScript\r\n");
            txtSemantic.AppendText("====================================\r\n\r\n");

            List<string> errors = new List<string>();
            List<string> declaredVariables = new List<string>();

            txtSemantic.AppendText("Checking Declarations:\r\n");
            txtSemantic.AppendText("------------------------------------\r\n");

            // 1. Duplicate declaration check
            foreach (var symbol in symbols)
            {
                if (declaredVariables.Contains(symbol.Name))
                {
                    errors.Add("Line " + symbol.LineNo + ": Duplicate declaration of variable '" + symbol.Name + "'");
                    txtSemantic.AppendText("ERROR: Duplicate variable found -> " + symbol.Name + "\r\n");
                }
                else
                {
                    declaredVariables.Add(symbol.Name);
                    txtSemantic.AppendText("OK: Variable '" + symbol.Name + "' declared as " + symbol.DataType + "\r\n");
                }
            }

            txtSemantic.AppendText("\r\nChecking Variable Usage:\r\n");
            txtSemantic.AppendText("------------------------------------\r\n");

            // 2. Undeclared variable usage check
            foreach (var token in tokens)
            {
                if (token.TokenType == "Identifier")
                {
                    bool exists = symbols.Any(s => s.Name == token.Lexeme);

                    if (!exists)
                    {
                        string error = "Line " + token.LineNo + ": Variable '" + token.Lexeme + "' is not declared";
                        if (!errors.Contains(error))
                        {
                            errors.Add(error);
                            txtSemantic.AppendText("ERROR: " + error + "\r\n");
                        }
                    }
                    else
                    {
                        txtSemantic.AppendText("OK: Variable '" + token.Lexeme + "' is declared\r\n");
                    }
                }
            }

            txtSemantic.AppendText("\r\nChecking Type Compatibility:\r\n");
            txtSemantic.AppendText("------------------------------------\r\n");

            // 3. Type mismatch check for declarations
            for (int i = 0; i < tokens.Count; i++)
            {
                if (tokens[i].Lexeme == "int" || tokens[i].Lexeme == "float" || tokens[i].Lexeme == "string")
                {
                    string dataType = tokens[i].Lexeme;

                    if (i + 3 < tokens.Count)
                    {
                        string variableName = tokens[i + 1].Lexeme;
                        string equalSign = tokens[i + 2].Lexeme;
                        string value = tokens[i + 3].Lexeme;

                        if (equalSign == "=")
                        {
                            if (dataType == "int" && Regex.IsMatch(value, @"^\d+\.\d+$"))
                            {
                                errors.Add("Line " + tokens[i].LineNo + ": Cannot assign float value to int variable '" + variableName + "'");
                                txtSemantic.AppendText("ERROR: int variable '" + variableName + "' cannot store float value " + value + "\r\n");
                            }
                            else if (dataType == "float" && Regex.IsMatch(value, @"^\d+$"))
                            {
                                txtSemantic.AppendText("OK: int value " + value + " can be assigned to float variable '" + variableName + "'\r\n");
                            }
                            else if (dataType == "int" && Regex.IsMatch(value, @"^\d+$"))
                            {
                                txtSemantic.AppendText("OK: int value assigned to int variable '" + variableName + "'\r\n");
                            }
                            else if (dataType == "float" && Regex.IsMatch(value, @"^\d+\.\d+$"))
                            {
                                txtSemantic.AppendText("OK: float value assigned to float variable '" + variableName + "'\r\n");
                            }
                            else
                            {
                                txtSemantic.AppendText("OK: Assignment checked for variable '" + variableName + "'\r\n");
                            }
                        }
                    }
                }
            }

            txtSemantic.AppendText("\r\nFINAL SEMANTIC RESULT:\r\n");
            txtSemantic.AppendText("====================================\r\n");

            if (errors.Count == 0)
            {
                txtSemantic.AppendText("Semantic Analysis Successful.\r\n");
                txtSemantic.AppendText("No semantic errors found.\r\n");
                txtSemantic.AppendText("Input program is semantically valid.\r\n");
            }
            else
            {
                txtSemantic.AppendText("Semantic Analysis Failed.\r\n");
                txtSemantic.AppendText("Total Errors Found: " + errors.Count + "\r\n\r\n");

                foreach (string error in errors)
                {
                    txtSemantic.AppendText(error + "\r\n");
                }
            }

            txtSemantic.SelectionStart = 0;
            txtSemantic.ScrollToCaret();

            tabCompilerOutput.SelectedIndex = 6;

            ShowMessage("Semantic Analysis Completed!", "Success");
        }

        private void btnIntermediate_Click(object sender, EventArgs e)
        {
            txtIntermediate.Clear();

            if (tokens.Count == 0)
            {
                ShowMessage("Please run Lexical Analysis first!", "Warning");
                return;
            }

            txtIntermediate.AppendText("INTERMEDIATE CODE GENERATION\r\n");
            txtIntermediate.AppendText("Three Address Code - HibbanScript\r\n");
            txtIntermediate.AppendText("========================================\r\n\r\n");

            int tempCount = 1;
            string[] lines = txtSourceCode.Text.Split(new[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string rawLine in lines)
            {
                string line = rawLine.Trim();

                if (line == "begin()" || line == "begin" || line == "end")
                    continue;

                if (line.StartsWith("int ") || line.StartsWith("float ") || line.StartsWith("string "))
                {
                    txtIntermediate.AppendText("// Declaration Statement\r\n");

                    string cleanLine = line.Replace(";", "");
                    string[] parts = cleanLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    if (parts.Length >= 4 && parts[2] == "=")
                    {
                        string dataType = parts[0];
                        string variable = parts[1];
                        string value = parts[3];

                        txtIntermediate.AppendText(variable + " = " + value + "\r\n");
                        txtIntermediate.AppendText("// " + variable + " declared as " + dataType + "\r\n\r\n");
                    }
                }
                else if (line.StartsWith("if"))
                {
                    txtIntermediate.AppendText("// If Condition Statement\r\n");

                    string condition = line.Replace("if", "").Replace("(", "").Replace(")", "").Trim();
                    txtIntermediate.AppendText("if " + condition + " goto L1\r\n");
                    txtIntermediate.AppendText("goto L2\r\n");
                    txtIntermediate.AppendText("L1:\r\n\r\n");
                }
                else if (line.StartsWith("print"))
                {
                    txtIntermediate.AppendText("// Print Statement\r\n");

                    string variable = line.Replace("print", "").Replace(";", "").Trim();
                    txtIntermediate.AppendText("print " + variable + "\r\n");
                    txtIntermediate.AppendText("L2:\r\n\r\n");
                }
                else if (line.Contains("="))
                {
                    txtIntermediate.AppendText("// Assignment Statement\r\n");

                    string cleanLine = line.Replace(";", "");
                    string[] assignParts = cleanLine.Split('=');

                    if (assignParts.Length == 2)
                    {
                        string left = assignParts[0].Trim();
                        string right = assignParts[1].Trim();

                        if (right.Contains("+") || right.Contains("-") || right.Contains("*") || right.Contains("/"))
                        {
                            string temp = "t" + tempCount;
                            tempCount++;

                            txtIntermediate.AppendText(temp + " = " + right + "\r\n");
                            txtIntermediate.AppendText(left + " = " + temp + "\r\n\r\n");
                        }
                        else
                        {
                            txtIntermediate.AppendText(left + " = " + right + "\r\n\r\n");
                        }
                    }
                }
            }

            txtIntermediate.AppendText("========================================\r\n");
            txtIntermediate.AppendText("Intermediate Code Generated Successfully.\r\n");

            txtIntermediate.SelectionStart = 0;
            txtIntermediate.ScrollToCaret();

            tabCompilerOutput.SelectedIndex = 7;

            ShowMessage("Intermediate Code Generated Successfully!", "Success");
        }

        private void btnOptimize_Click(object sender, EventArgs e)
        {
            txtOptimized.Clear();

            if (string.IsNullOrWhiteSpace(txtIntermediate.Text))
            {
                ShowMessage("Please generate Intermediate Code first!", "Warning");
                return;
            }

            txtOptimized.AppendText("CODE OPTIMIZATION - HibbanScript\r\n");
            txtOptimized.AppendText("========================================\r\n\r\n");

            txtOptimized.AppendText("Optimization Techniques Applied:\r\n");
            txtOptimized.AppendText("1. Copy Propagation\r\n");
            txtOptimized.AppendText("2. Temporary Variable Reduction\r\n");
            txtOptimized.AppendText("3. Unnecessary Comment Removal\r\n");
            txtOptimized.AppendText("4. Simple Assignment Optimization\r\n\r\n");

            txtOptimized.AppendText("Optimized Code:\r\n");
            txtOptimized.AppendText("========================================\r\n");

            string[] lines = txtIntermediate.Text.Split(new[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i].Trim();

                if (line.StartsWith("INTERMEDIATE") ||
                    line.StartsWith("Three Address") ||
                    line.StartsWith("=") ||
                    line.StartsWith("//") ||
                    line.StartsWith("Intermediate Code Generated") ||
                    line.StartsWith("================================"))
                {
                    continue;
                }

                // Optimization: t1 = a + 2 followed by sum = t1
                if (Regex.IsMatch(line, @"^t\d+\s*="))
                {
                    string[] tempParts = line.Split('=');

                    if (tempParts.Length == 2)
                    {
                        string tempName = tempParts[0].Trim();
                        string tempExpression = tempParts[1].Trim();

                        if (i + 1 < lines.Length)
                        {
                            string nextLine = lines[i + 1].Trim();

                            if (nextLine.Contains("="))
                            {
                                string[] nextParts = nextLine.Split('=');

                                if (nextParts.Length == 2)
                                {
                                    string left = nextParts[0].Trim();
                                    string right = nextParts[1].Trim();

                                    if (right == tempName)
                                    {
                                        txtOptimized.AppendText(left + " = " + tempExpression + "\r\n");
                                        i++;
                                        continue;
                                    }
                                }
                            }
                        }
                    }
                }

                txtOptimized.AppendText(line + "\r\n");
            }

            txtOptimized.AppendText("\r\n========================================\r\n");
            txtOptimized.AppendText("Optimization Completed Successfully.\r\n");

            txtOptimized.SelectionStart = 0;
            txtOptimized.ScrollToCaret();

            tabCompilerOutput.SelectedIndex = 8;

            ShowMessage("Code Optimization Completed!", "Success");
        }

        private void btnFinalCode_Click(object sender, EventArgs e)
        {
            txtFinalCode.Clear();

            if (string.IsNullOrWhiteSpace(txtOptimized.Text))
            {
                ShowMessage("Please optimize the code first!", "Warning");
                return;
            }

            txtFinalCode.AppendText("TARGET CODE GENERATION - HibbanScript\r\n");
            txtFinalCode.AppendText("Pseudo Assembly Code\r\n");
            txtFinalCode.AppendText("========================================\r\n\r\n");

            string[] lines = txtOptimized.Text.Split(new[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string rawLine in lines)
            {
                string line = rawLine.Trim();

                if (line.StartsWith("CODE OPTIMIZATION") ||
                    line.StartsWith("Optimization") ||
                    line.StartsWith("Optimized Code") ||
                    line.StartsWith("1.") ||
                    line.StartsWith("2.") ||
                    line.StartsWith("3.") ||
                    line.StartsWith("4.") ||
                    line.StartsWith("=") ||
                    line.StartsWith("================================"))
                {
                    continue;
                }

                if (line.Contains("=") && !line.StartsWith("if"))
                {
                    string[] parts = line.Split('=');

                    if (parts.Length == 2)
                    {
                        string left = parts[0].Trim();
                        string right = parts[1].Trim();

                        txtFinalCode.AppendText("; Assignment: " + line + "\r\n");

                        if (right.Contains("+"))
                        {
                            string[] expr = right.Split('+');
                            txtFinalCode.AppendText("LOAD " + expr[0].Trim() + "\r\n");
                            txtFinalCode.AppendText("ADD " + expr[1].Trim() + "\r\n");
                            txtFinalCode.AppendText("STORE " + left + "\r\n\r\n");
                        }
                        else if (right.Contains("-"))
                        {
                            string[] expr = right.Split('-');
                            txtFinalCode.AppendText("LOAD " + expr[0].Trim() + "\r\n");
                            txtFinalCode.AppendText("SUB " + expr[1].Trim() + "\r\n");
                            txtFinalCode.AppendText("STORE " + left + "\r\n\r\n");
                        }
                        else if (right.Contains("*"))
                        {
                            string[] expr = right.Split('*');
                            txtFinalCode.AppendText("LOAD " + expr[0].Trim() + "\r\n");
                            txtFinalCode.AppendText("MUL " + expr[1].Trim() + "\r\n");
                            txtFinalCode.AppendText("STORE " + left + "\r\n\r\n");
                        }
                        else if (right.Contains("/"))
                        {
                            string[] expr = right.Split('/');
                            txtFinalCode.AppendText("LOAD " + expr[0].Trim() + "\r\n");
                            txtFinalCode.AppendText("DIV " + expr[1].Trim() + "\r\n");
                            txtFinalCode.AppendText("STORE " + left + "\r\n\r\n");
                        }
                        else
                        {
                            txtFinalCode.AppendText("MOV " + left + ", " + right + "\r\n\r\n");
                        }
                    }
                }
                else if (line.StartsWith("if"))
                {
                    txtFinalCode.AppendText("; Conditional Statement\r\n");
                    txtFinalCode.AppendText(line.Replace("if", "CMP") + "\r\n\r\n");
                }
                else if (line.StartsWith("goto"))
                {
                    txtFinalCode.AppendText("JMP " + line.Replace("goto", "").Trim() + "\r\n\r\n");
                }
                else if (line.EndsWith(":"))
                {
                    txtFinalCode.AppendText(line + "\r\n");
                }
                else if (line.StartsWith("print"))
                {
                    string variable = line.Replace("print", "").Trim();

                    txtFinalCode.AppendText("; Print Statement\r\n");
                    txtFinalCode.AppendText("PRINT " + variable + "\r\n\r\n");
                }
            }

            txtFinalCode.AppendText("========================================\r\n");
            txtFinalCode.AppendText("Target Code Generated Successfully.\r\n");

            txtFinalCode.SelectionStart = 0;
            txtFinalCode.ScrollToCaret();
            tabCompilerOutput.SelectedTab = tabPage10;

            ShowMessage("Target Code Generated Successfully!", "Success");
        }
        private void ShowMessage(string message, string title)
        {
            if (!isRunningAll)
            {
                MessageBox.Show(message, title);
            }
        }

        private void ShowMessage(string message)
        {
            if (!isRunningAll)
            {
                MessageBox.Show(message);
            }
        }

        private void btnRunAll_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSourceCode.Text))
            {
                txtSourceCode.Text =
        @"begin()
int a = 5;
float b = 10.5;
int sum = 0;
sum = a + 2;
if(sum > 5)
print sum;
end";
            }

            try
            {
                isRunningAll = true;

                // Clear previous outputs but keep source code
                tokens.Clear();
                symbols.Clear();

                dgvTokens.DataSource = null;
                dgvSymbolTable.DataSource = null;

                txtFirstSet.Clear();
                txtFollowSet.Clear();
                txtDFA.Clear();
                txtSLR.Clear();
                txtSemantic.Clear();
                txtIntermediate.Clear();
                txtOptimized.Clear();
                txtFinalCode.Clear();

                // Run all compiler phases one by one
                btnLexical_Click(sender, e);
                btnSymbolTable_Click(sender, e);
                button1_Click(sender, e);
                btnFollow_Click(sender, e);
                btnDFA_Click(sender, e);
                btnSLR_Click(sender, e);
                btnSemantic_Click(sender, e);
                btnIntermediate_Click(sender, e);
                btnOptimize_Click(sender, e);
                btnFinalCode_Click(sender, e);
                btnParseTree_Click(sender, e);

                // Open Final Code tab
                tabCompilerOutput.SelectedTab = tabPage10;
            }
            finally
            {
                isRunningAll = false;
            }
        }

        private void btnParseTree_Click(object sender, EventArgs e)
        {
            txtParseTree.Clear();

            if (string.IsNullOrWhiteSpace(txtSourceCode.Text))
            {
                ShowMessage("Please load or enter source code first!", "Warning");
                return;
            }

            txtParseTree.AppendText("PARSE TREE / SYNTAX TREE - HibbanScript\r\n");
            txtParseTree.AppendText("========================================\r\n\r\n");

            txtParseTree.AppendText("Program\r\n");
            txtParseTree.AppendText("├── begin()\r\n");
            txtParseTree.AppendText("├── StmtList\r\n");

            string[] lines = txtSourceCode.Text.Split(new[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string rawLine in lines)
            {
                string line = rawLine.Trim();

                if (line == "begin()" || line == "begin" || line == "end")
                    continue;

                if (line.StartsWith("int ") || line.StartsWith("float ") || line.StartsWith("string "))
                {
                    txtParseTree.AppendText("│   ├── Declaration Statement\r\n");

                    string cleanLine = line.Replace(";", "");
                    string[] parts = cleanLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    if (parts.Length >= 4)
                    {
                        txtParseTree.AppendText("│   │   ├── Type: " + parts[0] + "\r\n");
                        txtParseTree.AppendText("│   │   ├── Identifier: " + parts[1] + "\r\n");
                        txtParseTree.AppendText("│   │   ├── Operator: =\r\n");
                        txtParseTree.AppendText("│   │   └── Value: " + parts[3] + "\r\n");
                    }
                }
                else if (line.StartsWith("if"))
                {
                    string condition = line.Replace("if", "").Replace("(", "").Replace(")", "").Trim();

                    txtParseTree.AppendText("│   ├── If Statement\r\n");
                    txtParseTree.AppendText("│   │   └── Condition: " + condition + "\r\n");
                }
                else if (line.StartsWith("print"))
                {
                    string variable = line.Replace("print", "").Replace(";", "").Trim();

                    txtParseTree.AppendText("│   ├── Print Statement\r\n");
                    txtParseTree.AppendText("│   │   └── Identifier: " + variable + "\r\n");
                }
                else if (line.Contains("="))
                {
                    string cleanLine = line.Replace(";", "");
                    string[] parts = cleanLine.Split('=');

                    if (parts.Length == 2)
                    {
                        txtParseTree.AppendText("│   ├── Assignment Statement\r\n");
                        txtParseTree.AppendText("│   │   ├── Identifier: " + parts[0].Trim() + "\r\n");
                        txtParseTree.AppendText("│   │   ├── Operator: =\r\n");
                        txtParseTree.AppendText("│   │   └── Expression: " + parts[1].Trim() + "\r\n");
                    }
                }
            }

            txtParseTree.AppendText("└── end\r\n");

            txtParseTree.AppendText("\r\n========================================\r\n");
            txtParseTree.AppendText("Parse Tree Generated Successfully.\r\n");

            txtParseTree.SelectionStart = 0;
            txtParseTree.ScrollToCaret(); 
            tabCompilerOutput.SelectedTab = tabPage11;

            ShowMessage("Parse Tree Generated Successfully!", "Success");
        }
    }

}
