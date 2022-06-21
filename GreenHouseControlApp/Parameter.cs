using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class Parameter
    {
        TextBox display;
        Button increaseValue;
        Button decreaseValue;

        //  NOTE: dot wanted, not comma - it's causing conversion errors
        CultureInfo currentCulture = CultureInfo.GetCultureInfo("en-US");

        float currentSetValue = 20.00f;
        float amount;

        string currentSetValueString;

        public Parameter(ref TextBox setParameter, ref Button inV, ref Button decV, ref float step)
        {
            this.display = setParameter;
            this.increaseValue = inV;
            this.decreaseValue = decV;
            this.amount = step;

            currentSetValueString = Convert.ToString((currentSetValue).ToString("0.0",currentCulture));
            setParameter.Text = String.Format("{0:F1}", currentSetValueString);

            inV.Click += new EventHandler(btnIncreaseValue_clicked);
            decV.Click += new EventHandler(btnDecreaseValue_clicked);
        }

        private void btnDecreaseValue_clicked(object sender, EventArgs e)
        {
            currentSetValue -= amount;

            currentSetValueString = Convert.ToString((currentSetValue).ToString("0.0", currentCulture));
            display.Text = String.Format("{0:F1}", currentSetValueString);
        }

        private void btnIncreaseValue_clicked(object sender, EventArgs e)
        {
            currentSetValue += amount;

            currentSetValueString = Convert.ToString((currentSetValue).ToString("0.0", currentCulture));
            display.Text = String.Format("{0:F1}", currentSetValueString);
        }
    }
}
