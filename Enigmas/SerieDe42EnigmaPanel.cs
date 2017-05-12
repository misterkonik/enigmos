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
            lblQuestion.Width = 10;


            lblQuestionReponse = new Label();
            lblQuestionReponse.Text = "42";
            lblQuestionReponse.Location = new System.Drawing.Point(100, 0);


            Controls.Add(lblQuestion);
            Controls.Add(lblQuestionReponse);
        }
    }
}
