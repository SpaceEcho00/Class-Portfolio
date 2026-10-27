using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Class_Portfolio
{
    public partial class Grading : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnComputeGrade_Click(object sender, EventArgs e)
        {
            //declare program variable
            double catMark, attendance, project, exam, final;
            char grade = ' ';
            //assign values
            catMark = Convert.ToDouble(txtCatMark.Text);
            attendance = Convert.ToDouble(TxtAttendanceMark.Text);
            project = Convert.ToDouble(txtProjectMark.Text);
            exam = Convert.ToDouble(txtExamMark.Text);
            //GET FINAL SCORE
            final = catMark + attendance + project + exam;
            //make program revisions
            if (final < 0 || final > 100)
                return;
            else
            {
                if (final >= 70 && final <= 100)
                    grade = 'A';
                if (final >= 60 && final <= 69)
                    grade = 'B';
                if (final >= 50 && final <= 59)
                    grade = 'C';
                if (final >= 40 && final <= 49)
                    grade = 'D';
                if (final >= 0 && final <= 39)
                    grade = 'F';

            }
            litOutput.Text = "Final Score\t" + final + "\tGrade\t" + grade;
        }
    }
}   