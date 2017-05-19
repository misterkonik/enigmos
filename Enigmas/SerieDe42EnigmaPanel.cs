using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cpln.Enigmos.Enigmas
{
   public class SerieDe42EnigmaPanel : EnigmaPanel
    {
       private Label lblQuestion;
       private Label lblQuestionReponse;
       private Label lblFausseReponse;

        public SerieDe42EnigmaPanel()
        {
            lblQuestion = new Label();
            lblQuestion.Text = "Cliquez sur ";
            lblQuestion.Location = new System.Drawing.Point(0, 0);
            lblQuestion.Width = 59;


            lblQuestionReponse = new Label();
            lblQuestionReponse.Text = "42";
            lblQuestionReponse.Location = new System.Drawing.Point(56, 0);
            lblQuestionReponse.Click += new EventHandler(LblQuestionReponse_Click);

            lblFausseReponse = new Label();
            lblFausseReponse.BackColor = System.Drawing.Color.Pink;
            lblFausseReponse.Width = 800;
            lblFausseReponse.Height = 500;
            lblFausseReponse.Location = new System.Drawing.Point(0, 56);

            for(int i = 0; i<20;i++)
            {
                for (int x = 0; x <53;x++)
                {
                    lblFausseReponse.Text += "42 ";
                }
                lblFausseReponse.Text += "\n";
            }

            Controls.Add(lblQuestion);
            Controls.Add(lblQuestionReponse);
            Controls.Add(lblFausseReponse);
        }

        private void LblQuestionReponse_Click(object sender, EventArgs e)
        {
            string message = "monarchie constitutionnelle";
            string caption = "Réponse";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;

            // Displays the MessageBox.

            result = MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.OK)
            {
            }
        }
    }
}
