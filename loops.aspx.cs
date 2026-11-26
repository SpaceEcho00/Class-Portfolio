using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Class_Portfolio
{
    public partial class loops : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnforloop_Click(object sender, EventArgs e)
        {
            // Clear the list box
            lstNumbers.Items.Clear();

            // Declare variables
            int i, count = 0, sum = 0;
            double avg = 0;

            for (i = 0; i <= 50; i++)
            {
                if (i % 2 == 0)
                {
                    lstNumbers.Items.Add(
                        string.Format("No {0}\t\t{1}", count + 1, i));
                    count += 1;
                    sum += i;
                }
            }

            // Compute average of even numbers (cast to avoid integer division)
            if (count > 0)
            {
                avg = (double)sum / count;
            }

            lstNumbers.Items.Add("Total even numbers\t" + count.ToString());
            lstNumbers.Items.Add("Sum of even numbers\t" + sum.ToString());
            lstNumbers.Items.Add("Average of even numbers\t" + avg.ToString("F2"));
        }

        protected void btnwhileloop_Click(object sender, EventArgs e)
        {
            // Clear the list box
            lstNumbers.Items.Clear();

            // Declare variables
            int i=0, count = 0, sum = 0;
            double avg = 0;

            while (i < 50)
            {
                if (i % 2 == 0)
                {
                    lstNumbers.Items.Add(
                        string.Format("No {0}\t\t{1}", count + 1, i));
                    count += 1;
                    sum += i;
                }
                i++;
            }

            // Compute average of even numbers (cast to avoid integer division)
            if (count > 0)
            {
                avg = (double)sum / count;
            }

            lstNumbers.Items.Add("Total even numbers\t" + count.ToString());
            lstNumbers.Items.Add("Sum of even numbers\t" + sum.ToString());
            lstNumbers.Items.Add("Average of even numbers\t" + avg.ToString("F2"));
        }

        protected void btndowhile_Click(object sender, EventArgs e)
        {
            // Clear the list box
            lstNumbers.Items.Clear();

            // Declare variables
            int i = 0, count = 0, sum = 0;
            double avg = 0;

            do
            {
                if (i % 2 == 0)
                {
                    lstNumbers.Items.Add(
                        string.Format("No {0}\t\t{1}", count + 1, i));
                    count += 1;
                    sum += i;
                }
                i++;
            } while (i < 50);   // <-- condition goes HERE, right after the loop body

            // Compute average of even numbers (cast to avoid integer division)
            if (count > 0)
            {
                avg = (double)sum / count;
            }

            lstNumbers.Items.Add("Total even numbers\t" + count.ToString());
            lstNumbers.Items.Add("Sum of even numbers\t" + sum.ToString());
            lstNumbers.Items.Add("Average of even numbers\t" + avg.ToString("F2"));

        }
    }
}