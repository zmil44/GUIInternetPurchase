/*Zachary Miller
 * 12/20/2017
 * assignment 7.2
 * This contains the code to display the message boxes
 * MessageBox.cs
 * Bellevue University
 */
 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_7._2
{
    public partial class MessageBox : Form
    {
        public MessageBox()
        {
            
            InitializeComponent();
            String message = "Would you like Internet Access?";
            String caption = "Internet";
            DialogResult result = System.Windows.Forms.MessageBox.Show(message, caption, MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                message = "If you would like Unlimited access ($19.95/month), press yes, if you would like Limited internet access ($10.95/month), press no.";
                result = System.Windows.Forms.MessageBox.Show(message, caption, MessageBoxButtons.YesNo);

                if(result==DialogResult.Yes)
                {
                    message = "Your total price is $19.95";
                    System.Windows.Forms.MessageBox.Show(message, caption, MessageBoxButtons.OK);
                }
                else if(result==DialogResult.No)
                {
                    message = "Your total price is $10.95";
                    System.Windows.Forms.MessageBox.Show(message, caption, MessageBoxButtons.OK);
                }
            }

            else
            {
                
                message = ("Your total price is $0");
                System.Windows.Forms.MessageBox.Show(message, caption, MessageBoxButtons.OK);
            }
        }
    }
}
