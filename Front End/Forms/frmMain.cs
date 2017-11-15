using MetroFramework;
using MetroFramework.Forms;
using SimplexGUI.Classes;
using SimplexGUI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplexGUI
{
    public partial class frmMain : MetroForm
    {
        //Construtor...
        public frmMain()
        {
            InitializeComponent();

            InitializeDefaultColumns();
        }

        #region Events

        //Evento para adicionar variáveis (colunas)
        private void BtnAddVar_Click(object sender, EventArgs e)
        {
            //Adiciona a nova variável a lista
            Globals.SimplexVars.Add(new SimplexVariables
            {
                Name = "x" + (Globals.SimplexVars.Count()+1),
                Value = 0.0d
            });

            //Insere uma nova coluna na tabela para representar a variável
            GridViewProblem.Columns.Insert(GridViewProblem.Columns.Count - 2, new DataGridViewColumn
            {
                Name = Globals.SimplexVars.Last().Name,
                HeaderText = Globals.SimplexVars.Last().Name,
                ValueType = typeof(double),
                CellTemplate = new DataGridViewTextBoxCell(),
                Visible = true
            });

            //Para cada linha da tabela adicionar a nova variável com o valor padrão de 0
            for(int row = 0; row < GridViewProblem.Rows.Count; row++)
            {
                var editedCell = GridViewProblem.Rows[row].Cells[GridViewProblem.Columns.Count - 3];

                editedCell.Value = 0.0d;

                Globals.SimplexProblem.Find(i => i.RowIndex == row).Variables[GridViewProblem.Columns[GridViewProblem.Columns.Count - 3].HeaderText] = 0.0d;
            }
        }

        //Evento para deletar a última variável criada
        private void BtnDeleteVar_Click(object sender, EventArgs e)
        {
            //Verifica se há colunas suficientes para remover
            if (GridViewProblem.Columns.Count > 3)
            {
                //Remove a variável da lista global
                Globals.SimplexVars.Remove(Globals.SimplexVars.Last());

                //Remove a coluna da tabela
                GridViewProblem.Columns.Remove(GridViewProblem.Columns[GridViewProblem.Columns.Count - 3]);
            }
        }

        //Evento para remover a última restrição criada
        private void BtnRemoveRestriction_Click(object sender, EventArgs e)
        {
            //Verifica se há linhas suficientes para remover
            if (GridViewProblem.Rows.Count > 1)
            {
                //Remove a restrição da lista global
                Globals.SimplexProblem.Remove(Globals.SimplexProblem.Last());

                //Remove a linha da tabela
                GridViewProblem.Rows.Remove(GridViewProblem.Rows[GridViewProblem.Rows.Count - 1]);
            }
        }

        //Evento para adicionar restrições (linhas)
        private void BtnAddRestriction_Click(object sender, EventArgs e)
        {
            //Adciona uma nova restrição na lista global
            Globals.SimplexProblem.Add(new SimplexEquation
            {
                Name = "R" + Globals.SimplexProblem.Count
            });

            //Cria e atribui a linha criada na tabela a sua restrição na lista
            Globals.SimplexProblem.Last().RowIndex = GridViewProblem.Rows.Add(Globals.SimplexProblem.Last().Name);

            //Para cada variável já existente atribui seu valor a zero na linha criada e na restrição
            for (int column = 1; column < GridViewProblem.Columns.Count - 2; column++)
            {
                var editedCell = GridViewProblem.Rows[Globals.SimplexProblem.Last().RowIndex].Cells[column];

                editedCell.Value = 0.0d;

                Globals.SimplexProblem.Last().Variables[GridViewProblem.Columns[column].HeaderText] = 0.0d;
            }
        }

        //Evento chamado quando uma celula da tabela é editada
        private void GridViewProblem_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //Recuperar a celula sendo editada
            var editedCell = GridViewProblem.Rows[e.RowIndex].Cells[e.ColumnIndex];

            //Achar a restrição correspondente a celula editada
            var problem = Globals.SimplexProblem.Find(i => i.RowIndex == e.RowIndex);

            //Atribuir o valor novo da celula a variavel correta da restrição
            if (e.ColumnIndex < GridViewProblem.Columns.Count - 2)
            {
                problem.Variables[GridViewProblem.Columns[e.ColumnIndex].HeaderText] = Convert.ToDouble(editedCell.Value);
            }
            else if (e.RowIndex != 0)
            {
                if (e.ColumnIndex == GridViewProblem.Columns.Count - 1)
                {
                    problem.LimitValue = Convert.ToDouble(editedCell.Value);
                }
                else
                {
                    problem.Operator = editedCell.Value.ToString();
                }
            }
        }

        //Evento chamado quando ocorre algum erro na tabela
        private void GridViewProblem_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;

            MetroMessageBox.Show(this, "Certifique-se que o dado fornecido é um número real!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Evento para disparar a requisição POST pro WebService
        private void BtnSend_Click(object sender, EventArgs e)
        {
            //Valida o problema e realiza o POST
            if (IsValidProblem())
            {
                DoPostAsync();
            }
        }

        #endregion

        #region Methods

        //Realiza o POST para o WebService
        private async Task DoPostAsync()
        {
            //Gera a lista de conteudo e faz o encoding dele
            var content = new FormUrlEncodedContent(GenerateContent());

            HttpResponseMessage response = null;

            //Faz a requisição POST para a API selecionada e aguarda resposta
            if (RbtnCustomAPI.Checked)
            {
                response = await Globals.WebClient.PostAsync("https://simplexotimiza.azurewebsites.net/", content);
            }
            else
            {
                response = await Globals.WebClient.PostAsync("https://glpkotimiza.azurewebsites.net/", content);
            }

            //Extrai o texto da resposta
            var responseString = await response.Content.ReadAsStringAsync();

            //Mostra a resposta para o usuário em uma outra tela
            frmAnswer newForm = new frmAnswer(responseString.Replace("\n", Environment.NewLine));
            newForm.Show();
            newForm.Focus();
        }

        //Gera o conteúdo a partir dos dados informados
        private Dictionary<string, string> GenerateContent()
        {
            Dictionary<string, string> contentToEncode = new Dictionary<string, string>();

            //Acrescenta informações ao conteúdo como quantidade de variáves, restrições, etc...
            contentToEncode.Add("Type", (RbtnMax.Checked) ? "MAX" : "MIN");
            contentToEncode.Add("RestrictionCount", (Globals.SimplexProblem.Count - 1).ToString());
            contentToEncode.Add("VariableCount", Globals.SimplexVars.Count.ToString());
            //contentToEncode.Add("PrintHistory", "1");

            string fullDescription = "";

            //Pega todas as equações e as formata de maneira adequada
            foreach (var item in Globals.SimplexProblem)
            {
                //Formata de acordo com a API escolhida
                if(RbtnCustomAPI.Checked)
                {
                    contentToEncode.Add(item.Name, item.GetFullEquationAlternative());
                }
                else
                {
                    contentToEncode.Add(item.Name, item.GetFullEquation());
                }

                fullDescription += item.GetDescriptiveEquation() + ";";
            }

            //Envia o problema original de maneira formatada
            contentToEncode.Add("Description", fullDescription);

            return contentToEncode;
        }

        //Valida os dados inseridos
        private bool IsValidProblem()
        {
            string errorMessage = "";

            foreach (var item in Globals.SimplexProblem)
            {
                if(String.Equals(item.Name, "FO(Z)") == false)
                {
                    if(item.LimitValue.HasValue == false)
                    {
                        errorMessage += "A restrição ( " + item.Name + " ) tem que ter um valor de limite definido!" + Environment.NewLine;
                    }
                    if (item.Operator == null)
                    {
                        errorMessage += "A restrição ( " + item.Name + " ) tem que ter um operador definido!" + Environment.NewLine;
                    }
                }
            }

            if (String.IsNullOrEmpty(errorMessage) == false)
            {
                MetroMessageBox.Show(this, errorMessage, "Erro na validação!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            return true;
        }

        //Adiciona as colunas e linhas iniciais obrigatórias a tabela
        private void InitializeDefaultColumns()
        {
            GridViewProblem.Columns.Add(new DataGridViewColumn
            {
                Name = "Id",
                HeaderText = "Id",
                ValueType = typeof(string),
                CellTemplate = new DataGridViewTextBoxCell(),
                Visible = true,
                ReadOnly = true
            });

            DataGridViewComboBoxColumn limitCbx = new DataGridViewComboBoxColumn();
            limitCbx.HeaderText = "Operador";
            limitCbx.Name = "Operador";
            limitCbx.Items.Add(">=");
            limitCbx.Items.Add("<=");

            GridViewProblem.Columns.Add(limitCbx);

            GridViewProblem.Columns.Add(new DataGridViewColumn
            {
                Name = "Limite",
                HeaderText = "Limite",
                ValueType = typeof(double),
                CellTemplate = new DataGridViewTextBoxCell(),
                Visible = true
            });

            Globals.SimplexProblem.Add(new SimplexEquation
            {
                Name = "FO(Z)",
                RowIndex = GridViewProblem.Rows.Add("FO(Z)")
            });

            for (int column = GridViewProblem.Columns.Count - 2; column < GridViewProblem.Columns.Count; column++)
            {
                var editedCell = GridViewProblem.Rows[Globals.SimplexProblem.Last().RowIndex].Cells[column];

                editedCell.ReadOnly = true;
            }
        }

        #endregion
    }
}
