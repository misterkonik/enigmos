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
            lblQuestion = new Label() {Text = "Cliquez sur",Location = new System.Drawing.Point(0, 0),Width = 110,Font = new System.Drawing.Font(Font.FontFamily, 15)};

            lblQuestionReponse = new Label() { Text = "42",Location = new System.Drawing.Point(105, 0),Width =35,Font= new System.Drawing.Font(Font.FontFamily, 15)};
            lblQuestionReponse.Click += LblQuestionReponse_Click;

            lblFausseReponse = new Label() {BackColor = System.Drawing.Color.Pink,Width=800,Height=540,Location = new System.Drawing.Point(0, 56),Cursor=Cursors.Hand };

            for(int i = 0; i<21;i++)
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

            result = MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.OK){}

        }
    }
}
